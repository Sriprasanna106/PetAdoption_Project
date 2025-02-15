﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetAdoption_Project.Configurations.Entities;
using PetAdoption_Project.Data;

namespace PetAdoption_Project.Data
{
    public class PetAdoption_ProjectContext(DbContextOptions<PetAdoption_ProjectContext> options) : IdentityDbContext<PetAdoption_ProjectUser>(options)
    {
        public DbSet<PetAdoption_Project.Domain.Appointment> Appointment { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Branch> Branch { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Donation> Donation { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Pet> Pet { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Inquiry> Inquiry { get; set; } = default!;
        public DbSet<PetAdoption_Project.Domain.Testimonials> Testimonials { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new BranchSeed());
            builder.ApplyConfiguration(new PetSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }

    }
}
