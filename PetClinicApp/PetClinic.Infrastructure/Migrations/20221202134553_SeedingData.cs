using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetClinic.Infrastructure.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JobDescription",
                table: "Doctors",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Age", "FirstName", "IsAvailable", "IsDeleted", "JobDescription", "LastName", "Phonenumber", "StartedJobDate" },
                values: new object[,]
                {
                    { 1, 33, "Gergana", true, false, "Emergency medical care, internal medicine", "Nikolova", "0215688", new DateTime(2018, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 26, "Valentina", true, false, "Parasitology and infectious diseases", "Naidenova", "0233727", new DateTime(2018, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 46, "Borisalv", true, false, "orthopedics and traumatology, abdominal and thoracic surgery, panelist", "Georgiev", "0251473", new DateTime(2011, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 35, "Veseling", true, false, "exotic animals, internal diseases", "Milushev", "0275727", new DateTime(2010, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Age", "DoctorId", "FirstName", "IsDeleted", "LastName", "Phonenumber", "ReceptionistId" },
                values: new object[,]
                {
                    { 1, 23, null, "Stanimir", false, "Petkov", "0894556801", null },
                    { 2, 30, null, "Desislava", false, "Koleva", "0876378080", null },
                    { 3, 43, null, "Vencislav", false, "Kolev", "0897484868", null },
                    { 4, 26, null, "Simeon", false, "Kostadinov", "0873441234", null }
                });

            migrationBuilder.InsertData(
                table: "Receptionists",
                columns: new[] { "Id", "Age", "FirstName", "IsDeleted", "JobDescription", "LastName", "Phonenumber", "StartedJobDate" },
                values: new object[,]
                {
                    { 1, 24, "Katya", false, "Receptionist", "Manolova", "0239949", new DateTime(2018, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 35, "Tanyq", false, "Receptionist", "Gramatikova", "0239949", new DateTime(2018, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 24, "Vesela", false, "Receptionist", "Cvetkova", "0239949", new DateTime(2018, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Breed", "DoctorId", "IsDeleted", "Name", "OwnerId", "ReceptionistId", "Type" },
                values: new object[,]
                {
                    { 1, 2, "Akita", null, false, "Bella", 4, null, "Dog" },
                    { 2, 4, "Street", null, false, "Milo", 4, null, "Cat" },
                    { 3, 1, "Syrian", null, false, "Loki", 1, null, "Hamster" },
                    { 4, 1, "Bichon Frise", null, false, "Simba", 2, null, "Dog" },
                    { 5, 1, "Street", null, false, "Nala", 3, null, "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Receptionists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Receptionists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Receptionists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "JobDescription",
                table: "Doctors",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);
        }
    }
}
