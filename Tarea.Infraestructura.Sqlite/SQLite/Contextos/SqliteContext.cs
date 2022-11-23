using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Business.Entidades;

namespace Tarea.Infraestructura.SQL.SQLite.Contextos
{
    public class SqliteContext: DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Doctores> Doctores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Data Source = C:\\Users\\martin.ponce\\Documents\\prueba\\consultorio.bd");
        }
    }
}
