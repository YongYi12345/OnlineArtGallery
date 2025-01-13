using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class ArtworkSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artwork",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Image", "Name", "Price", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2025, 1, 13, 3, 52, 28, 496, DateTimeKind.Local).AddTicks(7561), new DateTime(2025, 1, 13, 3, 52, 28, 496, DateTimeKind.Local).AddTicks(7575), "A Monkey", "idkhowtoshowimage", "Monkey", 0.01, "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
