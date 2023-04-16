namespace PetCare.Infrastructure.EntityConfigurations
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using PetCare.Domain.Entities;

    public class UsersRolesConfiguration : IEntityTypeConfiguration<UsersRoles>
    {
        public void Configure(EntityTypeBuilder<UsersRoles> builder)
        {
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });

            builder
                .HasOne(ur => ur.User)
                .WithMany(u => u.UsersRoles)
                .HasForeignKey("UserId");

            //builder
            //    .HasOne(ur => ur.Role)
            //    .WithMany(r => r.UsersRoles)
            //    .HasForeignKey("RoleId");

            builder
                .HasOne<IdentityRole<int>>()
                .WithMany()
                .HasForeignKey("RoleId");
        }
    }
}
