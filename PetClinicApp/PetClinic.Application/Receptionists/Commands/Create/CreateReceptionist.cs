namespace PetClinic.Application.Receptionists.Commands.Create
{
    public class CreateReceptionist : IRequest<Receptionist>
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }

        public int Age { get; init; }

        public string Phonenumber { get; init; }

        public string JobDescription { get; set; }

        public DateTime StartedJobDate { get; set; }
    }
}
