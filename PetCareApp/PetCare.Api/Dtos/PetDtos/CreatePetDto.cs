namespace PetCare.Api.Dtos.PetDtos
{
    public class CreatePetDto
    {
        [Required]
        [StringLength(NameMaxLengthForPet, MinimumLength = NameMinLengthForPet)]
        public string Name { get; set; } = null!;

        [Required]
        [Range(1, int.MaxValue)]
        public int Age { get; set; }

        [Required]
        public int OwnerId { get; set; }

        [Required]
        [StringLength(BreedMaxLengthForPet, MinimumLength = BreedMinLengthForPet)]
        public string Breed { get; set; } = null!;

        [Required]
        [StringLength(TypeMaxLengthForPet, MinimumLength = TypeMinLengthForPet)]
        public string Type { get; set; } = null!;

        public string? ImageFilePath { get; set; }

        public bool? IsVaccinated { get; set; }

        [DataType(DataType.Date)]
        public DateTime? NextVaccination { get; set; }
    }
}
