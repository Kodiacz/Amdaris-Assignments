namespace PetCare.Api.Dtos.RecceptionistDtos
{
    public class CreateReceptionistDto
    {
        [Required]
        [StringLength(FirstNameMaxLengthForReceptionist, MinimumLength = FirstNameMinLengthForReceptionist)]
        public string FirstName { get; init; } = null!;

        [Required]
        [StringLength(LastNameMaxLengthForReceptionist, MinimumLength = LastNameMinLengthForReceptionist)]
        public string LastName { get; init; } = null!;

        [Required]
        [Range(AgeMinLengthForReceptionist, int.MaxValue)]
        public int Age { get; init; }

        [Required]
        [StringLength(PhonenumberMaxLengthForReceptionist)]
        public string Phonenumber { get; init; } = null!;

        [Required]
        [StringLength(JobDescriptionMaxLengthForReceptionist)]
        public string JobDescription { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartedJobDate { get; set; }
    }
}
