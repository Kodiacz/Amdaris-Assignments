namespace PetCare.Api.Models
{
    public class JwtToken
    {
        public string AccessToken { get; set; } = null!;

        public string Username { get; set; } = null!;

        public int UserId { get; set; } 
    }
}
