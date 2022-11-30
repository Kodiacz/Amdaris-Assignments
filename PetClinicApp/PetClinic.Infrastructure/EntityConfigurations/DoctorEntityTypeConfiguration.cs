namespace PetClinic.Infrastructure.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetClinic.Domain.Entities;
    using static PetClinic.Infrastructure.Common.DatabaseConstants.DoctorConstants;

    public class DoctorEntityTypeConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> doctorConfiguration)
        {
            doctorConfiguration
                .HasKey(doctor => doctor.Id);

            doctorConfiguration
                .Property(doctor => doctor.FirstName)
                .IsRequired()
                .HasMaxLength(FirstNameMaxLength);

            doctorConfiguration
                .Property(doctor => doctor.LastName)
                .IsRequired()
                .HasMaxLength(LastNameMaxLength);

            doctorConfiguration
                .Property(doctor => doctor.Phonenumber)
                .IsRequired()
                .HasMaxLength(PhonenumberMaxLength);

            doctorConfiguration
                .Property(doctor => doctor.Age)
                .IsRequired();

            doctorConfiguration
                .Property(doctor => doctor.StartedJobDate)
                .IsRequired();

            doctorConfiguration
                .Property(doctor => doctor.JobDescription)
                .IsRequired()
                .HasMaxLength(JobDescriptionMaxLength);

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
    }
}
