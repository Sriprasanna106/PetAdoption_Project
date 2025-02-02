using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetAdoption_Project.Domain;

namespace PetAdoption_Project.Configurations.Entities
{
    public class BranchSeed : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasData(
           new Branch
           {
               Id = 1,
               Name = "Tampines",
               Address = "Street 54, Ave 5, 120987",
               OrganizationId = 2,
               CreatedBy = "System",
               UpdatedBy = "System"
           }
           );
        }
    }
}
