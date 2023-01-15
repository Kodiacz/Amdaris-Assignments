namespace PetCare.Application.Models
{
    public class ComputedPassword
    {
        public byte[] PasswordHash { get; set; } = null!; 

        public byte[] PasswordSalt { get; set; } = null!;
    }
}
