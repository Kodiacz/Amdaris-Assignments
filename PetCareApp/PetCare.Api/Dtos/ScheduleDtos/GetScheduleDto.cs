namespace PetCare.Api.Dtos.ScheduleDtos
{
    public class GetScheduleDto
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public bool IsAvailable { get; set; } = true;

        public int DoctorId { get; set; }

        public string FullName { get; set; } = null!;
    }
}
