namespace PetClinic.Infrastructure.EntityConfigurations
{
    using System;
    using System.Globalization;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PetClinic.Domain.Entities;

    public class ReceptionsistEntityTypeConfiguration : IEntityTypeConfiguration<Receptionist>
    {
        public void Configure(EntityTypeBuilder<Receptionist> receptionistConfiguration)
        {
            //receptionistConfiguration
            //    .HasData(CreateReceptionists());

            receptionistConfiguration
                .HasKey(receptionist => receptionist.Id);

            receptionistConfiguration
                .Property(receptionist => receptionist.FirstName)
                .IsRequired()
                .HasMaxLength(FirstNameMaxLengthForReceptionist);

            receptionistConfiguration
                .Property(receptionist => receptionist.LastName)
                .IsRequired()
                .HasMaxLength(LastNameMaxLengthForReceptionist);

            receptionistConfiguration
                .Property(receptionist => receptionist.Phonenumber)
                .IsRequired()
                .HasMaxLength(PhonenumberMaxLengthForReceptionist);

            receptionistConfiguration
                .Property(receptionist => receptionist.Age)
                .IsRequired();

            receptionistConfiguration
                .Property(receptionist => receptionist.StartedJobDate) 
                .IsRequired();

            receptionistConfiguration
                .Property(receptionist => receptionist.JobDescription)
                .IsRequired()
                .HasMaxLength(JobDescriptionMaxLengthForReceptionist);

            receptionistConfiguration
                .HasMany(receptionist => receptionist.Patients)
                .WithOne(pet => pet.Receptionist)
                .HasForeignKey(pet => pet.ReceptionistId)
                .OnDelete(DeleteBehavior.SetNull);


            receptionistConfiguration
                .HasMany(receptionist => receptionist.OwnersOfPatients)
                .WithOne(owner => owner.Receptionist)
                .HasForeignKey(owner => owner.ReceptionistId)
                .OnDelete(DeleteBehavior.SetNull);
        }

        /// <summary>
        /// Creates a List of receptionists to seed the database with Receptionist entities
        /// </summary>
        /// <returns>List of type Receptionist</returns>
        private List<Receptionist> CreateReceptionists()
        {
            string receptionDeskPhonumber = "0239949";

            List<Receptionist> receptionists = new List<Receptionist>()
            {
                new Receptionist
                {
                    Id = 1,
                    FirstName = "Katya",
                    LastName = "Manolova",
                    Age = 24,
                    Phonenumber = receptionDeskPhonumber,
                    JobDescription = "Receptionist",
                    StartedJobDate = DateTime.ParseExact("12/08/2018", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                },
                new Receptionist
                {
                    Id = 2,
                    FirstName = "Tanyq",
                    LastName = "Gramatikova",
                    Age = 35,
                    Phonenumber = receptionDeskPhonumber,
                    JobDescription = "Receptionist",
                    StartedJobDate = DateTime.ParseExact("14/09/2018", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                },
                new Receptionist
                {
                    Id = 3,
                    FirstName = "Vesela",
                    LastName = "Cvetkova",
                    Age = 24,
                    Phonenumber = receptionDeskPhonumber,
                    JobDescription = "Receptionist",
                    StartedJobDate = DateTime.ParseExact("13/05/2018", "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("bg-BG")),
                },
            };

            return receptionists;
        }
    }
}
