namespace PetCare.Application.Doctors.Queries.Get
{
    public class GetScheduelForDoctorWithId : IRequest<List<Schedule>>
    {
        public int DoctorId { get; set; }
    }
}
