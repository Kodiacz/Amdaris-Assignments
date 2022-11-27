namespace PetClinic.Application.Pets.Commands
{
    using PetClinic.Domain.Entities;

    public class CreatePetCommand
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsSick { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }

        public string Breed { get; set; }
    }
}
