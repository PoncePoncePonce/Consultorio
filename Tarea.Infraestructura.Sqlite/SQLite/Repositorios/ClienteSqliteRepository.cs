using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Business.Entidades;

namespace Tarea.Infraestructura.SQL.SQLite.Repositorios
{
    public class ClienteSqliteRepository : Repository<Clientes>
    {
        public ClienteSqliteRepository(DbContext context) : base(context)
        {
        }
    }
}
