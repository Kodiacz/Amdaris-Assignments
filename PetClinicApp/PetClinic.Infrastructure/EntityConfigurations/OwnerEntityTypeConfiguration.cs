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
            ownerConfiguration
                .HasMany(owner => owner.Pets)
                .WithOne(pet => pet.Owner)
                .HasForeignKey(pet => pet.OwnerId)
                .OnDelete(DeleteBehavior.SetNull);

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
        }
    }
}
