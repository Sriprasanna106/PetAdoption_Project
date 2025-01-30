﻿namespace PetAdoption_Project.Domain
{
    public class Donation : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int Amount { get; set; }
        public int CustomerId { get; set; }
        
    }
}
