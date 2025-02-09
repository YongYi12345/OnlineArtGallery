using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Wishlist2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Artwork");

            migrationBuilder.DropColumn(
                name: "number",
                table: "Artwork");

            migrationBuilder.CreateTable(
                name: "Wishlist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtworkId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlist", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 13, 54, 31, 90, DateTimeKind.Local).AddTicks(6673), new DateTime(2025, 1, 13, 13, 54, 31, 90, DateTimeKind.Local).AddTicks(6695) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wishlist");

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
                values: new object[] { 1, "System", new DateTime(2025, 1, 13, 13, 48, 47, 665, DateTimeKind.Local).AddTicks(8436), new DateTime(2025, 1, 13, 13, 48, 47, 665, DateTimeKind.Local).AddTicks(8452), "A Description of Artwork", "Artwork", "https://th.bing.com/th/id/OIP.GPFEY6kfgxbsja6gmrW6rwHaE7?w=270&h=180&c=7&r=0&o=5&dpr=1.5&pid=1.7", "Name of Artwork", 0.0, "System" });
        }
    }
}
