﻿namespace PetCare.Api.Dtos.PetDtos
{
    public class GetPetDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public int OwnerId { get; set; }

        public string OwnerFullName { get; set; } = null!;

        public string Breed { get; set; } = null!;

        public string Type { get; set; } = null!;

        public string ImageFilePath { get; set; } = null!;

        public bool IsVaccinated { get; set; }

        public DateTime NextVaccination { get; set; }
    }
}
