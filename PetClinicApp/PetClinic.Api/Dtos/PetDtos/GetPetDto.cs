namespace PetClinic.Api.Dtos.PetDtos
{
    public class GetPetDto
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Owner Owner { get; set; }

        public string Breed { get; set; }

        public string Type { get; set; }
    }
}
