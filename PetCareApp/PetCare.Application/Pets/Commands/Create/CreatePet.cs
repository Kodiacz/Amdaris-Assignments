namespace PetCare.Application.Pets.Commands.Create
{
    public class CreatePet : IRequest<Pet>
    {
        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public int OwnerId { get; set; }

        public string Breed { get; set; } = null!;

        public string Type { get; set; } = null!;

        public string? ImageFilePath { get; set; }

        public bool? IsVaccinated { get; set; }

        public DateTime? NextVaccination { get; set; }
    }
}
