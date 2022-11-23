using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Business.Entidades;

namespace Tarea.Infraestructura.SQL.SQL_Server.Contextos
{
    public class SQLContext: DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Doctores> Doctores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server = LAP-MARTINP\\SQLEXPRESS;  Database = Consultorio; Trusted_Connection = true");
        }
    }
}
