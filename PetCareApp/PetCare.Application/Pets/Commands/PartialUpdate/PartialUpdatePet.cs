namespace PetCare.Application.Pets.Commands.PartialUpdate
{
    public class PartialUpdatePet : IRequest<Pet>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public int OwnerId { get; set; }

        public string Breed { get; set; } = null!;

        public string Type { get; set; } = null!;
    }
}
