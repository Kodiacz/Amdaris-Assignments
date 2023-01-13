using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCare.Infrastructure.Migrations
{
    public partial class AddedScheduleTableForDoctors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Doctors");

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageFilePath", "Phonenumber" },
                values: new object[] { "C:\\Simeon\\Programming\\Amdaris\\Assignemnts-Git-Repo\\PetCareApp\\PetCare-FE\\public\\img\\the-team\\team-3.jpg", "0279659" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageFilePath", "Phonenumber" },
                values: new object[] { "C:\\Simeon\\Programming\\Amdaris\\Assignemnts-Git-Repo\\PetCareApp\\PetCare-FE\\public\\img\\the-team\\team-4.jpg", "0269643" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "ImageFilePath", "LastName", "Phonenumber" },
                values: new object[] { "Borislava", "C:\\Simeon\\Programming\\Amdaris\\Assignemnts-Git-Repo\\PetCareApp\\PetCare-FE\\public\\img\\the-team\\team-5.jpg", "Georgieva", "0283476" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "ImageFilePath", "Phonenumber" },
                values: new object[] { "Veselin", "C:\\Simeon\\Programming\\Amdaris\\Assignemnts-Git-Repo\\PetCareApp\\PetCare-FE\\public\\img\\the-team\\team-6.jpg", "0268716" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Age", "FirstName", "ImageFilePath", "IsDeleted", "JobDescription", "LastName", "Phonenumber", "StartedJobDate" },
                values: new object[,]
                {
                    { 5, 26, "Petko", "C:\\Simeon\\Programming\\Amdaris\\Assignemnts-Git-Repo\\PetCareApp\\PetCare-FE\\public\\img\\the-team\\team-7.jpg", false, "Emergency medical, internal medicine and infectious diseases.", "Stanimiraov", "0241598", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 31, "Ivan", "C:\\Simeon\\Programming\\Amdaris\\Assignemnts-Git-Repo\\PetCareApp\\PetCare-FE\\public\\img\\the-team\\team-8.jpg", false, "Cardiology, thoracic surgery, has interests in dentistry.", "Petrov", "087458589", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: "0887493476");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0899209901");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0871346865");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0894958304");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DoctorId",
                table: "Schedules",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageFilePath", "IsAvailable", "Phonenumber" },
                values: new object[] { null, true, "0245347" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageFilePath", "IsAvailable", "Phonenumber" },
                values: new object[] { null, true, "0297185" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "ImageFilePath", "IsAvailable", "LastName", "Phonenumber" },
                values: new object[] { "Borisalv", null, true, "Georgiev", "0242724" });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "ImageFilePath", "IsAvailable", "Phonenumber" },
                values: new object[] { "Veseling", null, true, "0287446" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: "0883160289");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0876370459");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0880349741");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0896370834");
        }
    }
}
