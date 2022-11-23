using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Business.Entidades;
using Tarea.Business.Interfaces;

namespace Tarea.Infraestructura.InMemory
{
    public class ClienteMemoryRepository : IRepository<Clientes>
    {
        /*** Persistencia en Memoria ***/
        private List<Clientes> Clientes = new List<Clientes>();
        /********************************/
        public void Agregar(Clientes entity)
        {
            Clientes.Add(entity);
        }
        public List<Clientes> Consultar()
        {
            return Clientes;
        }
        public Clientes ConsultarPorId(string id)
        {
            return Clientes.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
        public void Guardar(List<Clientes> entidades)
        {
            Clientes = entidades;
        }
    }
}
