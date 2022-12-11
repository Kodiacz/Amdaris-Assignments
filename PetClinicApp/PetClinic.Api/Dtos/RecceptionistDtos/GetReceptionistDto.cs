﻿namespace PetClinic.Api.Dtos.RecceptionistDtos
{
    public class GetReceptionistDto
    {
        public string FirstName { get; init; } = null!;

        public string LastName { get; init; } = null!;

        public int Age { get; init; }

        public string Phonenumber { get; init; } = null!;

        public string JobDescription { get; set; } = null!;

        public DateTime StartedJobDate { get; set; }
    }
}
