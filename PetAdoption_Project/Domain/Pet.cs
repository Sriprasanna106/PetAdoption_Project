namespace PetAdoption_Project.Domain
{
    public class Pet : BaseDomainModel
    {
        public string? Name { get; set; }
        public int AgeId { get; set; }
        public int BreedId { get; set; }
        public int ColourId { get; set; }
    }
}
