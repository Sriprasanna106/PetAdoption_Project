namespace PetAdoption_Project.Domain
{
    public class Branch : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int OrganizationId { get; set; }

    }
}
