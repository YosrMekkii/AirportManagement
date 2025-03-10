using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace AM.Infrastructure
{
    internal class Context : DbContext
    {

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(this.GetJsonConnectionString("appsettings.json"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("DateTime");
            base.ConfigureConventions(configurationBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passenger>().Property(e => e.TelNumber).HasColumnName("NumTel");
            base.OnModelCreating(modelBuilder);

            // Configure FullName as an owned entity for Passenger
            modelBuilder.Entity<Passenger>()
                .OwnsOne(p => p.FullName, fn =>
                {
                    fn.Property(f => f.FirstName).HasColumnName("FullNameFirst");
                    fn.Property(f => f.LastName).HasColumnName("FullNameLast");
                });
        }

        







        }
}
