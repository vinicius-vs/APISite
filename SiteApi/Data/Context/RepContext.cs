using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class RepContext: DbContext
    {

        public DbSet<TrasporteModel> Trapoertes { get; set; }

        public RepContext() : base("Data Source=192.168.0.157;Initial Catalog=Time7;Persist Security Info=True;User ID=time7;Password=123321@")
        {

        }
    }
}
