﻿namespace PetClinic.Domain.Entities
{
    public class Doctor : Employee
    {
        public int Id { get; set; }

        public bool IsAvailable { get; set; }
    }
}
