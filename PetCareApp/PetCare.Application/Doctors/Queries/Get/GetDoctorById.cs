namespace PetCare.Application.Doctors.Queries.Get
{
    public class GetDoctorById : IRequest<Doctor>
    {
        public int Id { get; set; }
    }
}
