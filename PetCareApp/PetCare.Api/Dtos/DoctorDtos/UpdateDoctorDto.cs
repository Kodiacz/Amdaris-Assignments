namespace PetCare.Api.Dtos.DoctorDtos
{
    public class UpdateDoctorDto
    {
        [StringLength(FirstNameMaxLengthForDoctor, MinimumLength = FirstNameMinLengthForDoctor)]

        public string FirstName { get; set; } = null!;

        [StringLength(LastNameMaxLengthForDoctor, MinimumLength = LastNameMinLengthForDoctor)]
        public string LastName { get; set; } = null!;

        public int Age { get; set; }

        [Phone]
        [StringLength(PhonenumberMaxLengthForDoctor)]
        public string Phonenumber { get; set; } = null!;

        [StringLength(JobDescriptionMaxLengthForDoctor, MinimumLength = JobDescriptionMinLengthForDoctor)]
        public string JobDescription { get; set; } = null!;

        [DataType(DataType.Date)]
        public DateTime StartedJobDate { get; set; }
    }
}
