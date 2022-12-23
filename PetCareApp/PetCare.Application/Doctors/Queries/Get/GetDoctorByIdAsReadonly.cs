namespace PetCare.Application.Doctors.Queries.Get
{
    public class GetDoctorByIdAsReadonly : IRequest<Doctor>
    {
        public int Id { get; set; }
    }
}
