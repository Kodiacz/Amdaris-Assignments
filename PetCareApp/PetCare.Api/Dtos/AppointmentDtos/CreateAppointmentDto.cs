namespace PetCare.Api.Dtos.AppointmentDtos
{
    public class CreateAppointmentDto
    {
        public DateTime DateOfAppointment { get; set; }

        public string ReasonForAppointment { get; set; } = null!;

        public int OwnerId { get; set; }
    }
}
