using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalaFinder.Migrations
{
    /// <inheritdoc />
    public partial class SeedReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "id_reservation", "attendeeCount", "date", "endTime", "purpose", "spaceId", "startTime", "status", "userId" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), 5, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0), "Team meeting", new Guid("11111111-1111-1111-1111-111111111111"), new TimeSpan(0, 9, 0, 0, 0), "Approved", "u1" },
                    { new Guid("20000000-0000-0000-0000-000000000002"), 4, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0), "Project discussion", new Guid("22222222-2222-2222-2222-222222222222"), new TimeSpan(0, 10, 0, 0, 0), "Approved", "u2" },
                    { new Guid("20000000-0000-0000-0000-000000000003"), 20, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0), "Workshop", new Guid("33333333-3333-3333-3333-333333333333"), new TimeSpan(0, 9, 0, 0, 0), "Approved", "u3" },
                    { new Guid("20000000-0000-0000-0000-000000000004"), 8, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Coding session", new Guid("44444444-4444-4444-4444-444444444444"), new TimeSpan(0, 11, 0, 0, 0), "Approved", "u4" },
                    { new Guid("20000000-0000-0000-0000-000000000005"), 6, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0), "Executive meeting", new Guid("55555555-5555-5555-5555-555555555555"), new TimeSpan(0, 14, 0, 0, 0), "Approved", "u5" },
                    { new Guid("20000000-0000-0000-0000-000000000006"), 18, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0), "Training", new Guid("66666666-6666-6666-6666-666666666666"), new TimeSpan(0, 15, 0, 0, 0), "Approved", "u6" },
                    { new Guid("20000000-0000-0000-0000-000000000007"), 5, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0), "Planning", new Guid("11111111-1111-1111-1111-111111111111"), new TimeSpan(0, 9, 0, 0, 0), "Approved", "u7" },
                    { new Guid("20000000-0000-0000-0000-000000000008"), 4, new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Review meeting", new Guid("22222222-2222-2222-2222-222222222222"), new TimeSpan(0, 11, 0, 0, 0), "Approved", "u8" },
                    { new Guid("20000000-0000-0000-0000-000000000009"), 30, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Seminar", new Guid("33333333-3333-3333-3333-333333333333"), new TimeSpan(0, 10, 0, 0, 0), "Approved", "u9" },
                    { new Guid("20000000-0000-0000-0000-000000000010"), 7, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0), "Dev meeting", new Guid("44444444-4444-4444-4444-444444444444"), new TimeSpan(0, 13, 0, 0, 0), "Approved", "u10" },
                    { new Guid("20000000-0000-0000-0000-000000000011"), 6, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0), "Strategy", new Guid("55555555-5555-5555-5555-555555555555"), new TimeSpan(0, 9, 0, 0, 0), "Approved", "u11" },
                    { new Guid("20000000-0000-0000-0000-000000000012"), 10, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Workshop", new Guid("66666666-6666-6666-6666-666666666666"), new TimeSpan(0, 11, 0, 0, 0), "Approved", "u12" },
                    { new Guid("20000000-0000-0000-0000-000000000013"), 4, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0), "Planning", new Guid("11111111-1111-1111-1111-111111111111"), new TimeSpan(0, 14, 0, 0, 0), "Approved", "u13" },
                    { new Guid("20000000-0000-0000-0000-000000000014"), 5, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0), "Sprint review", new Guid("22222222-2222-2222-2222-222222222222"), new TimeSpan(0, 15, 0, 0, 0), "Approved", "u14" },
                    { new Guid("20000000-0000-0000-0000-000000000015"), 40, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0), "Conference", new Guid("33333333-3333-3333-3333-333333333333"), new TimeSpan(0, 9, 0, 0, 0), "Approved", "u15" },
                    { new Guid("20000000-0000-0000-0000-000000000016"), 6, new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Development", new Guid("44444444-4444-4444-4444-444444444444"), new TimeSpan(0, 11, 0, 0, 0), "Approved", "u1" },
                    { new Guid("20000000-0000-0000-0000-000000000017"), 5, new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0), "Meeting", new Guid("55555555-5555-5555-5555-555555555555"), new TimeSpan(0, 13, 0, 0, 0), "Approved", "u2" },
                    { new Guid("20000000-0000-0000-0000-000000000018"), 12, new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 16, 0, 0, 0), "Workshop", new Guid("66666666-6666-6666-6666-666666666666"), new TimeSpan(0, 15, 0, 0, 0), "Approved", "u3" },
                    { new Guid("20000000-0000-0000-0000-000000000019"), 4, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0), "Planning", new Guid("11111111-1111-1111-1111-111111111111"), new TimeSpan(0, 9, 0, 0, 0), "Approved", "u4" },
                    { new Guid("20000000-0000-0000-0000-000000000020"), 3, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Discussion", new Guid("22222222-2222-2222-2222-222222222222"), new TimeSpan(0, 11, 0, 0, 0), "Approved", "u5" },
                    { new Guid("20000000-0000-0000-0000-000000000021"), 15, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0), "Training", new Guid("33333333-3333-3333-3333-333333333333"), new TimeSpan(0, 9, 0, 0, 0), "Approved", "u6" },
                    { new Guid("20000000-0000-0000-0000-000000000022"), 6, new DateTime(2025, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Dev meeting", new Guid("44444444-4444-4444-4444-444444444444"), new TimeSpan(0, 11, 0, 0, 0), "Approved", "u7" },
                    { new Guid("20000000-0000-0000-0000-000000000023"), 5, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 14, 0, 0, 0), "Planning", new Guid("55555555-5555-5555-5555-555555555555"), new TimeSpan(0, 13, 0, 0, 0), "Approved", "u8" },
                    { new Guid("20000000-0000-0000-0000-000000000024"), 18, new DateTime(2025, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 17, 0, 0, 0), "Lab session", new Guid("66666666-6666-6666-6666-666666666666"), new TimeSpan(0, 15, 0, 0, 0), "Approved", "u9" },
                    { new Guid("20000000-0000-0000-0000-000000000025"), 4, new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0), "Meeting", new Guid("11111111-1111-1111-1111-111111111111"), new TimeSpan(0, 9, 0, 0, 0), "Approved", "u10" },
                    { new Guid("20000000-0000-0000-0000-000000000026"), 5, new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 11, 0, 0, 0), "Review", new Guid("22222222-2222-2222-2222-222222222222"), new TimeSpan(0, 10, 0, 0, 0), "Approved", "u11" },
                    { new Guid("20000000-0000-0000-0000-000000000027"), 25, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 13, 0, 0, 0), "Conference", new Guid("33333333-3333-3333-3333-333333333333"), new TimeSpan(0, 11, 0, 0, 0), "Approved", "u12" },
                    { new Guid("20000000-0000-0000-0000-000000000028"), 6, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 15, 0, 0, 0), "Development", new Guid("44444444-4444-4444-4444-444444444444"), new TimeSpan(0, 14, 0, 0, 0), "Approved", "u13" },
                    { new Guid("20000000-0000-0000-0000-000000000029"), 6, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 10, 0, 0, 0), "Executive meeting", new Guid("55555555-5555-5555-5555-555555555555"), new TimeSpan(0, 9, 0, 0, 0), "Approved", "u14" },
                    { new Guid("20000000-0000-0000-0000-000000000030"), 20, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 12, 0, 0, 0), "Training", new Guid("66666666-6666-6666-6666-666666666666"), new TimeSpan(0, 10, 0, 0, 0), "Approved", "u15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000021"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000022"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000023"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000024"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000025"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000026"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000027"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000028"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000029"));

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "id_reservation",
                keyValue: new Guid("20000000-0000-0000-0000-000000000030"));
        }
    }
}
