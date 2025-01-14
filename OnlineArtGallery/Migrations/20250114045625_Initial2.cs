using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingBid = table.Column<int>(type: "int", nullable: false),
                    HighestBid = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auction", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4250), new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.InsertData(
                table: "Auction",
                columns: new[] { "Id", "CreatedBy", "Date", "DateCreated", "DateUpdated", "Description", "HighestBid", "Image", "StartingBid", "UpdatedBy" },
                values: new object[,]
                {
                    { 888, "System", 0.0, new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4507), new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4508), 0.0, 0, null, 1, "System" },
                    { 999, "System", 0.0, new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4510), new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4511), 0.0, 0, null, 2, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auction");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 13, 3, 52, 28, 496, DateTimeKind.Local).AddTicks(7561), new DateTime(2025, 1, 13, 3, 52, 28, 496, DateTimeKind.Local).AddTicks(7575) });
        }
    }
}
