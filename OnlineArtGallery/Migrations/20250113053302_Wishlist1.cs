using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Wishlist1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Artwork",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "number",
                table: "Artwork",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Artwork",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Discriminator", "Image", "Name", "Price", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2025, 1, 13, 13, 33, 0, 416, DateTimeKind.Local).AddTicks(3400), new DateTime(2025, 1, 13, 13, 33, 0, 416, DateTimeKind.Local).AddTicks(3420), "A Description of Artwork", "Artwork", "https://th.bing.com/th/id/OIP.GPFEY6kfgxbsja6gmrW6rwHaE7?w=270&h=180&c=7&r=0&o=5&dpr=1.5&pid=1.7", "Name of Artwork", 0.0, "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Artwork");

            migrationBuilder.DropColumn(
                name: "number",
                table: "Artwork");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Description", "Image", "Name", "Price" },
                values: new object[] { new DateTime(2025, 1, 13, 3, 52, 28, 496, DateTimeKind.Local).AddTicks(7561), new DateTime(2025, 1, 13, 3, 52, 28, 496, DateTimeKind.Local).AddTicks(7575), "A Monkey", "idkhowtoshowimage", "Monkey", 0.01 });
        }
    }
}
