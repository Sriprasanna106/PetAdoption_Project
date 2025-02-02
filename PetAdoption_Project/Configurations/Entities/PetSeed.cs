using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetAdoption_Project.Domain;

namespace PetAdoption_Project.Configurations.Entities
{
    public class PetSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
            new Pet
            {
                Id = 1,
                Name = "Kohaku",
                Age = 5,
                Breed = "Dog",
                Colour = "White",
                Gender = "Unspecified"
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
