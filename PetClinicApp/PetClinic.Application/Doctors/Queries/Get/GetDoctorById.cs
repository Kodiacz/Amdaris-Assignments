namespace PetClinic.Application.Doctors.Queries.Get
{
    using MediatR;

    using PetClinic.Domain.Entities;

    public class GetDoctorById : IRequest<Doctor>
    {
        public int Id { get; set; }
    }
}
