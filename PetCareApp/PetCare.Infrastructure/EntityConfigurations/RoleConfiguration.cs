namespace PetCare.Infrastructure.EntityConfigurations
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetCare.Domain.Entities;

    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<int>> builder)
        {
            builder.ToTable("Roles");
            
            builder.HasData(
                new IdentityRole<int>()
                {
                    Id = 1,
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole<int>()
                {
                    Id = 2,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                });
        }
    }
}
