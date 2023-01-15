namespace PetCare.Application.Authentication.Commands
{
    public class CreatePasswordHash : IRequest<ComputedPassword>
    {
        public string Password { get; set; } = null!;
    }
}
