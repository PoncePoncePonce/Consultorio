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
using Tarea.Infraestructura.InMemory;
using Tarea.Infraestructura.SQL.SQL_Server.Contextos;
using Tarea.Infraestructura.SQL.SQL_Server.Repositorios;
using Tarea.Infraestructura.SQL.SQLite.Contextos;
using Tarea.Infraestructura.SQL.SQLite.Repositorios;
using Tarea.Infraestructura.TextFile;

namespace Tarea.Forms
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
            Ejemplo(1);
        }
        public void Ejemplo(int option)
        {
            IRepository<Clientes> repo;
            switch (option)
            {
                case 0:
                    repo = new ClientesSQLRepository(new SQLContext());
                    break;
                case 1:
                    repo = new ClienteTextFileRepository();
                    break;
                case 2:
                    repo = new ClienteSqliteRepository(new SqliteContext());
                    break;
                default:
                    repo = new ClienteMemoryRepository();
                    break;
            }
            var cliente = new Clientes(repo);
            cliente.AgregarCliente(new Clientes(repo)
            {
                Nombre = "Martin",
                Apellido = "Ponce",
                Id = Guid.NewGuid().ToString()
            });
            cliente.AgregarCliente(new Clientes(repo)
            {
                Nombre = "Alan",
                Apellido = "Chavez",
                Id = Guid.NewGuid().ToString()
            });
            cliente.AgregarCliente(new Clientes(repo)
            {
                Nombre = "Tommito",
                Apellido = "Ponce",
                Id = Guid.NewGuid().ToString()
            });
            cliente.Cargar_Clientes().ForEach(x =>
            {
                MessageBox.Show(x.Nombre);
            });
        }
    }
}
