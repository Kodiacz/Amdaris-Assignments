namespace PetCare.Application.Authentication.Commands
{
    public class GenerateToken : IRequest<JwtToken>
    {
        public Owner Owner { get; set; } = null!;

        public string Role { get; set; } = null!;
    }
}
