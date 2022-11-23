using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea.Business.Entidades;
using Tarea.Infraestructura.SQL.SQL_Server.Contextos;

namespace Tarea.Infraestructura.SQL.SQL_Server.Repositorios
{
    public class ClientesSQLRepository: Repository<Clientes>
    {
        public ClientesSQLRepository(SQLContext context):base(context)
        {

        }
    }
}
