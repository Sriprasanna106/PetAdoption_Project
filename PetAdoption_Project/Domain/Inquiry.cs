namespace PetAdoption_Project.Domain
{
    public class Inquiry : BaseDomainModel
    {
        public string? Question { get; set; }
        public bool IsAnswered { get; set; } = false;
        public string? Response { get; set; }
        public DateTime? ResponseDate { get; set; }
    }
}
