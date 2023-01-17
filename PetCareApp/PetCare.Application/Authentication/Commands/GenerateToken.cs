namespace PetCare.Application.Authentication.Commands
{
    public class GenerateToken : IRequest<JwtToken>
    {
        public Owner Owner { get; set; }
    }
}
