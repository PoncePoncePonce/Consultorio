using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Business.Entidades;
using Tarea.Business.Interfaces;

namespace Tarea.Infraestructura.InMemory
{
    public class DoctorMemoryRepository : IRepository<Doctores>
    {
        /*** Persistencia en Memoria ***/
        private List<Doctores> Doctores = new List<Doctores>();
        /********************************/
        public void Agregar(Doctores entity)
        {
            Doctores.Add(entity);
        }
        public List<Doctores> Consultar()
        {
            return Doctores;
        }
        public Doctores ConsultarPorId(string id)
        {
            return Doctores.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
        public void Guardar(List<Doctores> entidades)
        {
            Doctores = entidades;
        }
    }
}
