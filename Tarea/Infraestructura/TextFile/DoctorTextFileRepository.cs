using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Business.Entidades;
using Tarea.Business.Interfaces;

namespace Tarea.Infraestructura.TextFile
{
    public class DoctroeTextFileRepository : IRepository<Doctores>
    {
        private const string path = "C:\\Users\\martin.ponce\\Documents\\prueba";

        public void Agregar(Doctores entity)
        {
            using (StreamWriter strWriter = new StreamWriter(path, true))
            {

                strWriter.WriteLine(entity.ToString());
                strWriter.Close();
            }
        }

        public List<Doctores> Consultar()
        {
            if (!System.IO.File.Exists(path))
            {
                return new List<Doctores>();
            }

            using (StreamReader strReader = new StreamReader(path))
            {

                List<Doctores> doctores = new List<Doctores>();
                string ln = string.Empty;

                while ((ln = strReader.ReadLine()) != null)
                {
                    string[] campos = ln.Split(",");

                    Doctores doctor = new Doctores()
                    {
                        Id = campos[0],
                        Nombre = campos[1],
                        Apellido = campos[2],
                        Cedula = campos[3],
                        NumeroDeTelefono = campos[4]
                    };
                    doctores.Add(doctor);
                }

                return doctores;
            }
        }

        public Doctores ConsultarPorId(string id)
        {
            return Consultar().Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public void Guardar(List<Doctores> entidades)
        {
            foreach (Doctores doctor in entidades)
            {
                using (StreamWriter strWriter = new StreamWriter(path, true))
                {
                    strWriter.WriteLine(doctor.ToString());
                    strWriter.Close();
                }

            }
        }
    }
}

