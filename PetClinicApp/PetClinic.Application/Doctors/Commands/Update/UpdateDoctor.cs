namespace PetClinic.Application.Doctors.Commands.Update
{
    using MediatR;
    using PetClinic.Domain.Entities;

    public class UpdateDoctor : IRequest<Doctor>
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Age { get; set; }

        public string Phonenumber { get; set; } = null!;

        public string JobDescription { get; set; } = null!;

        public DateTime StartedJobDate { get; set; }
    }
}
