namespace PetCare.Infrastructure.EntityConfigurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetCare.Domain.Entities;
    using static PetCare.Infrastructure.Common.DatabaseConstants.AppointmentConstants;

    public class AppointmentEntityTypeConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder
                .HasKey(appointment => appointment.Id);

            builder
                .Property(appointment => appointment.ReasonForAppointment)
                .HasMaxLength(ReasonForAppointmentMaxLength);

            builder
                .HasOne(appointment => appointment.Owner)
                .WithMany(appointment => appointment.Appointments)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
