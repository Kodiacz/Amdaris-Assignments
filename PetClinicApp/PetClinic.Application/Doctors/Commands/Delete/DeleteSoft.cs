namespace PetClinic.Application.Doctors.Commands.Delete
{
    using MediatR;

    using PetClinic.Domain.Entities;

    public class DeleteSoft : IRequest<Doctor>
    {
        public int Id { get; set; }
    }
}
