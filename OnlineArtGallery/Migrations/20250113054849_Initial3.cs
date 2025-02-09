using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 48, 47, 665, DateTimeKind.Local).AddTicks(8436), new DateTime(2025, 1, 13, 13, 48, 47, 665, DateTimeKind.Local).AddTicks(8452) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 44, 8, 907, DateTimeKind.Local).AddTicks(3613), new DateTime(2025, 1, 13, 13, 44, 8, 907, DateTimeKind.Local).AddTicks(3634) });
        }
    }
}
