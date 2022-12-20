﻿namespace PetCare.Domain.Entities
{
    using PetCare.Domain.AbstracClasses;

    public class Employee : Person
    {
        
        public int Id { get; set; }

        public string JobDescription { get; set; }

        public DateTime StartedJobDate { get; set; }
    }
}
