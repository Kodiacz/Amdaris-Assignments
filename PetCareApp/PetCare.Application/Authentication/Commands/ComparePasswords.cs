namespace PetCare.Application.Authentication.Commands
{
    public class ComparePasswords : IRequest<bool>
    {
        public string Password { get; set; } = null!;

        public string ConfirmPassword { get; set; } = null!;

    }
}
