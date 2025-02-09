namespace PetAdoption_Project.Domain
{
    public class Testimonials : BaseDomainModel
    {
        public int PetId { get; set; }
        public string? Breed { get; set; }
        public int Rating { get; set; }
        public string? Content { get; set; }
        public DateTime? DatePosted { get; set; }
    }
}