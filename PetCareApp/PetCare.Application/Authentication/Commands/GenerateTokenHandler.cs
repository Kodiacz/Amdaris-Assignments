namespace PetCare.Application.Authentication.Commands
{
    public class GenerateTokenHandler : IRequestHandler<GenerateToken, JwtToken>
    {
        private readonly IConfiguration configuration;

        public GenerateTokenHandler(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<JwtToken> Handle(GenerateToken request, CancellationToken cancellationToken)
        {
            JwtToken jwt = new();

            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.NameIdentifier, Convert.ToString(request.Owner.Id!)),
                new Claim(ClaimTypes.Name, request.Owner.Username!),
                new Claim(ClaimTypes.Email, request.Owner.Email!),
                new Claim(ClaimTypes.GivenName, request.Owner.FirstName!),
                new Claim(ClaimTypes.Surname, request.Owner.LastName!),
                new Claim(ClaimTypes.Role, request.Role),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                this.configuration.GetSection("JwtSettings:Secret").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: cred);

            jwt.AccessToken = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
