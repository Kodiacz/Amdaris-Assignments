namespace PetCare.Application.Owners.Commands.Create
{
    public class CreateOwner : IRequest<Owner>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Phonenumber { get; set; }
    }
}
