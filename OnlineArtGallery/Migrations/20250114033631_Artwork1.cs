using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Artwork1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Artwork",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "UserId" },
                values: new object[] { new DateTime(2025, 1, 14, 11, 36, 30, 588, DateTimeKind.Local).AddTicks(8348), new DateTime(2025, 1, 14, 11, 36, 30, 588, DateTimeKind.Local).AddTicks(8361), 0 });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 14, 11, 36, 30, 588, DateTimeKind.Local).AddTicks(8595), new DateTime(2025, 1, 14, 11, 36, 30, 588, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 14, 11, 36, 30, 588, DateTimeKind.Local).AddTicks(8598), new DateTime(2025, 1, 14, 11, 36, 30, 588, DateTimeKind.Local).AddTicks(8598) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Artwork");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5064), new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5619), new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5622) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5625), new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5627) });
        }
    }
}
