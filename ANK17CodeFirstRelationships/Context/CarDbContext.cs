using ANK17CodeFirstRelationships.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK17CodeFirstRelationships.Context
{
    public class CarDbContext : DbContext
    {

        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<CarEngineer> CarEngineers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<LicensePlate> LicensePlates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   => optionsBuilder.UseSqlServer("server=DESKTOP-3Q2QRV6\\MSSQLSERVER01;database=ANK17CodeFirstRelationships;uid=sa;pwd=123;trustservercertificate=true");
    }

}

