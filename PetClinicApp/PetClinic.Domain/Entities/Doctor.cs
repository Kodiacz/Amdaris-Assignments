namespace PetClinic.Domain.Entities
{
    public class Doctor : Employee
    {
        public Doctor()
        {
            this.Patients = new HashSet<Pet>();
            this.OwnersOfPatients = new HashSet<Owner>();
        }

        public bool IsAvailable { get; set; } = true;
        
        public bool IsDeleted { get; set; } = false;

        public ICollection<Pet> Patients { get; set; }

        public ICollection<Owner> OwnersOfPatients { get; set; }
    }
}
