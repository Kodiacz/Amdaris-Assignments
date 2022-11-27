namespace PetClinic.Application.Owners.Commands
{
    using MediatR;
    using PetClinic.Domain.Entities;

    public class CreateOwnerCommand : IRequest<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Phonenumber { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
