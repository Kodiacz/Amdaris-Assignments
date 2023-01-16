namespace PetCare.Application.Authentication.Commands
{
    public class VerifyPasswordHashHandler : IRequestHandler<VerifyPasswordHash, bool>
    {
        public async Task<bool> Handle(VerifyPasswordHash request, CancellationToken cancellationToken)
        {
            using (var hmac = new HMACSHA512(request.PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(request.Password));
                return computedHash.SequenceEqual(request.PasswordHash);
            }
        }
    }
}
