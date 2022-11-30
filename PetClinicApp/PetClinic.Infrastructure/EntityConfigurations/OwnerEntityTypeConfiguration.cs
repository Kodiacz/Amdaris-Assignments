namespace PetClinic.Infrastructure.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PetClinic.Domain.Entities;
    using static PetClinic.Infrastructure.Common.DatabaseConstants.OwnerConstants;

    public class OwnerEntityTypeConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> ownerConfiguration)
        {
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
    }
}
