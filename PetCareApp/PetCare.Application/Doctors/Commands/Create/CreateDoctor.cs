namespace PetCare.Application.Doctors.Commands.Create
{
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
