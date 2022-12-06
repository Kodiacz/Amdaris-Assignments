namespace PetClinic.Api.Dtos.DoctorDtos
{
    using PetClinic.Domain.Entities;

    public class GetDoctorDto
    {
        public int Id { get; set; }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public int Age { get; init; }

        public string Phonenumber { get; init; }

        public bool IsAvailable { get; set; }

        public bool IsDeleted { get; set; } = false;

        public ICollection<Pet> Patients { get; set; }

        public ICollection<Owner> OwnersOfPatients { get; set; }
    }
}
