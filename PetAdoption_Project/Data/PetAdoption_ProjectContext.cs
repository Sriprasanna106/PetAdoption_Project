using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using PetAdoption_Project.Configurations.Entities;
using PetAdoption_Project.Domain;

namespace PetAdoption_Project.Data
{
    public class PetAdoption_ProjectContext : DbContext
    {
        public PetAdoption_ProjectContext (DbContextOptions<PetAdoption_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<PetAdoption_Project.Domain.Age> Age { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Appointment> Appointment { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Branch> Branch { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Breed> Breed { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Donation> Donation { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Organization> Organization { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Pet> Pet { get; set; } = default!;
    }
}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfiguration(new AppointmentSeed());
}