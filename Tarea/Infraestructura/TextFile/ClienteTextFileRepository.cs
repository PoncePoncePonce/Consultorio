using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Business.Entidades;
using Tarea.Business.Interfaces;

namespace Tarea.Infraestructura.TextFile
{
    public class ClienteTextFileRepository : IRepository<Clientes>
    {
        private const string path = "C:\\Users\\martin.ponce\\Documents\\prueba";

        public void Agregar(Clientes entity)
        {
            using (StreamWriter strWriter = new StreamWriter(path, true))
            {

                strWriter.WriteLine(entity.ToString());
                strWriter.Close();
            }
        }

        public List<Clientes> Consultar()
        {
            if (!System.IO.File.Exists(path))
            {
                return new List<Clientes>();
            }

            using (StreamReader strReader = new StreamReader(path))
            {

                List<Clientes> clientes = new List<Clientes>();
                string ln = string.Empty;

                while ((ln = strReader.ReadLine()) != null)
                {
                    string[] campos = ln.Split(",");

                    Clientes cliente = new Clientes()
                    {
                        Id = campos[0],
                        Nombre = campos[1],
                        Apellido = campos[2],
                        FechaNacimiento = DateTime.Parse(campos[3]),
                        Direccion = campos[4]
                    };
                    clientes.Add(cliente);
                }

                return clientes;
            }
        }

        public Clientes ConsultarPorId(string id)
        {
            return Consultar().Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public void Guardar(List<Clientes> entidades)
        {
            foreach (Clientes cliente in entidades)
            {
                using (StreamWriter strWriter = new StreamWriter(path, true))
                {
                    strWriter.WriteLine(cliente.ToString());
                    strWriter.Close();
                }

            }
        }
    }
}
