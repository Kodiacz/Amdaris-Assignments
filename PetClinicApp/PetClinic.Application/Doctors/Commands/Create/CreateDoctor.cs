namespace PetClinic.Doctors.Commands.Create
{
    using MediatR;

    using PetClinic.Domain.Entities;

    public class CreateDoctor : IRequest<Doctor>
    {
        public string FirstName { get; set; } = null!; 

        public string LastName { get; set; } = null!;

        public int Age { get; set; } 

        public string Phonenumber { get; set; } = null!;

        public string JobDescription { get; set; } = null!;

        public DateTime StartedJobDate { get; set; }
    } 
} 
