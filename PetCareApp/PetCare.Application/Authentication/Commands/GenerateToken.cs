namespace PetCare.Application.Authentication.Commands
{
    public class GenerateToken : IRequest<string>
    {
        public Owner Owner { get; set; }
    }
}
