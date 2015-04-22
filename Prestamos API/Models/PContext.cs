using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_API.Models
{
    public class PContext : DbContext
    {

        public PContext()
            : base("PContext")
        {
        }

        public DbSet<clientes> clientes { get; set; }
        public DbSet<prestamos> prestamos { get; set; }
        public DbSet<prestamos_cuotas> prestamos_cuotas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");


        }

    }
}
