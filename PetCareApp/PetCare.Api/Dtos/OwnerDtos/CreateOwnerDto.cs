namespace PetCare.Api.Dtos.OwnerDtos
{
    public class CreateOwnerDto
    {
        [StringLength(UserNameMaxLenghtForOwner, MinimumLength = UserNameMinLenghtForOwner)]
        public string Username { get; set; } = null!;

        [StringLength(PasswordMaxLenghtForOwner, MinimumLength = PasswordMinLenghtForOwner)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        
        [StringLength(PasswordMaxLenghtForOwner, MinimumLength = PasswordMinLenghtForOwner)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;

        [StringLength(EmailMaxLenghtForOwner, MinimumLength = EmailMinLenghtForOwner)]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [StringLength(FirstNameMaxLengthForDoctor, MinimumLength = FirstNameMinLengthForDoctor)]
        public string FirstName { get; init; } = null!;

        [StringLength(LastNameMaxLengthForDoctor, MinimumLength = LastNameMinLengthForDoctor)]
        public string LastName { get; init; } = null!;

        [StringLength(PhonenumberMaxLengthForDoctor)]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phonenumber { get; init; } = null!;
    }
}

//[StringLength(UserNameMaxLenghtForOwner, MinimumLength = UserNameMinLenghtForOwner)]
//public string Username { get; set; } = null!;

//[StringLength(EmailMaxLenghtForOwner, MinimumLength = EmailMinLenghtForOwner)]
//public string Email { get; set; } = null!;

//[Required]
//[StringLength(FirstNameMaxLengthForOwner, MinimumLength = FirstNameMinLengthForOwner)]
//public string FirstName { get; set; } = null!;

//[Required]
//[StringLength(LastNameMaxLengthForOwner, MinimumLength = LastNameMinLengthForOwner)]
//public string LastName { get; set; } = null!;

//[Phone]
//[Required]
//[StringLength(PhonenumberMaxLengthForOwner)]
//public string Phonenumber { get; set; } = null!;
