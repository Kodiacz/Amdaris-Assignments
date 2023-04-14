using PetCare.Domain.AbstracClasses;

namespace PetCare.Domain.Entities
{
    public class Doctor : Employee
    {
        public Doctor()
        {
            this.Patients = new HashSet<Pet>();
            this.OwnersOfPatients = new HashSet<Owner>();
            this.Schedule = new HashSet<Schedule>();
        }

        public ICollection<Schedule> Schedule { get; set; }

        public string? ImageFilePath { get; set; }

        public ICollection<Pet> Patients { get; set; }

        public ICollection<Owner> OwnersOfPatients { get; set; }
    }
}
