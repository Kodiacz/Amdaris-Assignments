namespace PetClinic.Application.Owners.Commands.Update
{
    public class UpdateOwner : IRequest<Owner>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Phonenumber { get; set; }
    }
}
