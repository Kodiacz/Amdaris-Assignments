namespace PetCare.Application.Authentication.Commands
{
    public class GenerateTokenHandler : IRequestHandler<GenerateToken, string>
    {
        private readonly IConfiguration configuration;

        public GenerateTokenHandler(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<string> Handle(GenerateToken request, CancellationToken cancellationToken)
        {
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.NameIdentifier, Convert.ToString(request.Owner.Id!)),
                new Claim(ClaimTypes.Name, request.Owner.Username!),
                new Claim(ClaimTypes.Email, request.Owner.Email!),
                new Claim(ClaimTypes.GivenName, request.Owner.FirstName!),
                new Claim(ClaimTypes.Surname, request.Owner.LastName!),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                this.configuration.GetSection("JwtSettings:Secret").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: cred);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
