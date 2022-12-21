namespace PetCare.Application.Owners.Commands.Create
{
    public class CreateOwner : IRequest<Owner>
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Age { get; set; }

        public string Phonenumber { get; set; } = null!;
    }
}
