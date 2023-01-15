using System.Security.Cryptography;

namespace PetCare.Application.Authentication.Commands
{
    /// <summary>
    /// returns an object that holds the computed Password and Salt
    /// </summary>
    public class CreatePasswordHashHandler : IRequestHandler<CreatePasswordHash, ComputedPassword>
    {
        public async Task<ComputedPassword> Handle(CreatePasswordHash request, CancellationToken cancellationToken)
        {
            ComputedPassword result = new();

            using (var hmac = new HMACSHA512())
            {
                result.PasswordSalt = (hmac.Key);
                result.PasswordHash = (hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(request.Password)));
            }

            return result;
        }
    }
}
