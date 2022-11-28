using MediatR;

namespace PetClinic.Doctors.Commands.CreateDoctor
{
    public class CreateDoctorCommand : IRequest<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Phonenumber { get; set; }

        public string JobDescription { get; set; }

        public DateTime StartedJobDate { get; set; }

        public bool IsAvailable { get; set; }
    }
}
