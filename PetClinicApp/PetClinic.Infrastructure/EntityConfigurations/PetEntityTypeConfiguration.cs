namespace PetClinic.Infrastructure.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using PetClinic.Domain.Entities;
    using static PetClinic.Infrastructure.Common.DatabaseConstants.PetConstnats;

    public class PetEntityTypeConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> petConfiguration)
        {
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
                .HasMaxLength(NameMaxLength);

            petConfiguration
                .Property(pet => pet.Breed)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            petConfiguration
                .Property(pet => pet.Type)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

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
    }
}
