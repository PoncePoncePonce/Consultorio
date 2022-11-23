using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea.Business.Entidades;
using Tarea.Business.Interfaces;
using Tarea.Infraestructura.SQL.SQL_Server.Contextos;
using Tarea.Infraestructura.SQL.SQL_Server.Repositorios;

namespace Tarea.Forms
{
    public partial class DoctoresForm : Form
    {
        public List<Doctores> ListaDoctores = new List<Doctores>();
        //ListaDoctores = new List<Doctores>();
        public DoctoresForm()
        {
            InitializeComponent();

    }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                IRepository<Doctores> repo = new DoctorSQLRepository(new SQLContext());
                var doctor = new Doctores(repo, txt_nombre.Text,
                            txt_Apellido.Text,
                            txt_cedula.Text,
                            txt_telefono.Text);

                //Agrega un elemento a la lista de tareas List<ToDo>
                doctor.Agregar_Doctor();

                ListaDoctores.Add(doctor);

                LimpiarFormulario();

                dtgDoctores.DataSource = null;
                dtgDoctores.DataSource = ListaDoctores;
                dtgDoctores.Refresh();
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
        private void Todolist_Shown(object sender, EventArgs e)
        {
            try
            {
                var doctor = new Doctores();
                ListaDoctores = doctor.Cargar_Doctores();
                dtgDoctores.DataSource = ListaDoctores;
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
                txt_nombre.Text = string.Empty;
                txt_Apellido.Text = string.Empty;
                txt_cedula.Text = string.Empty;
                txt_telefono.Text = string.Empty;

            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error.", "Informativo");
            }
            finally
            {
                txt_nombre.Text = string.Empty;
                txt_Apellido.Text = string.Empty;
                txt_cedula.Text = string.Empty;
                txt_telefono.Text = string.Empty;
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
