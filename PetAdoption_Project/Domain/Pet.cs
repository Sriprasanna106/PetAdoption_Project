namespace PetAdoption_Project.Domain
{
    public class Pet : BaseDomainModel
    {
        public string? Name { get; set; }

        public int Age { get; set; }
        public string? Breed { get; set; }
        public string? Colour { get; set; }
        public string? Gender { get; set; }
        public int OrganizationId { get; set; }
        public bool IsAdopted { get; set; }
    }
}
