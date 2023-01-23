namespace PetCare.Application.Appointments.Commands.Create
{
    public class CreateAppointmen : IRequest<Appointment>
    {
        public DateTime DateOfAppointment { get; set; }

        public string ReasonForAppointment { get; set; } = null!;

        public string PetName { get; set; } = null;

        public string DoctorFullName { get; set; } = null;

        public int OwnerId { get; set; }
    }
}
