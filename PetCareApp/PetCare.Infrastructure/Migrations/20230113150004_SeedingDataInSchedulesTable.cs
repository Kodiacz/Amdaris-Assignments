using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCare.Infrastructure.Migrations
{
    public partial class SeedingDataInSchedulesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartedJobDate",
                value: new DateTime(2011, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartedJobDate",
                value: new DateTime(2013, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), 1, false },
                    { 2, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 1, false },
                    { 3, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 1, false },
                    { 4, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 1, false },
                    { 5, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 1, false },
                    { 6, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 1, false },
                    { 7, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 1, true },
                    { 8, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 1, false },
                    { 9, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 1, false },
                    { 10, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 1, true },
                    { 11, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 1, true },
                    { 12, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 1, true },
                    { 13, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, false },
                    { 14, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 1, true },
                    { 15, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 1, true },
                    { 16, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 1, true },
                    { 17, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 1, false },
                    { 18, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 1, true },
                    { 19, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 1, true },
                    { 20, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), 2, true },
                    { 21, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 2, false },
                    { 22, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 2, true },
                    { 23, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 2, true },
                    { 24, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 2, true },
                    { 25, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 2, true },
                    { 26, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 2, true },
                    { 27, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 2, true },
                    { 28, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 2, true },
                    { 29, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 2, false },
                    { 30, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 2, false },
                    { 31, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 2, false },
                    { 32, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 2, true }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 33, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 2, false },
                    { 34, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 2, false },
                    { 35, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 2, true },
                    { 36, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 2, false },
                    { 37, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 2, false },
                    { 38, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 2, false },
                    { 39, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 40, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 41, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 42, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 3, false },
                    { 43, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 3, false },
                    { 44, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 3, false },
                    { 45, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 3, false },
                    { 46, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 47, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 3, false },
                    { 48, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 49, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 50, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 51, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 52, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 53, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 54, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 3, false },
                    { 55, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 3, false },
                    { 56, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 57, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 3, true },
                    { 58, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), 4, true },
                    { 59, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 4, true },
                    { 60, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 4, false },
                    { 61, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 4, false },
                    { 62, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 4, false },
                    { 63, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 4, true },
                    { 64, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 4, true },
                    { 65, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 4, true },
                    { 66, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 4, true },
                    { 67, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 4, false },
                    { 68, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 4, true },
                    { 69, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 4, false },
                    { 70, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 4, false },
                    { 71, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 4, false },
                    { 72, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 4, false },
                    { 73, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 4, false },
                    { 74, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 4, false }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 75, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 4, true },
                    { 76, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 4, true },
                    { 77, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 78, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 5, false },
                    { 79, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 5, false },
                    { 80, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 5, false },
                    { 81, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 82, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 83, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 5, false },
                    { 84, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 85, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 86, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 87, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 5, false },
                    { 88, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 5, false },
                    { 89, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 5, false },
                    { 90, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 91, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 92, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 5, false },
                    { 93, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 94, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 95, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 5, true },
                    { 96, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), 6, true },
                    { 97, new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 98, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), 6, true },
                    { 99, new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 100, new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), 6, true },
                    { 101, new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), 6, true },
                    { 102, new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), 6, true },
                    { 103, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), 6, true },
                    { 104, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 105, new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), 6, true },
                    { 106, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 107, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), 6, true },
                    { 108, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 109, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 110, new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 111, new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Utc), 6, true },
                    { 112, new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 113, new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Utc), 6, false },
                    { 114, new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Utc), 6, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 108);

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

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: "0279659");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0269643");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0283476");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0268716");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartedJobDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "StartedJobDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}
