using PetAdoption_Project.Domain;

namespace Project.Domain
{
    public class Inquiry : BaseDomainModel
    {
        public string? Question { get; set; }
        public int CustomerId { get; set; }

    }
}
