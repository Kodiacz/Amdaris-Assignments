namespace PetCare.Application.Owners.Commands.PartialUpdate
{
    public class PartialUpdateOwner : IRequest<Owner>
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Username { get; set; } = null!;

        public byte[]? PasswordHash { get; set; }

        public byte[]? PasswordSalt { get; set; }

        public string Email { get; set; } = null!;

        public string Phonenumber { get; set; } = null!;

        public string? ProfileImageFilePath { get; set; }
    }
}
