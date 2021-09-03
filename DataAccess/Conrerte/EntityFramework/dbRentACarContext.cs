using Entities.Conrerte;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Conrerte.EntityFramework
{
    public class dbRentACarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"server=localhost; port=5432; database=dbRentACar; user ID=postgres ; password=12345; ");

        }

        public DbSet<Car> tblCars { get; set; }
        public DbSet<Brand> tblBrands { get; set; }
        public DbSet<Color> tblColors { get; set; }

    }
}
