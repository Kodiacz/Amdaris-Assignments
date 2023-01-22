namespace PetCare.Application.Doctors.Queries.Get
{
    public class GetScheduelForDoctorWithIdAsReadOnly : IRequest<Schedule>
    {
        public int scheduleId { get; set; }
    }
}
