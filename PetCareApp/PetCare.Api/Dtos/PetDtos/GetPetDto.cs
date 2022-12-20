namespace PetCare.Api.Dtos.PetDtos
{
    public class GetPetDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public int OwnerId { get; set; }

        public string OwnerFullName { get; set; } = null!;

        public string Breed { get; set; } = null!;

        public string Type { get; set; } = null!;
    }
}
