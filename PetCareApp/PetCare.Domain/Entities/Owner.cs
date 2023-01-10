namespace PetCare.Domain.Entities
{
    using PetCare.Domain.AbstracClasses;

    public class Owner : Person
    {
        public Owner()
        {
            this.Pets = new HashSet<Pet>();
        }

        public int Id { get; set; }

        public bool IsDeleted { get; set; } = false;

        public string? ProfileImageFilePath { get; set; }

        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        public int? ReceptionistId { get; set; }
        public Receptionist? Receptionist { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
