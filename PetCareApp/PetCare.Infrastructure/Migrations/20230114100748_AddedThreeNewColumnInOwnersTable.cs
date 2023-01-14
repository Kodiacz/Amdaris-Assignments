using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCare.Infrastructure.Migrations
{
    public partial class AddedThreeNewColumnInOwnersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Owners",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Owners",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: "0249884");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0243348");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0260959");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0221427");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Password", "Phonenumber", "Username" },
                values: new object[] { "stanimir@email.com", "stanimirpetkov", "0889962909", "stanimircho" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "Password", "Phonenumber", "Username" },
                values: new object[] { "desi@email.com", "desikoleva", "0883267092", "desi" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "Password", "Phonenumber", "Username" },
                values: new object[] { "venci@email.com", "vencikolev", "0885488820", "venci" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "Password", "Phonenumber", "Username" },
                values: new object[] { "simo@email.com", "simokostadinov", "0891742958", "simo" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Owners");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: "0245003");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0213168");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0211853");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0236578");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: "0888399827");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0897247597");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0884156471");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0880368788");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 2, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 4, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 4, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 88,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 89,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 96,
                column: "Date",
                value: new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), false });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 109, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 110, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 111, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 6, true },
                    { 112, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 113, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 114, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 6, true }
                });
        }
    }
}
