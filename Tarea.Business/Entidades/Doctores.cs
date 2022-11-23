using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tarea.Business.Interfaces;
using System.Numerics;

namespace Tarea.Business.Entidades
{
    public class Doctores: Persona, IEntity
    {
        public readonly string Path = "";
        public readonly IRepository<Doctores> repository;
        public string Cedula { get; set; }
        public string NumeroDeTelefono { get; set; }
        #region constructores
        public Doctores(IRepository<Doctores> repo)
        {
            repository = repo;
        }
        public Doctores()
        {

        }
        public Doctores(IRepository<Doctores> repo, string nombre, string apellido, string cedula, string telefono)
        {
            repository = repo;
            Nombre = nombre;
            Apellido = apellido;
            this.Cedula = cedula;
            this.NumeroDeTelefono = telefono;
        }
        #endregion
        public override string ToString()
        {
            return $"{Id}, {Nombre}, {Apellido},{Cedula},{NumeroDeTelefono}";
        }
        public void AgregarDoctor(Doctores doctor)
        {
            //Todo: Validar datos de entrada
            if (String.IsNullOrEmpty(doctor.Nombre) || String.IsNullOrEmpty(doctor.Apellido))
            {
                throw new ArgumentException("Las propiedades deben tener un valor. " +
                    "La propiedadad Nombre o Apellidos estan vacias");
            }
            //Buscar si existe el cliente en la base de datos
            var result = repository.Consultar().Where(x =>
                            x.Nombre.ToUpper().Equals(doctor.Nombre.ToUpper()) &&
                            x.Apellido.ToUpper().Equals(doctor.Apellido.ToUpper())
                         ).ToList();
            if (result.Count != 0)
            {
                throw new ArgumentException("El cliente ya existe");
            }
            repository.Agregar(doctor);
        }
        public List<Doctores> Cargar_Doctores()
        {
            return repository.Consultar();
        }
        public void Guardar(List<Doctores> doctores)
        {
            repository.Guardar(doctores);
        }
        //private readonly string path = "C:\\Users\\martin.ponce\\Documents\\prueba\\tarea.csv";
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        //public string cedula { get; set; }
        //public string telefono { get; set; }
        //public Doctores()
        //{
        //}



        //public override string ToString()
        //{
        //    return $"{Nombre},{Apellido},{cedula},{telefono}";
        //}
        public void Agregar_Doctor()
        {

            Doctores doctor = new Doctores()
            {
                Nombre = Nombre,
                Apellido = Apellido,
                Cedula = Cedula,
                NumeroDeTelefono = NumeroDeTelefono
            };

            Agregar_Doctor(doctor);

        }
        public void Agregar_Doctor(Doctores doctor)
        {
            //if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido))
            //{
            //    throw new ArgumentException("Los valores no deben estar vacios");
            //}
            //using (StreamWriter strWriter = new StreamWriter(path, true))
            //{

            //    strWriter.WriteLine(doctor.ToString());
            //    strWriter.Close();
            //}
        }
        //public List<Doctores> Cargar_Doctores()
        //{
        //    List<Doctores> ListaDoctores = new();

        //    if (File.Exists(path))
        //    {
        //        /*Leer archivo*/
        //        using (StreamReader strReader = new StreamReader(path))
        //        {
        //            string ln = string.Empty;

        //            while ((ln = strReader.ReadLine()) != null)
        //            {
        //                string[] campos = ln.Split(",");

        //                Doctores doctor = new()
        //                {
        //                    Nombre = campos[0],
        //                    Apellido = campos[1],
        //                    cedula = campos[2],
        //                    telefono = campos[3]
        //                };
        //                ListaDoctores.Add(doctor);
        //            }
        //        }
        //    }
        //    return ListaDoctores;
        //}
        //public void GuardarListaDoctores(List<Doctores> ListaDoctores)
        //{
        //    foreach (Doctores doctor in ListaDoctores)
        //    {
        //        using (StreamWriter strWriter = new StreamWriter(path, true))
        //        {
        //            strWriter.WriteLine(doctor.ToString());
        //            strWriter.Close();
        //        }

        //    }
        //}
    }
}
