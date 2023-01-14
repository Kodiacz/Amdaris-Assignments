using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCare.Infrastructure.Migrations
{
    public partial class AddedMoreScheduleValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Owners",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Owners",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: "0297598");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0277289");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0230072");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0238678");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: "0893778234");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0885828490");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0888185379");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0899070318");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 109, new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true },
                    { 110, new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false },
                    { 111, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true },
                    { 112, new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false },
                    { 113, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false },
                    { 114, new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true },
                    { 115, new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true },
                    { 116, new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false },
                    { 117, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false },
                    { 118, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 119, new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false },
                    { 120, new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true },
                    { 121, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false },
                    { 122, new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false },
                    { 123, new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true },
                    { 124, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false },
                    { 125, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 126, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 127, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 128, new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 129, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 130, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 131, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 132, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 133, new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 134, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 135, new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 136, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 137, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 138, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 139, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 140, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 141, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 142, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 143, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 144, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 145, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 146, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 147, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 148, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 149, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 150, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 151, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 152, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 153, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 154, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 155, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 156, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 157, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 158, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 159, new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 160, new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 161, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 162, new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 163, new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 164, new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 165, new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 166, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 167, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 168, new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 169, new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 170, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 171, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 172, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 173, new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 174, new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 175, new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 176, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 177, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 178, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 179, new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 180, new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 181, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 182, new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 183, new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 184, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 185, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 186, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 187, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 188, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 189, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 190, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 191, new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 192, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 193, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 194, new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 195, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 196, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 197, new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 198, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 199, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 200, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 201, new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 202, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 203, new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 204, new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 205, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 206, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 207, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 208, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 209, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 210, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 211, new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 212, new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 213, new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 214, new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 215, new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 216, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 217, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 218, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 219, new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 220, new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 221, new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 222, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 223, new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 224, new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 225, new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 226, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 227, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 228, new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 229, new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 230, new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 231, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 232, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 233, new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 234, new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 235, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 236, new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 237, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 238, new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 239, new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 240, new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 241, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 242, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 243, new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 244, new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 245, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false },
                    { 246, new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 247, new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 248, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true },
                    { 249, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 250, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 251, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 252, new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 253, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 254, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 255, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 256, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 257, new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 258, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 259, new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 260, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 261, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 262, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 263, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 264, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 265, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 266, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 267, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 268, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 269, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 270, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 271, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 272, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 273, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 274, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 275, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 276, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 277, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 278, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 279, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 280, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 281, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 282, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 283, new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 284, new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 285, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 286, new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 287, new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 288, new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 289, new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 290, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 291, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 292, new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 293, new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 294, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 295, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 296, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 297, new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 298, new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 299, new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 300, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 301, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 302, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 303, new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 304, new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 305, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 306, new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 307, new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 308, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 309, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 310, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 311, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 312, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 313, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 314, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 315, new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 316, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 317, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 318, new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 319, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 320, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 321, new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 322, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 323, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 324, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 325, new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 326, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 327, new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 328, new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 329, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 330, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 331, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 332, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 333, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 334, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 335, new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 336, new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 337, new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 338, new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 339, new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 340, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 341, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 342, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 343, new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 344, new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 345, new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 346, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 347, new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 348, new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 349, new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 350, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 351, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 352, new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 353, new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 354, new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 355, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 356, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 357, new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 358, new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 359, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 360, new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 361, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 362, new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 363, new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 364, new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 365, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 366, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 367, new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 368, new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 369, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 370, new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 371, new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true },
                    { 372, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false },
                    { 373, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 374, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 375, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 376, new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 377, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 378, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 379, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 380, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 381, new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 382, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 383, new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 384, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 385, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 386, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 387, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 388, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 389, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 390, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 391, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 392, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 393, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 394, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 395, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 396, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 397, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 398, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 399, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 400, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 401, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 402, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 403, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 404, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 405, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 406, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 407, new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 408, new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 409, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 410, new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 411, new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 412, new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 413, new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 414, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 415, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 416, new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 417, new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 418, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 419, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 420, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 421, new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 422, new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 423, new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 424, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 425, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 426, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 427, new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 428, new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 429, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 430, new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 431, new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 432, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 433, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 434, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 435, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 436, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 437, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 438, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 439, new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 440, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 441, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 442, new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 443, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 444, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 445, new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 446, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 447, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 448, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 449, new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 450, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 451, new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 452, new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 453, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 454, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 455, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 456, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 457, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 458, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 459, new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 460, new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 461, new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 462, new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 463, new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 464, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 465, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 466, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 467, new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 468, new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 469, new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 470, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 471, new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 472, new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 473, new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 474, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 475, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 476, new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 477, new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 478, new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 479, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 480, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 481, new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 482, new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 483, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 484, new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 485, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 486, new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 487, new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 488, new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 489, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 490, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 491, new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 492, new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 493, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false },
                    { 494, new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 495, new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true },
                    { 496, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 497, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 498, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 499, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 500, new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 501, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 502, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 503, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 504, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 505, new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 506, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 507, new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 508, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 509, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 510, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 511, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 512, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 513, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 514, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 515, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 516, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 517, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 518, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 519, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 520, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 521, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 522, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 523, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 524, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 525, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 526, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 527, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 528, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 529, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 530, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 531, new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 532, new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 533, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 534, new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 535, new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 536, new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 537, new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 538, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 539, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 540, new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 541, new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 542, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 543, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 544, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 545, new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 546, new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 547, new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 548, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 549, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 550, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 551, new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 552, new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 553, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 554, new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 555, new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 556, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 557, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 558, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 559, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 560, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 561, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 562, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 563, new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 564, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 565, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 566, new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 567, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 568, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 569, new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 570, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 571, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 572, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 573, new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 574, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 575, new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 576, new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 577, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 578, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 579, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 580, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 581, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 582, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 583, new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 584, new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 585, new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 586, new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 587, new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 588, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 589, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 590, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 591, new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 592, new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 593, new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 594, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 595, new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 596, new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 597, new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 598, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 599, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 600, new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 601, new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 602, new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 603, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 604, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 605, new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 606, new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 607, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 608, new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 609, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 610, new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 611, new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 612, new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 613, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 614, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 615, new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true },
                    { 616, new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 617, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 618, new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 619, new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 620, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false },
                    { 621, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 622, new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 623, new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 624, new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 625, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 626, new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 627, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 628, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 629, new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 630, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 631, new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 632, new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 633, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 634, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 635, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 636, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 637, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 638, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 639, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 640, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 641, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 642, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 643, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 644, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 645, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 646, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 647, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 648, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 649, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 650, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 651, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 652, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 653, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 654, new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 655, new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 656, new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 657, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 658, new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 659, new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 660, new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 661, new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 662, new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 663, new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 664, new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 665, new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 666, new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 667, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 668, new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 669, new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 670, new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 671, new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 672, new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 673, new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 674, new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 675, new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 676, new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 677, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 678, new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 679, new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 680, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 681, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 682, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 683, new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 684, new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 685, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 686, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 687, new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 688, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 689, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 690, new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 691, new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 692, new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 693, new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 694, new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 695, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 696, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 697, new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 698, new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 699, new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 700, new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 701, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 702, new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 703, new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 704, new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 705, new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 706, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 707, new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 708, new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 709, new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 710, new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 711, new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 712, new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 713, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 714, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 715, new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 716, new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 717, new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 718, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 719, new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 720, new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 721, new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 722, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 723, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 724, new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 725, new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 726, new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 727, new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 728, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 729, new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 730, new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 731, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 732, new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 733, new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 734, new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 735, new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 736, new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 737, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 738, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 739, new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 740, new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 741, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 742, new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 743, new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 744, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Owners",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Owners",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

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
                column: "Phonenumber",
                value: "0889962909");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0883267092");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0885488820");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0891742958");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), false });

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
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc));

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
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), false });

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
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc));

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
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), true });

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
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 2, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 2, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 2, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 2, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 2, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 2, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

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
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 3, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 3, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 3, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 3, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 3, true });

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
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 4, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 5 });

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
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 6, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 6, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 6, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 6, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 6, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 6 });
        }
    }
}
