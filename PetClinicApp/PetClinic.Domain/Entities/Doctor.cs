﻿namespace PetClinic.Domain.Entities
{
    public class Doctor : Employee
    {
        public Doctor()
        {
            this.Patients = new HashSet<Pet>();
            this.OwnersOfPatients = new HashSet<Owner>();
        }

        public int Id { get; set; }

        public bool IsAvailable { get; set; }

        public ICollection<Pet> Patients { get; set; }

        public ICollection<Owner> OwnersOfPatients { get; set; }
    }
}
