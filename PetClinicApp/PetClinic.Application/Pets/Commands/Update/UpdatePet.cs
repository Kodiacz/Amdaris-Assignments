namespace PetClinic.Application.Pets.Commands.Update
{
    public class UpdatePet : IRequest<Pet>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int OwnerId { get; set; }

        public string Breed { get; set; }

        public string Type { get; set; }
    }
}
