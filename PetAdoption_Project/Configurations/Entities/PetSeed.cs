using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetAdoption_Project.Domain;

namespace PetAdoption_Project.Configurations.Entities
{
    public class PetSeed : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasData(
            new Pet
            {
                Id = 1,
                Name = "Kohaku",
                Age = 5,
                Breed = "Dog",
                Colour = "White",
                Gender = "Unspecified",
                OrganizationId = 1
            },
			new Pet
            {
                Id = 2,
                Name = "Bean",
                Age = 1,
                Breed = "Monitor Lizard",
                Colour = "Brown",
                Gender = "Male"
                // this pet doesn't have an organization ID
            }
			);
        }
    }
}
