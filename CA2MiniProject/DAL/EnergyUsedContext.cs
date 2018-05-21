using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CA2MiniProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CA2MiniProject.DAL
{
    public class EnergyUsedContext : DbContext
    {
        public EnergyUsedContext() : base("EnergyUsedContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet <Appliance> Appliances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}