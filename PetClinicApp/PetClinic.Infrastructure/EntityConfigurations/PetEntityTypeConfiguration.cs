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
                .HasOne(pet => pet.Owner)
                .WithMany(owner => owner.Pets)
                .OnDelete(DeleteBehavior.SetNull);

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
        }
    }
}
