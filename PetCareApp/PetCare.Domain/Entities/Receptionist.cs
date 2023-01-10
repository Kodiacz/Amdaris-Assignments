namespace PetCare.Domain.Entities
{
    using System.Collections.Generic;

    public class Receptionist : Employee
    {
        public Receptionist()
        {
            this.Patients = new HashSet<Pet>();
            this.OwnersOfPatients = new HashSet<Owner>();
        }

        public bool IsDeleted { get; set; } = false;

        public string? ImageFilePath { get; set; }

        public ICollection<Pet> Patients { get; set; }

        public ICollection<Owner> OwnersOfPatients { get; set; }
    }
}
