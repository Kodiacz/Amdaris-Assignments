namespace PetCare.Infrastructure.EntityConfigurations
{
    using System.Globalization;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PetCare.Domain.Entities;

    public class DoctorEntityTypeConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> doctorConfiguration)
        {
            //doctorConfiguration
            //    .HasData(CreateDoctors());

            doctorConfiguration
                .HasKey(doctor => doctor.Id);

            doctorConfiguration
                .Property(doctor => doctor.FirstName)
                .IsRequired()
                .HasMaxLength(FirstNameMaxLengthForDoctor);

            doctorConfiguration
                .Property(doctor => doctor.LastName)
                .IsRequired()
                .HasMaxLength(LastNameMaxLengthForDoctor);

            doctorConfiguration
                .Property(doctor => doctor.Phonenumber)
                .IsRequired()
                .HasMaxLength(PhonenumberMaxLengthForDoctor);

            doctorConfiguration
                .Property(doctor => doctor.Age)
                .IsRequired();

            doctorConfiguration
                .Property(doctor => doctor.StartedJobDate)
                .IsRequired();

            doctorConfiguration
                .Property(doctor => doctor.JobDescription)
                .IsRequired()
                .HasMaxLength(JobDescriptionMaxLengthForDoctor);

            doctorConfiguration
                .HasMany(doctor => doctor.Patients)
                .WithOne(pet => pet.Doctor)
                .HasForeignKey(pet => pet.DoctorId)
                .OnDelete(DeleteBehavior.SetNull);
            

            doctorConfiguration
                .HasMany(doctor => doctor.OwnersOfPatients)
                .WithOne(owner => owner.Doctor)
                .HasForeignKey(owner => owner.DoctorId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        /// <summary>
        /// Creates a List of doctors to seed the database with Doctor entities
        /// </summary>
        /// <returns>List of type Doctor</returns>
        private List<Doctor> CreateDoctors()
        {
            var doctors = new List<Doctor>()
            {
                new Doctor()
                {
                    Id = 1,
                    FirstName = "Gergana",
                    LastName = "Nikolova",
                    Age = 33,
                    Phonenumber = GenerateLandlinePhone(),
                    StartedJobDate = DateTime.ParseExact("04/12/2018", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                    IsAvailable = true,
                    JobDescription = "Emergency medical care, internal medicine",
                },
                new Doctor()
                {
                    Id = 2,
                    FirstName = "Valentina",
                    LastName = "Naidenova",
                    Age = 26,
                    Phonenumber = GenerateLandlinePhone(),
                    StartedJobDate = DateTime.ParseExact("25/07/2018", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                    IsAvailable = true,
                    JobDescription = "Parasitology and infectious diseases",
                },
                new Doctor()
                {
                    Id = 3,
                    FirstName = "Borisalv",
                    LastName = "Georgiev",
                    Age = 46,
                    Phonenumber = GenerateLandlinePhone(),
                    StartedJobDate = DateTime.ParseExact("15/10/2011", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                    IsAvailable = true,
                    JobDescription = "orthopedics and traumatology, abdominal and thoracic surgery, panelist",
                },
                new Doctor()
                {
                    Id = 4,
                    FirstName = "Veseling",
                    LastName = "Milushev",
                    Age = 35,
                    Phonenumber = GenerateLandlinePhone(),
                    StartedJobDate = DateTime.ParseExact("27/03/2010", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                    IsAvailable = true,
                    JobDescription = "exotic animals, internal diseases",
                },
            };

            return doctors;
        }
    }
}
