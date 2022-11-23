using Tarea.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            var doctoresForm = new DoctoresForm();
            doctoresForm.ShowDialog();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            var clientesForm = new ClientesForm();
            clientesForm.ShowDialog();
        }

        private void btn_cita_Click(object sender, EventArgs e)
        {
            var citasForm = new CitasForm();
            citasForm.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}