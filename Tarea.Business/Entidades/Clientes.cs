using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Business.Interfaces;

namespace Tarea.Business.Entidades
{
    public class Clientes : Persona, IEntity
    {
        public readonly string Path = "";
        public readonly IRepository<Clientes> repository;
        public DateTime FechaNacimiento { get; set; }
        public string? Direccion { get; set; }
        public Clientes(IRepository<Clientes> repo)
        {
            repository = repo;
        }
        public Clientes()
        {

        }
        public Clientes(IRepository<Clientes> repository,string nombre, string apellido, DateTime fechaNacimiento, string? direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            this.repository = repository;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return $"{Id}, {Nombre}, {Apellido},{FechaNacimiento},{Direccion}";
        }
        public void AgregarCliente(Clientes cliente)
        {
            //Todo: Validar datos de entrada
            if (String.IsNullOrEmpty(cliente.Nombre) || String.IsNullOrEmpty(cliente.Apellido))
            {
                throw new ArgumentException("Las propiedades deben tener un valor. " +
                    "La propiedadad Nombre, Apellidos o Direccion estan vacias");
            }
            //Buscar si existe el cliente en la base de datos
            var result = repository.Consultar().Where(x =>
                            x.Nombre.ToUpper().Equals(cliente.Nombre.ToUpper()) &&
                            x.Apellido.ToUpper().Equals(cliente.Apellido.ToUpper())
                         ).ToList();
            if (result.Count != 0)
            {
                throw new ArgumentException("El cliente ya existe");
            }
            repository.Agregar(cliente);
        }
        public List<Clientes> Cargar_Clientes()
        {
            return repository.Consultar();
        }
        public void Guardar(List<Clientes> clientes)
        {
            repository.Guardar(clientes);
        }

        //private readonly string path = "C:\\Users\\martin.ponce\\Documents\\prueba\\clientes.csv";
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        //public string Edad { get; set; }
        //public string Direccion { get; set; }
        //public Clientes()
        //{
        //}
        //public Clientes(string nombre, string apellido, string edad, string direccion)
        //{
        //    Nombre = nombre;
        //    Apellido = apellido;
        //    Edad = edad;
        //    Direccion = direccion;
        //}
        //public override string ToString()
        //{
        //    return $"{Nombre},{Apellido},{Edad},{Direccion}";
        //}
        public void Agregar_Cliente()
        {

            Clientes cliente = new Clientes()
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = Nombre,
                Apellido = Apellido,
                FechaNacimiento = FechaNacimiento,
                Direccion = Direccion
            };

            Agregar_Cliente(cliente);

        }
        public void Agregar_Cliente(Clientes cliente)
        {
            this.repository.Agregar(cliente);
            //if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido))
            //{
            //    throw new ArgumentException("Los valores no deben estar vacios");
            //}
            //using (StreamWriter strWriter = new StreamWriter(path, true))
            //{

            //    strWriter.WriteLine(cliente.ToString());
            //    strWriter.Close();
            //}
        }
        //public List<Clientes> Cargar_Clientes()
        //{
        //    List<Clientes> ListaClientes = new();

        //    if (File.Exists(path))
        //    {
        //        /*Leer archivo*/
        //        using (StreamReader strReader = new StreamReader(path))
        //        {
        //            string ln = string.Empty;

        //            while ((ln = strReader.ReadLine()) != null)
        //            {
        //                string[] campos = ln.Split(",");

        //                Clientes cliente = new()
        //                {
        //                    Nombre = campos[0],
        //                    Apellido = campos[1],
        //                    Edad = campos[2],
        //                    Direccion = campos[3]
        //                };
        //                ListaClientes.Add(cliente);
        //            }
        //        }
        //    }
        //    return ListaClientes;
        //}
        //public void GuardarListaClientes(List<Clientes> ListaClientes)
        //{
        //    foreach (Clientes cliente in ListaClientes)
        //    {
        //        using (StreamWriter strWriter = new StreamWriter(path, true))
        //        {
        //            strWriter.WriteLine(cliente.ToString());
        //            strWriter.Close();
        //        }

        //    }
        //}
    }
}
