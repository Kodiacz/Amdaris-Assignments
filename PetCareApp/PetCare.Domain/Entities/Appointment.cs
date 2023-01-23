namespace PetCare.Domain.Entities
{
    public class Appointment
    {
        public int Id { get; set; }

        public DateTime DateOfAppointment { get; set; }

        public string ReasonForAppointment { get; set; } = null!;

        public string PetName { get; set; } = null!;

        public string DoctorFullName { get; set; } = null!;

        public int OwnerId { get; set; }
        public Owner Owner { get; set; } = null!;
    }
}
