namespace PetClinic.Infrastructure.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PetClinic.Domain.Entities;
    using static PetClinic.Infrastructure.Common.DatabaseConstants.OwnerConstants;
    using static PetClinic.Infrastructure.Common.HelperMethods.PhoneGenerator;

    public class OwnerEntityTypeConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> ownerConfiguration)
        {
            ownerConfiguration
                .HasData(CreateOwners());

            //ownerConfiguration
            //    .Property(owner => owner.Doctor)
            //    .IsRequired(false);

            //ownerConfiguration
            //    .Property(owner => owner.Receptionist)
            //    .IsRequired(false);

            ownerConfiguration
                .Property(owner => owner.FirstName)
                .IsRequired()
                .HasMaxLength(FirstNameMaxLength);

            ownerConfiguration
                .Property(owner => owner.LastName)
                .IsRequired()
                .HasMaxLength(LastNameMaxLength);

            ownerConfiguration
                .Property(owner => owner.Phonenumber)
                .IsRequired()
                .HasMaxLength(PhonenumberMaxLength);

            ownerConfiguration
                .Property(owner => owner.Age)
                .IsRequired();

            ownerConfiguration
                .HasMany(owner => owner.Pets)
                .WithOne(owner => owner.Owner)
                .HasForeignKey(owner => owner.OwnerId)
                .OnDelete(DeleteBehavior.SetNull);

            //ownerConfiguration
            //   .HasOne(owner => owner.Doctor)
            //   .WithMany(doctor => doctor.OwnersOfPatients)
            //   .HasForeignKey(owner => owner.DoctorId)
            //   .OnDelete(DeleteBehavior.SetNull);

            //ownerConfiguration
            //    .HasOne(owner => owner.Receptionist)
            //    .WithMany(receptionist => receptionist.OwnersOfPatients)
            //    .HasForeignKey(owner => owner.ReceptionistId)
            //    .OnDelete(DeleteBehavior.SetNull);
        }

        /// <summary>
        /// Creates a List of owners to seed the database with Owner entities
        /// </summary>
        /// <returns>List of type Owner</returns>
        private List<Owner> CreateOwners()
        {
            var owners = new List<Owner>()
            {
                new Owner
                {
                    Id = 1,
                    FirstName = "Stanimir",
                    LastName = "Petkov",
                    Age = 23,
                    Phonenumber = GenerateMobilePhone(),
                },
                new Owner
                {
                    Id = 2,
                    FirstName = "Desislava",
                    LastName = "Koleva",
                    Age = 30,
                    Phonenumber = GenerateMobilePhone(),
                },
                new Owner
                {
                    Id = 3,
                    FirstName = "Vencislav",
                    LastName = "Kolev",
                    Age = 43,
                    Phonenumber = GenerateMobilePhone(),
                },
                new Owner
                {
                    Id = 4,
                    FirstName = "Simeon",
                    LastName = "Kostadinov",
                    Age = 26,
                    Phonenumber = GenerateMobilePhone(),
                },
            };

            return owners;
        }
    }
}
