using PenaltyCalculation.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltyCalculation.Entities
{
    public class PenaltyDbContext : DbContext

    {
        public PenaltyDbContext() : base("name=myConnectionString")
        
        {
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<CountrySettings> CountrySettings { get; set; }
        public DbSet<Holidays> Holidays { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}