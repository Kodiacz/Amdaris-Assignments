namespace PetCare.Api.Dtos.OwnerDtos
{
    public class GetOwnerDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Age { get; set; }

        public string Phonenumber { get; set; } = null!;
    }
}
