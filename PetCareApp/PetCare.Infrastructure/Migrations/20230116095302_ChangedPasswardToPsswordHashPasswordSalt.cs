using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetCare.Infrastructure.Migrations
{
    public partial class ChangedPasswardToPsswordHashPasswordSalt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Owners");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Owners",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(35)",
                oldMaxLength: 35);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Owners",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Owners",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: "0235939");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0247579");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0228540");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0288944");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1,
                column: "Phonenumber",
                value: "0886973318");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                column: "Phonenumber",
                value: "0892413113");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                column: "Phonenumber",
                value: "0885270995");

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4,
                column: "Phonenumber",
                value: "0871186811");

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 151,
                column: "Date",
                value: new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 153,
                column: "Date",
                value: new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 155,
                column: "Date",
                value: new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 159,
                column: "Date",
                value: new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 160,
                column: "Date",
                value: new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 161,
                column: "Date",
                value: new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 162,
                column: "Date",
                value: new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 163,
                column: "Date",
                value: new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 166,
                column: "Date",
                value: new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 167,
                column: "Date",
                value: new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 168,
                column: "Date",
                value: new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 169,
                column: "Date",
                value: new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 170,
                column: "Date",
                value: new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 171,
                column: "Date",
                value: new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 177,
                column: "Date",
                value: new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 178,
                column: "Date",
                value: new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 179,
                column: "Date",
                value: new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 182,
                column: "Date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 184,
                column: "Date",
                value: new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 185,
                column: "Date",
                value: new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 186,
                column: "Date",
                value: new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 187,
                column: "Date",
                value: new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 190,
                column: "Date",
                value: new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 192,
                column: "Date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 193,
                column: "Date",
                value: new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 195,
                column: "Date",
                value: new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 196,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 198,
                column: "Date",
                value: new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 200,
                column: "Date",
                value: new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 202,
                column: "Date",
                value: new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 204,
                column: "Date",
                value: new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 207,
                column: "Date",
                value: new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 208,
                column: "Date",
                value: new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 209,
                column: "Date",
                value: new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 210,
                column: "Date",
                value: new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 212,
                column: "Date",
                value: new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 213,
                column: "Date",
                value: new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 215,
                column: "Date",
                value: new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 216,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 221,
                column: "Date",
                value: new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 223,
                column: "Date",
                value: new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 224,
                column: "Date",
                value: new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 225,
                column: "Date",
                value: new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 226,
                column: "Date",
                value: new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 231,
                column: "Date",
                value: new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 233,
                column: "Date",
                value: new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 235,
                column: "Date",
                value: new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 237,
                column: "Date",
                value: new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 239,
                column: "Date",
                value: new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 250,
                column: "Date",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 254,
                column: "Date",
                value: new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 258,
                column: "Date",
                value: new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 259,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 260,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 261,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 262,
                column: "Date",
                value: new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 264,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 265,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 266,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 267,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 272,
                column: "Date",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 273,
                column: "Date",
                value: new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 274,
                column: "Date",
                value: new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 276,
                column: "Date",
                value: new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 278,
                column: "Date",
                value: new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 279,
                column: "Date",
                value: new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 282,
                column: "Date",
                value: new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 287,
                column: "Date",
                value: new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 289,
                column: "Date",
                value: new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 290,
                column: "Date",
                value: new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 292,
                column: "Date",
                value: new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 293,
                column: "Date",
                value: new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 294,
                column: "Date",
                value: new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 298,
                column: "Date",
                value: new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 299,
                column: "Date",
                value: new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 300,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 302,
                column: "Date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 303,
                column: "Date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 304,
                column: "Date",
                value: new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 310,
                column: "Date",
                value: new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 313,
                column: "Date",
                value: new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 314,
                column: "Date",
                value: new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 315,
                column: "Date",
                value: new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 316,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 317,
                column: "Date",
                value: new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 318,
                column: "Date",
                value: new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 320,
                column: "Date",
                value: new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 323,
                column: "Date",
                value: new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 326,
                column: "Date",
                value: new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 327,
                column: "Date",
                value: new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 328,
                column: "Date",
                value: new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 330,
                column: "Date",
                value: new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 331,
                column: "Date",
                value: new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 332,
                column: "Date",
                value: new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 335,
                column: "Date",
                value: new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 338,
                column: "Date",
                value: new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 339,
                column: "Date",
                value: new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 340,
                column: "Date",
                value: new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 341,
                column: "Date",
                value: new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 344,
                column: "Date",
                value: new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 345,
                column: "Date",
                value: new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 350,
                column: "Date",
                value: new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 353,
                column: "Date",
                value: new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 354,
                column: "Date",
                value: new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 355,
                column: "Date",
                value: new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 356,
                column: "Date",
                value: new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 359,
                column: "Date",
                value: new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 374,
                column: "Date",
                value: new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 375,
                column: "Date",
                value: new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 377,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 378,
                column: "Date",
                value: new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 379,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 382,
                column: "Date",
                value: new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 383,
                column: "Date",
                value: new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 385,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 387,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 388,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 389,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 390,
                column: "Date",
                value: new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 391,
                column: "Date",
                value: new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 394,
                column: "Date",
                value: new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 396,
                column: "Date",
                value: new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 398,
                column: "Date",
                value: new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 399,
                column: "Date",
                value: new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 400,
                column: "Date",
                value: new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 401,
                column: "Date",
                value: new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 405,
                column: "Date",
                value: new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 407,
                column: "Date",
                value: new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 408,
                column: "Date",
                value: new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 410,
                column: "Date",
                value: new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 412,
                column: "Date",
                value: new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 415,
                column: "Date",
                value: new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 417,
                column: "Date",
                value: new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 420,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 421,
                column: "Date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 425,
                column: "Date",
                value: new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 426,
                column: "Date",
                value: new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 431,
                column: "Date",
                value: new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 432,
                column: "Date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 433,
                column: "Date",
                value: new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 435,
                column: "Date",
                value: new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 436,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 438,
                column: "Date",
                value: new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 439,
                column: "Date",
                value: new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 440,
                column: "Date",
                value: new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 442,
                column: "Date",
                value: new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 445,
                column: "Date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 446,
                column: "Date",
                value: new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 447,
                column: "Date",
                value: new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 449,
                column: "Date",
                value: new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 450,
                column: "Date",
                value: new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 452,
                column: "Date",
                value: new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 453,
                column: "Date",
                value: new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 456,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 458,
                column: "Date",
                value: new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 460,
                column: "Date",
                value: new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 461,
                column: "Date",
                value: new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 467,
                column: "Date",
                value: new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 468,
                column: "Date",
                value: new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 470,
                column: "Date",
                value: new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 471,
                column: "Date",
                value: new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 473,
                column: "Date",
                value: new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 475,
                column: "Date",
                value: new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 476,
                column: "Date",
                value: new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 478,
                column: "Date",
                value: new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 479,
                column: "Date",
                value: new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 480,
                column: "Date",
                value: new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 497,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 498,
                column: "Date",
                value: new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 501,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 503,
                column: "Date",
                value: new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 507,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 509,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 512,
                column: "Date",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 515,
                column: "Date",
                value: new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 520,
                column: "Date",
                value: new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 521,
                column: "Date",
                value: new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 522,
                column: "Date",
                value: new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 523,
                column: "Date",
                value: new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 524,
                column: "Date",
                value: new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 525,
                column: "Date",
                value: new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 529,
                column: "Date",
                value: new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 532,
                column: "Date",
                value: new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 533,
                column: "Date",
                value: new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 534,
                column: "Date",
                value: new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 536,
                column: "Date",
                value: new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 537,
                column: "Date",
                value: new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 538,
                column: "Date",
                value: new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 539,
                column: "Date",
                value: new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 540,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 542,
                column: "Date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 543,
                column: "Date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 544,
                column: "Date",
                value: new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 546,
                column: "Date",
                value: new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 547,
                column: "Date",
                value: new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 548,
                column: "Date",
                value: new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 551,
                column: "Date",
                value: new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 552,
                column: "Date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 553,
                column: "Date",
                value: new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 554,
                column: "Date",
                value: new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 557,
                column: "Date",
                value: new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 558,
                column: "Date",
                value: new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 559,
                column: "Date",
                value: new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 567,
                column: "Date",
                value: new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 568,
                column: "Date",
                value: new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 570,
                column: "Date",
                value: new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 573,
                column: "Date",
                value: new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 574,
                column: "Date",
                value: new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 575,
                column: "Date",
                value: new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 577,
                column: "Date",
                value: new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 579,
                column: "Date",
                value: new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 581,
                column: "Date",
                value: new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 585,
                column: "Date",
                value: new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 589,
                column: "Date",
                value: new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 590,
                column: "Date",
                value: new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 591,
                column: "Date",
                value: new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 592,
                column: "Date",
                value: new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 593,
                column: "Date",
                value: new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 595,
                column: "Date",
                value: new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 599,
                column: "Date",
                value: new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 621,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 623,
                column: "Date",
                value: new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 625,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 626,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 627,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 628,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 631,
                column: "Date",
                value: new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 635,
                column: "Date",
                value: new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 636,
                column: "Date",
                value: new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 637,
                column: "Date",
                value: new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 638,
                column: "Date",
                value: new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 639,
                column: "Date",
                value: new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 640,
                column: "Date",
                value: new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 641,
                column: "Date",
                value: new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 644,
                column: "Date",
                value: new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 645,
                column: "Date",
                value: new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 646,
                column: "Date",
                value: new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 647,
                column: "Date",
                value: new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 648,
                column: "Date",
                value: new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 652,
                column: "Date",
                value: new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 653,
                column: "Date",
                value: new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 654,
                column: "Date",
                value: new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 655,
                column: "Date",
                value: new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 656,
                column: "Date",
                value: new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 658,
                column: "Date",
                value: new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 660,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 661,
                column: "Date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 662,
                column: "Date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 665,
                column: "Date",
                value: new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 668,
                column: "Date",
                value: new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 671,
                column: "Date",
                value: new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 675,
                column: "Date",
                value: new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 676,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 678,
                column: "Date",
                value: new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 681,
                column: "Date",
                value: new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 682,
                column: "Date",
                value: new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 683,
                column: "Date",
                value: new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 688,
                column: "Date",
                value: new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 690,
                column: "Date",
                value: new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 692,
                column: "Date",
                value: new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 693,
                column: "Date",
                value: new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 695,
                column: "Date",
                value: new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 696,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 697,
                column: "Date",
                value: new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 698,
                column: "Date",
                value: new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 699,
                column: "Date",
                value: new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 703,
                column: "Date",
                value: new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 705,
                column: "Date",
                value: new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 708,
                column: "Date",
                value: new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 710,
                column: "Date",
                value: new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 711,
                column: "Date",
                value: new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 714,
                column: "Date",
                value: new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 717,
                column: "Date",
                value: new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 718,
                column: "Date",
                value: new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 720,
                column: "Date",
                value: new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Owners");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Owners",
                type: "nvarchar(35)",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "Password", "Phonenumber" },
                values: new object[] { "stanimirpetkov", "0893778234" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Password", "Phonenumber" },
                values: new object[] { "desikoleva", "0885828490" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Password", "Phonenumber" },
                values: new object[] { "vencikolev", "0888185379" });

            migrationBuilder.UpdateData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Password", "Phonenumber" },
                values: new object[] { "simokostadinov", "0899070318" });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 23,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 26,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 27,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 28,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 30,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 90,
                column: "Date",
                value: new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 92,
                column: "Date",
                value: new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 93,
                column: "Date",
                value: new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 94,
                column: "Date",
                value: new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 95,
                column: "Date",
                value: new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 97,
                column: "Date",
                value: new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 98,
                column: "Date",
                value: new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 112,
                column: "Date",
                value: new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 114,
                column: "Date",
                value: new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 116,
                column: "Date",
                value: new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 117,
                column: "Date",
                value: new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 118,
                column: "Date",
                value: new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 119,
                column: "Date",
                value: new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 120,
                column: "Date",
                value: new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 125,
                column: "Date",
                value: new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 126,
                column: "Date",
                value: new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 128,
                column: "Date",
                value: new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 131,
                column: "Date",
                value: new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 132,
                column: "Date",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 136,
                column: "Date",
                value: new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 138,
                column: "Date",
                value: new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 139,
                column: "Date",
                value: new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 140,
                column: "Date",
                value: new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 146,
                column: "Date",
                value: new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 148,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 150,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 151,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 153,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 155,
                column: "Date",
                value: new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 159,
                column: "Date",
                value: new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 160,
                column: "Date",
                value: new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 161,
                column: "Date",
                value: new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 162,
                column: "Date",
                value: new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 163,
                column: "Date",
                value: new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 166,
                column: "Date",
                value: new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 167,
                column: "Date",
                value: new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 168,
                column: "Date",
                value: new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 169,
                column: "Date",
                value: new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 170,
                column: "Date",
                value: new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 171,
                column: "Date",
                value: new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 177,
                column: "Date",
                value: new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 178,
                column: "Date",
                value: new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 179,
                column: "Date",
                value: new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 182,
                column: "Date",
                value: new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 184,
                column: "Date",
                value: new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 185,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 186,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 187,
                column: "Date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 190,
                column: "Date",
                value: new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 191,
                column: "Date",
                value: new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 192,
                column: "Date",
                value: new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 193,
                column: "Date",
                value: new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 195,
                column: "Date",
                value: new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 196,
                column: "Date",
                value: new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 198,
                column: "Date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 200,
                column: "Date",
                value: new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 202,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 204,
                column: "Date",
                value: new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 207,
                column: "Date",
                value: new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 208,
                column: "Date",
                value: new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 209,
                column: "Date",
                value: new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 210,
                column: "Date",
                value: new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 212,
                column: "Date",
                value: new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 213,
                column: "Date",
                value: new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 215,
                column: "Date",
                value: new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 216,
                column: "Date",
                value: new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 221,
                column: "Date",
                value: new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 223,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 224,
                column: "Date",
                value: new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 225,
                column: "Date",
                value: new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 226,
                column: "Date",
                value: new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 231,
                column: "Date",
                value: new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 233,
                column: "Date",
                value: new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 235,
                column: "Date",
                value: new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 237,
                column: "Date",
                value: new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 239,
                column: "Date",
                value: new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 250,
                column: "Date",
                value: new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 254,
                column: "Date",
                value: new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 258,
                column: "Date",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 259,
                column: "Date",
                value: new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 260,
                column: "Date",
                value: new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 261,
                column: "Date",
                value: new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 262,
                column: "Date",
                value: new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 264,
                column: "Date",
                value: new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 265,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 266,
                column: "Date",
                value: new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 267,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 272,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 273,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 274,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 276,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 278,
                column: "Date",
                value: new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 279,
                column: "Date",
                value: new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 282,
                column: "Date",
                value: new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 287,
                column: "Date",
                value: new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 289,
                column: "Date",
                value: new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 290,
                column: "Date",
                value: new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 292,
                column: "Date",
                value: new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 293,
                column: "Date",
                value: new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 294,
                column: "Date",
                value: new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 298,
                column: "Date",
                value: new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 299,
                column: "Date",
                value: new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 300,
                column: "Date",
                value: new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 302,
                column: "Date",
                value: new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 303,
                column: "Date",
                value: new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 304,
                column: "Date",
                value: new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 310,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 313,
                column: "Date",
                value: new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 314,
                column: "Date",
                value: new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 315,
                column: "Date",
                value: new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 316,
                column: "Date",
                value: new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 317,
                column: "Date",
                value: new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 318,
                column: "Date",
                value: new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 320,
                column: "Date",
                value: new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 323,
                column: "Date",
                value: new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 326,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 327,
                column: "Date",
                value: new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 328,
                column: "Date",
                value: new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 330,
                column: "Date",
                value: new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 331,
                column: "Date",
                value: new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 332,
                column: "Date",
                value: new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 335,
                column: "Date",
                value: new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 338,
                column: "Date",
                value: new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 339,
                column: "Date",
                value: new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 340,
                column: "Date",
                value: new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 341,
                column: "Date",
                value: new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 344,
                column: "Date",
                value: new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 345,
                column: "Date",
                value: new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 350,
                column: "Date",
                value: new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 353,
                column: "Date",
                value: new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 354,
                column: "Date",
                value: new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 355,
                column: "Date",
                value: new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 356,
                column: "Date",
                value: new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 359,
                column: "Date",
                value: new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 374,
                column: "Date",
                value: new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 375,
                column: "Date",
                value: new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 377,
                column: "Date",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 378,
                column: "Date",
                value: new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 379,
                column: "Date",
                value: new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 382,
                column: "Date",
                value: new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 383,
                column: "Date",
                value: new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 385,
                column: "Date",
                value: new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 387,
                column: "Date",
                value: new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 388,
                column: "Date",
                value: new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 389,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 390,
                column: "Date",
                value: new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 391,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 394,
                column: "Date",
                value: new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 396,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 398,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 399,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 400,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 401,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 405,
                column: "Date",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 407,
                column: "Date",
                value: new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 408,
                column: "Date",
                value: new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 410,
                column: "Date",
                value: new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 412,
                column: "Date",
                value: new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 415,
                column: "Date",
                value: new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 417,
                column: "Date",
                value: new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 420,
                column: "Date",
                value: new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 421,
                column: "Date",
                value: new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 425,
                column: "Date",
                value: new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 426,
                column: "Date",
                value: new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 431,
                column: "Date",
                value: new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 432,
                column: "Date",
                value: new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 433,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 435,
                column: "Date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 436,
                column: "Date",
                value: new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 438,
                column: "Date",
                value: new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 439,
                column: "Date",
                value: new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 440,
                column: "Date",
                value: new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 442,
                column: "Date",
                value: new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 445,
                column: "Date",
                value: new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 446,
                column: "Date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 447,
                column: "Date",
                value: new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 449,
                column: "Date",
                value: new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 450,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 452,
                column: "Date",
                value: new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 453,
                column: "Date",
                value: new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 456,
                column: "Date",
                value: new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 458,
                column: "Date",
                value: new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 460,
                column: "Date",
                value: new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 461,
                column: "Date",
                value: new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 467,
                column: "Date",
                value: new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 468,
                column: "Date",
                value: new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 470,
                column: "Date",
                value: new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 471,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 473,
                column: "Date",
                value: new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 475,
                column: "Date",
                value: new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 476,
                column: "Date",
                value: new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 478,
                column: "Date",
                value: new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 479,
                column: "Date",
                value: new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 480,
                column: "Date",
                value: new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 497,
                column: "Date",
                value: new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 498,
                column: "Date",
                value: new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 501,
                column: "Date",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 503,
                column: "Date",
                value: new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 507,
                column: "Date",
                value: new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 509,
                column: "Date",
                value: new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 512,
                column: "Date",
                value: new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 515,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 520,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 521,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 522,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 523,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 524,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 525,
                column: "Date",
                value: new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 529,
                column: "Date",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 532,
                column: "Date",
                value: new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 533,
                column: "Date",
                value: new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 534,
                column: "Date",
                value: new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 536,
                column: "Date",
                value: new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 537,
                column: "Date",
                value: new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 538,
                column: "Date",
                value: new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 539,
                column: "Date",
                value: new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 540,
                column: "Date",
                value: new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 542,
                column: "Date",
                value: new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 543,
                column: "Date",
                value: new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 544,
                column: "Date",
                value: new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 546,
                column: "Date",
                value: new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 547,
                column: "Date",
                value: new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 548,
                column: "Date",
                value: new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 551,
                column: "Date",
                value: new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 552,
                column: "Date",
                value: new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 553,
                column: "Date",
                value: new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 554,
                column: "Date",
                value: new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 557,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 558,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 559,
                column: "Date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 567,
                column: "Date",
                value: new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 568,
                column: "Date",
                value: new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 570,
                column: "Date",
                value: new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 573,
                column: "Date",
                value: new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 574,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 575,
                column: "Date",
                value: new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 577,
                column: "Date",
                value: new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 579,
                column: "Date",
                value: new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 581,
                column: "Date",
                value: new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 585,
                column: "Date",
                value: new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 589,
                column: "Date",
                value: new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 590,
                column: "Date",
                value: new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 591,
                column: "Date",
                value: new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 592,
                column: "Date",
                value: new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 593,
                column: "Date",
                value: new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 595,
                column: "Date",
                value: new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 599,
                column: "Date",
                value: new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "Date", "DoctorId" },
                values: new object[] { new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "Date", "DoctorId", "IsAvailable" },
                values: new object[] { new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 621,
                column: "Date",
                value: new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 623,
                column: "Date",
                value: new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 625,
                column: "Date",
                value: new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 626,
                column: "Date",
                value: new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 627,
                column: "Date",
                value: new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 628,
                column: "Date",
                value: new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 631,
                column: "Date",
                value: new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 635,
                column: "Date",
                value: new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 636,
                column: "Date",
                value: new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 637,
                column: "Date",
                value: new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 638,
                column: "Date",
                value: new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 639,
                column: "Date",
                value: new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 640,
                column: "Date",
                value: new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 641,
                column: "Date",
                value: new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 644,
                column: "Date",
                value: new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 645,
                column: "Date",
                value: new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 646,
                column: "Date",
                value: new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 647,
                column: "Date",
                value: new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 648,
                column: "Date",
                value: new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 652,
                column: "Date",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 653,
                column: "Date",
                value: new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 654,
                column: "Date",
                value: new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 655,
                column: "Date",
                value: new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 656,
                column: "Date",
                value: new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 658,
                column: "Date",
                value: new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 660,
                column: "Date",
                value: new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 661,
                column: "Date",
                value: new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 662,
                column: "Date",
                value: new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 665,
                column: "Date",
                value: new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 668,
                column: "Date",
                value: new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 671,
                column: "Date",
                value: new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 675,
                column: "Date",
                value: new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 676,
                column: "Date",
                value: new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 678,
                column: "Date",
                value: new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 681,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 682,
                column: "Date",
                value: new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 683,
                column: "Date",
                value: new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 688,
                column: "Date",
                value: new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 690,
                column: "Date",
                value: new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 692,
                column: "Date",
                value: new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 693,
                column: "Date",
                value: new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 695,
                column: "Date",
                value: new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 696,
                column: "Date",
                value: new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 697,
                column: "Date",
                value: new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 698,
                column: "Date",
                value: new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 699,
                column: "Date",
                value: new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 703,
                column: "Date",
                value: new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 705,
                column: "Date",
                value: new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 708,
                column: "Date",
                value: new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 710,
                column: "Date",
                value: new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 711,
                column: "Date",
                value: new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 714,
                column: "Date",
                value: new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 717,
                column: "Date",
                value: new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 718,
                column: "Date",
                value: new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "Date", "IsAvailable" },
                values: new object[] { new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true });

            migrationBuilder.UpdateData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 720,
                column: "Date",
                value: new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
                    { 721, new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 722, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true },
                    { 723, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 724, new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, false },
                    { 725, new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Date", "DoctorId", "IsAvailable" },
                values: new object[,]
                {
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
    }
}
