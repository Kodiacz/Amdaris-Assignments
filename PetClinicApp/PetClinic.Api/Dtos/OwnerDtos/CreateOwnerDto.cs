namespace PetClinic.Api.Dtos.OwnerDtos
{
    public class CreateOwnerDto
    {
        [Required]
        [StringLength(FirstNameMaxLengthForOwner, MinimumLength = FirstNameMinLengthForOwner)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(LastNameMaxLengthForOwner, MinimumLength = LastNameMinLengthForOwner)]
        public string LastName { get; set; }

        [Required]
        [Range(AgeMinLengthForOwner, int.MaxValue)]
        public int Age { get; set; }

        [Phone]
        [Required]
        [StringLength(PhonenumberMaxLengthForOwner)]
        public string Phonenumber { get; set; }
    }
}
