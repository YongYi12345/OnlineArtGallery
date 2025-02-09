using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5064), new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.InsertData(
                table: "Wishlist",
                columns: new[] { "Id", "ArtworkId", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 0, "System", new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5619), new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5622), "System" },
                    { 2, 1, "System", new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5625), new DateTime(2025, 1, 13, 15, 6, 20, 581, DateTimeKind.Local).AddTicks(5627), "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 54, 31, 90, DateTimeKind.Local).AddTicks(6673), new DateTime(2025, 1, 13, 13, 54, 31, 90, DateTimeKind.Local).AddTicks(6695) });
        }
    }
}
