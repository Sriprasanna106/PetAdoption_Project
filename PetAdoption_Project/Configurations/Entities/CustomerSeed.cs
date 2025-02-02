using Microsoft.AspNetCore.Http.HttpResults;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetAdoption_Project.Domain;


namespace PetAdoption_Project.Configurations.Entities
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
           new Customer
           {
               Id = 1,
               Name = "JohnPork",
               Email = "NumberOneCrate@gmail.com",
               Address = "Lenovo Street 45",
               ContactNumber = "94656485",
               CreatedBy = "System",
               UpdatedBy = "System"
           },
           new Customer
           {
                Id = 2,
                Name = "Xodus",
                Email = "NumberTwoPhone@gmail.com",
                Address = "HP Street 216",
                ContactNumber = "86364294",
                CreatedBy = "System",
                UpdatedBy = "System"
           }
           );
        }
    }
}
