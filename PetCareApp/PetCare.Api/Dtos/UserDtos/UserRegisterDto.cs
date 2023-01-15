namespace PetCare.Api.Dtos.UserDtos
{
    public class UserRegisterDto 
    {
        [StringLength(UserNameMaxLenghtForOwner, MinimumLength = UserNameMinLenghtForOwner)]
        public string Username { get; set; } = null!;

        [StringLength(PasswordMaxLenghtForOwner, MinimumLength = PasswordMinLenghtForOwner)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

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
