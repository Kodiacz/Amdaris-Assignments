namespace PetCare.Infrastructure.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PetCare.Domain.Entities;

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
                .HasMaxLength(FirstNameMaxLengthForOwner);

            ownerConfiguration
                .Property(owner => owner.LastName)
                .IsRequired()
                .HasMaxLength(LastNameMaxLengthForOwner);

            ownerConfiguration
                .Property(owner => owner.Phonenumber)
                .IsRequired()
                .HasMaxLength(PhonenumberMaxLengthForOwner);

            ownerConfiguration
                .Property(owner => owner.Age)
                .IsRequired(false);

            ownerConfiguration
                .Property(owner => owner.Username)
                .IsRequired()
                .HasMaxLength(UserNameMaxLenghtForOwner);

            ownerConfiguration
                .Property(owner => owner.Email)
                .IsRequired()
                .HasMaxLength(EmailMaxLenghtForOwner);

            ownerConfiguration
                .Property(owner => owner.PasswordHash)
                .IsRequired(false);

            ownerConfiguration
            .Property(owner => owner.PasswordSalt)
            .IsRequired(false);
                
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
                    Username = "stanimircho",
                    Email = "stanimir@email.com",
                },
                new Owner
                {
                    Id = 2,
                    FirstName = "Desislava",
                    LastName = "Koleva",
                    Age = 30,
                    Phonenumber = GenerateMobilePhone(),
                    Username = "desi",
                    Email = "desi@email.com",
                },
                new Owner
                {
                    Id = 3,
                    FirstName = "Vencislav",
                    LastName = "Kolev",
                    Age = 43,
                    Phonenumber = GenerateMobilePhone(),
                    Username = "venci",
                    Email = "venci@email.com",
                },
                new Owner
                {
                    Id = 4,
                    FirstName = "Simeon",
                    LastName = "Kostadinov",
                    Age = 26,
                    Phonenumber = GenerateMobilePhone(),
                    Username = "simo",
                    Email = "simo@email.com",
                },
            };

            return owners;
        }
    }
}
