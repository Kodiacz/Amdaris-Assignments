namespace PetCare.Domain.Entities
{
    using PetCare.Domain.AbstracClasses;

    public class Pet : Animal
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public string? ImageFilePath { get; set; }

        public bool? IsVaccinated { get; set; } = false;

        public DateTime? NextVaccination { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; } = null!;

        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        public int? ReceptionistId { get; set; }
        public Receptionist? Receptionist { get; set; }
    }
}
