namespace PetCare.Application.Authentication.Commands
{
    public class ComparePasswordsHandler : IRequestHandler<ComparePasswords, bool>
    {
        public async Task<bool> Handle(ComparePasswords request, CancellationToken cancellationToken)
        {
            return request.Password.SequenceEqual(request.ConfirmPassword);
        }
    }
}
