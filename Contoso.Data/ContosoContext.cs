using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data
{
    public class ContosoContext : DbContext
    {
        public ContosoContext() : base("name = ContosoConnection")
        {

        }

        public DbSet<People> People { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
