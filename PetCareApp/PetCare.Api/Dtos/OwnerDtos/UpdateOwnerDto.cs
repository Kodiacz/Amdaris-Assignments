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

        [Required]
        [Range(AgeMinLengthForOwner, int.MaxValue)]
        public int Age { get; set; }

        [Phone]
        [Required]
        [StringLength(PhonenumberMaxLengthForOwner)]
        public string Phonenumber { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [StringLength(PasswordMaxLenghtForOwner, MinimumLength = PasswordMinLenghtForOwner)]
        public string Password { get; set; } = null!;

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(EmailMaxLenghtForOwner, MinimumLength = EmailMinLenghtForOwner)]
        public string Email { get; set; } = null!;

        public string ProfilePictureFilePath { get; set; } = null!;
    }
}
