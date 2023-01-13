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
            doctorConfiguration
                .HasData(CreateDoctors());

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

            doctorConfiguration
                .HasMany(doctor => doctor.Schedule)
                .WithOne(doctor => doctor.Doctor);
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
                    JobDescription = "Emergency medical care, internal medicine",
                    ImageFilePath = @"C:\Simeon\Programming\Amdaris\Assignemnts-Git-Repo\PetCareApp\PetCare-FE\public\img\the-team\team-3.jpg"
                },
                new Doctor()
                {
                    Id = 2,
                    FirstName = "Valentina",
                    LastName = "Naidenova",
                    Age = 26,
                    Phonenumber = GenerateLandlinePhone(),
                    StartedJobDate = DateTime.ParseExact("25/07/2018", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                    JobDescription = "Parasitology and infectious diseases",
                    ImageFilePath = @"C:\Simeon\Programming\Amdaris\Assignemnts-Git-Repo\PetCareApp\PetCare-FE\public\img\the-team\team-4.jpg"

                },
                new Doctor()
                {
                    Id = 3,
                    FirstName = "Borislava",
                    LastName = "Georgieva",
                    Age = 46,
                    Phonenumber = GenerateLandlinePhone(),
                    StartedJobDate = DateTime.ParseExact("15/10/2011", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                    JobDescription = "orthopedics and traumatology, abdominal and thoracic surgery, panelist",
                    ImageFilePath = @"C:\Simeon\Programming\Amdaris\Assignemnts-Git-Repo\PetCareApp\PetCare-FE\public\img\the-team\team-5.jpg"
                },
                new Doctor()
                {
                    Id = 4,
                    FirstName = "Veselin",
                    LastName = "Milushev",
                    Age = 35,
                    Phonenumber = GenerateLandlinePhone(),
                    StartedJobDate = DateTime.ParseExact("27/03/2010", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                    JobDescription = "exotic animals, internal diseases",
                    ImageFilePath = @"C:\Simeon\Programming\Amdaris\Assignemnts-Git-Repo\PetCareApp\PetCare-FE\public\img\the-team\team-6.jpg"
                },
                new Doctor()
                {
                    Id = 5,
                    FirstName = "Petko",
                    LastName = "Stanimiraov",
                    Age = 26,
                    Phonenumber = "0241598",
                    JobDescription = "Emergency medical, internal medicine and infectious diseases.",
                    ImageFilePath = @"C:\Simeon\Programming\Amdaris\Assignemnts-Git-Repo\PetCareApp\PetCare-FE\public\img\the-team\team-7.jpg",
                    StartedJobDate = DateTime.ParseExact("11/04/2011", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                },
                new Doctor()
                {
                    Id = 6,
                    FirstName = "Ivan",
                    LastName = "Petrov",
                    Age = 31,
                    ImageFilePath = @"C:\Simeon\Programming\Amdaris\Assignemnts-Git-Repo\PetCareApp\PetCare-FE\public\img\the-team\team-8.jpg",
                    Phonenumber = "087458589",
                    JobDescription = "Cardiology, thoracic surgery, has interests in dentistry.",
                    StartedJobDate = DateTime.ParseExact("21/05/2013", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                }
            };

            return doctors;
        }
    }
}
