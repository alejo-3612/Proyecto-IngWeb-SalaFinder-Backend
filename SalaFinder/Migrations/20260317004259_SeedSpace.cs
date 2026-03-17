using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SalaFinder.Migrations
{
    /// <inheritdoc />
    public partial class SeedSpace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Spaces",
                columns: new[] { "id_space", "allowedPrograms", "building", "capacity", "isActive", "name", "requiresApproval", "resources", "type" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Zoom, Teams", "A", 10, true, "Sala Innovacion", false, "TV, Whiteboard", "Meeting" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Zoom", "A", 8, true, "Sala Creativa", false, "TV", "Meeting" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Teams, Zoom", "B", 50, true, "Auditorio Central", true, "Projector, Microphone", "Conference" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Python, VSCode", "C", 20, true, "Laboratorio Digital", true, "Computers", "Lab" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Zoom, Teams", "B", 12, true, "Sala Ejecutiva", true, "TV, Conference Phone", "Meeting" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "None", "D", 25, true, "Sala Taller", false, "Whiteboard, Projector", "Workshop" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "id_space",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "id_space",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "id_space",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "id_space",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "id_space",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Spaces",
                keyColumn: "id_space",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));
        }
    }
}
