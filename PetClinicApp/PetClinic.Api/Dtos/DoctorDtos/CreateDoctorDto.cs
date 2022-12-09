namespace PetClinic.Api.Dtos.DoctorDtos
{
    public class CreateDoctorDto
    {
        [Required]
        [StringLength(FirstNameMaxLengthForDoctor, MinimumLength = FirstNameMinLengthForDoctor)]

        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(LastNameMaxLengthForDoctor, MinimumLength = LastNameMinLengthForDoctor)]
        public string LastName { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [Phone]
        [Required]
        [StringLength(PhonenumberMaxLengthForDoctor)]
        public string Phonenumber { get; set; } = null!;

        [Required]
        [StringLength(JobDescriptionMaxLengthForDoctor, MinimumLength = JobDescriptionMinLengthForDoctor)]
        public string JobDescription { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartedJobDate { get; set; }
    }
}
