namespace PetClinic.Application.Doctors.Queries.Get
{
    using MediatR;

    using PetClinic.Domain.Entities;

    public class GetAllDoctors : IRequest<List<Doctor>>
    {
    }
}
