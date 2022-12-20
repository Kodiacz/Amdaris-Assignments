namespace PetCare.Api.Dtos.OwnerDtos
{
    public class CreateOwnerDto
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
    }
}
