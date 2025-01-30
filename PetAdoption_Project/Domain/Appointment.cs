namespace PetAdoption_Project.Domain
{
    public class Appointment : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int PetId { get; set; }
        public int CustomerId { get; set; }

    }
}
