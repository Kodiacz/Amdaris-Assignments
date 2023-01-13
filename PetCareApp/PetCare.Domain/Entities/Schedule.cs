namespace PetCare.Domain.Entities
{
    public class Schedule
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public bool IsAvailable { get; set; } = true;

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;
    }
}
