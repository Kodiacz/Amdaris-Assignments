namespace PetCare.Api.Dtos.OwnerDtos
{
    public class UpdateOwnerDto
    {
        [Required]
        [StringLength(FirstNameMaxLengthForOwner, MinimumLength = FirstNameMinLengthForOwner)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLengthForOwner, MinimumLength = LastNameMinLengthForOwner)]
        public string LastName { get; set; } = null!;

        public string Username { get; set; } = null!;

        public int? Age { get; set; }

        [Phone]
        [Required]
        [StringLength(PhonenumberMaxLengthForOwner)]
        public string Phonenumber { get; set; } = null!;

        public byte[]? PasswordHash { get; set; }

        public byte[]? PasswordSalt { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(EmailMaxLenghtForOwner, MinimumLength = EmailMinLenghtForOwner)]
        public string Email { get; set; } = null!;

        public string? ProfilePictureFilePath { get; set; } = null!;
    }
}
