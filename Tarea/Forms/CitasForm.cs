using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea.Business.Entidades;

namespace Tarea.Forms
{
    public partial class CitasForm : Form
    {
        public List<Citas> ListaCitas = new List<Citas>();
        public List<Clientes> ListaClientes = new List<Clientes>();
        public List<Doctores> ListaDoctores = new List<Doctores>();

        public CitasForm()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var nombreDoc = txt_doc.Text.Trim().ToUpper();
                var doctor = ListaDoctores.Where<Doctores>(x => x.Nombre.ToUpper().Equals(nombreDoc)).FirstOrDefault();
                if (doctor == null)
                {
                    MessageBox.Show("Introduce un Doctor valido", "Error");
                    return;
                }
                var cita = new Citas(txt_doc.Text,
                            txt_cli.Text,
                            dtp_fecha.Value);
                cita.Agregar_Cita();
                ListaCitas.Add(cita);

                LimpiarFormulario();

                dtg_citas.DataSource = null;
                dtg_citas.DataSource = ListaCitas;
                dtg_citas.Refresh();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error.", "Informativo");

            }
        }
        private void Todo_Shown(object sender, EventArgs e)
        {
            try
            {
                //citas
                var cita = new Citas();
                ListaCitas = cita.Cargar_Citas();
                dtg_citas.DataSource = ListaCitas;
                //clientes
                var cliente = new Clientes();
                ListaClientes = cliente.Cargar_Clientes();
                dtg_clientes.DataSource = ListaClientes;
                //docs
                var doctor = new Doctores();
                ListaDoctores = doctor.Cargar_Doctores();
                dtg_doctores.DataSource = ListaDoctores;
                cmb_doctor.DataSource = ListaDoctores;
                cmb_doctor.DisplayMember = "Nombre";

            }
            catch (Exception)
            {

                MessageBox.Show("Ha ocurrido un error.", "Informativo");

            }

        }
        private void LimpiarFormulario()
        {
            try
            {
                txt_doc.Text = string.Empty;
                txt_cli.Text = string.Empty;
                dtp_fecha.Value = DateTime.Today;

            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error.", "Informativo");
            }
            finally
            {
                txt_doc.Text = string.Empty;
                txt_cli.Text = string.Empty;
                dtp_fecha.Value = DateTime.Today;
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
