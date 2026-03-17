using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalaFinder.Migrations
{
    /// <inheritdoc />
    public partial class SeedAuditLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AuditLogs",
                columns: new[] { "id_log", "action", "entity", "timestamp", "userId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "CREATE_RESERVATION", "Reservation", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "u1" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "CREATE_RESERVATION", "Reservation", new DateTime(2025, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "u2" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "UPDATE_RESERVATION", "Reservation", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "u3" },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "CANCEL_RESERVATION", "Reservation", new DateTime(2025, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "u4" },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "CREATE_SPACE", "Space", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "u5" },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "UPDATE_SPACE", "Space", new DateTime(2025, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "u6" },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "DELETE_RESERVATION", "Reservation", new DateTime(2025, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "u7" },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "CREATE_RESERVATION", "Reservation", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "u8" },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "UPDATE_RESERVATION", "Reservation", new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "u9" },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "LOGIN", "User", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "u10" },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "LOGIN", "User", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "u11" },
                    { new Guid("10000000-0000-0000-0000-000000000012"), "CREATE_RESERVATION", "Reservation", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "u12" },
                    { new Guid("10000000-0000-0000-0000-000000000013"), "UPDATE_RESERVATION", "Reservation", new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "u13" },
                    { new Guid("10000000-0000-0000-0000-000000000014"), "CANCEL_RESERVATION", "Reservation", new DateTime(2025, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "u14" },
                    { new Guid("10000000-0000-0000-0000-000000000015"), "CREATE_SPACE", "Space", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "u15" },
                    { new Guid("10000000-0000-0000-0000-000000000016"), "LOGIN", "User", new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "u1" },
                    { new Guid("10000000-0000-0000-0000-000000000017"), "CREATE_RESERVATION", "Reservation", new DateTime(2025, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "u2" },
                    { new Guid("10000000-0000-0000-0000-000000000018"), "UPDATE_SPACE", "Space", new DateTime(2025, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "u3" },
                    { new Guid("10000000-0000-0000-0000-000000000019"), "LOGIN", "User", new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "u4" },
                    { new Guid("10000000-0000-0000-0000-000000000020"), "DELETE_RESERVATION", "Reservation", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "u5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "AuditLogs",
                keyColumn: "id_log",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"));
        }
    }
}
