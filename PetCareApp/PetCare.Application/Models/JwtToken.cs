namespace PetCare.Api.Models
{
    public class JwtToken
    {
        public int UserId { get; set; } 

        public string AccessToken { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string? ProfileImageFilePath { get; set; }
    }
}
