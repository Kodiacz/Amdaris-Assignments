namespace PetCare.Application.Authentication.Commands
{
    public class VerifyPasswordHash : IRequest<bool>
    {
        public string Password { get; set; } = null!;

        public byte[] PasswordHash { get; set; } = null!;

        public byte[] PasswordSalt { get; set; } = null!;
    }
}
