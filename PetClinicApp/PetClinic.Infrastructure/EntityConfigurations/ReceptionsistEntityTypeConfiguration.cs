namespace PetClinic.Infrastructure.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetClinic.Domain.Entities;
    using static PetClinic.Infrastructure.Common.DatabaseConstants.ReceptionistConstants;

    public class ReceptionsistEntityTypeConfiguration : IEntityTypeConfiguration<Receptionist>
    {
        public void Configure(EntityTypeBuilder<Receptionist> receptionistConfiguration)
        {
            receptionistConfiguration
                .HasKey(receptionist => receptionist.Id);

            receptionistConfiguration
                .Property(receptionist => receptionist.FirstName)
                .IsRequired()
                .HasMaxLength(FirstNameMaxLength);

            receptionistConfiguration
                .Property(receptionist => receptionist.LastName)
                .IsRequired()
                .HasMaxLength(LastNameMaxLength);

            receptionistConfiguration
                .Property(receptionist => receptionist.Phonenumber)
                .IsRequired()
                .HasMaxLength(PhonenumberMaxLength);

            receptionistConfiguration
                .Property(receptionist => receptionist.Age)
                .IsRequired();

            receptionistConfiguration
                .Property(receptionist => receptionist.StartedJobDate) 
                .IsRequired();

            receptionistConfiguration
                .Property(receptionist => receptionist.JobDescription)
                .IsRequired()
                .HasMaxLength(JobDescriptionMaxLength);

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
    }
}
