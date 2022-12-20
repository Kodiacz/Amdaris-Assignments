using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCare.Infrastructure.Migrations
{
    public partial class AddIsDeletedPropertyToAllEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Receptionists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Pets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Owners",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Receptionists");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Doctors");
        }
    }
}
