using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Business.Interfaces;

namespace Tarea.Business.Entidades
{
    public abstract class Persona : IEntity
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
