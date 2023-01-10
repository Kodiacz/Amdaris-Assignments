namespace PetCare.Infrastructure.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PetCare.Domain.Entities;

    public class PetEntityTypeConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> petConfiguration)
        {
            petConfiguration
                .HasData(CreatePets());

            petConfiguration
                .Property(pet => pet.OwnerId)
                .IsRequired();

            //petConfiguration
            //    .Property(pet => pet.Doctor)
            //    .IsRequired(false);

            //petConfiguration
            //    .Property(pet => pet.Receptionist)
            //    .IsRequired(false);

            petConfiguration
                .Property(pet => pet.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLengthForPet);

            petConfiguration
                .Property(pet => pet.Breed)
                .IsRequired()
                .HasMaxLength(NameMaxLengthForPet);

            petConfiguration
                .Property(pet => pet.Type)
                .IsRequired()
                .HasMaxLength(NameMaxLengthForPet);

            petConfiguration
                .Property(pet => pet.Age)
                .IsRequired();

            petConfiguration
                .HasOne(pet => pet.Owner)
                .WithMany(owner => owner.Pets)
                .OnDelete(DeleteBehavior.Cascade);

            //petConfiguration
            //    .HasOne(pet => pet.Doctor)
            //    .WithMany(doctor => doctor.Patients)
            //    .HasForeignKey(pet => pet.DoctorId)
            //    .OnDelete(DeleteBehavior.SetNull);

            //petConfiguration
            //    .HasOne(pet => pet.Receptionist)
            //    .WithMany(receptionist => receptionist.Patients)
            //    .HasForeignKey(pet => pet.ReceptionistId)
            //    .OnDelete(DeleteBehavior.SetNull);
        }

        /// <summary>
        /// Creates a List of pets to seed the database with Pet entities
        /// </summary>
        /// <returns>List of type Pet</returns>
        private List<Pet> CreatePets()
        {
            var pets = new List<Pet>()
            {
                new Pet
                {
                    Id = 1,
                    Name = "Bella",
                    Age = 2,
                    Breed = "Akita",
                    Type = "Dog",
                    OwnerId = 4,
                },
                new Pet
                {
                    Id = 2,
                    Name = "Milo",
                    Age = 4,
                    Breed = "Street",
                    Type = "Cat",
                    OwnerId = 4,
                },
                new Pet
                {
                    Id = 3,
                    Name = "Loki",
                    Age = 1,
                    Breed = "Syrian",
                    Type = "Hamster",
                    OwnerId = 1,
                },
                new Pet
                {
                    Id = 4,
                    Name = "Simba",
                    Age = 1,
                    Breed = "Bichon Frise",
                    Type = "Dog",
                    OwnerId = 2,
                },
                new Pet
                {
                    Id = 5,
                    Name = "Nala",
                    Age = 1,
                    Breed = "Street",
                    Type = "Cat",
                    OwnerId = 3,
                },
            };

            return pets;
        }
    }
}
