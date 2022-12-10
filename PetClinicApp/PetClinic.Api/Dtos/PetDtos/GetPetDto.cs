namespace PetClinic.Api.Dtos.PetDtos
{
    public class GetPetDto
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int OwnerId { get; set; }

        public string OwnerFullName { get; set; }

        public string Breed { get; set; }

        public string Type { get; set; }
    }
}
