namespace PetCare.Application.Owners.Commands.Create
{
    public class CreateOwner : IRequest<Owner>
    {
        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;

        public byte[]? PasswordHash { get; set; }

        public byte[]? PasswordSalt { get; set; }

        public string FirstName { get; init; } = null!;

        public string LastName { get; init; } = null!;

        public string Phonenumber { get; init; } = null!;

        public string? ProfileImageFilePath { get; set; }
    }
}