namespace PetClinic.Api.Dtos
{
    using System.ComponentModel.DataAnnotations;

    using static PetClinic.Infrastructure.Common.DatabaseConstants.DoctorConstants;

    public class CreateDoctorDto
    {
        [Required]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]

        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [Phone]
        [Required]
        [StringLength(PhonenumberMaxLength)]
        public string Phonenumber { get; set; } = null!;

        [Required]
        [StringLength(JobDescriptionMaxLength, MinimumLength = JobDescriptionMinLength)]
        public string JobDescription { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartedJobDate { get; set; }
    }
}
