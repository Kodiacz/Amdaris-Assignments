﻿namespace PetCare.Api.Dtos.DoctorDtos
{
    public class GetDoctorDto
    {
        public int Id { get; set; }

        public string FirstName { get; init; } = null!;

        public string LastName { get; init; } = null!;

        public int Age { get; init; }

        public string ImageFilePath { get; set; } = null!;

        public string Phonenumber { get; init; } = null!;

        public string JobDescription { get; set; } = null!;

        public DateTime StartedJobDate { get; set; }
    }
}
