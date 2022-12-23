namespace PetCare.Application.Receptionists.Commands.PartialUpdate
{
    public class PartialUpdateReceptionist : IRequest<Receptionist>
    {
        public int Id { get; set; }

        public string FirstName { get; init; } = null!;

        public string LastName { get; init; } = null!;

        public int Age { get; init; }

        public string Phonenumber { get; init; } = null!;

        public string JobDescription { get; set; } = null!;

        public DateTime StartedJobDate { get; set; }
    }
}
