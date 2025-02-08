using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetAdoption_Project.Domain;

namespace PetAdoption_Project.Configurations.Entities
{
    public class OrganizationSeed : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasData(
           new Organization
           {
               Id = 1,
               Name = "HYV Animal Centre",
               Address = "977 Grove Street",
               DateUpdated = DateTime.Now,
               CreatedBy = "System",
               UpdatedBy = "System"
           }
           );
        }
    }
}
