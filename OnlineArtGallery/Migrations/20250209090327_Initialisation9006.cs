using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Initialisation9006 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Wishlist");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Auction",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2715461-98b2-46a8-807d-162cf9241f74", "AQAAAAIAAYagAAAAECuN6fPspk5SHLcno0/OKT4jOPsQO0cuJ0zwDSOs4cwSinGIpQDUadPZ7nEJGT63vw==", "ad69adf9-a8f1-4b5a-b2d4-ace69e42fba0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Auction");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Wishlist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c50a177d-b8e2-463f-a871-3c0a9eb1b57b", "AQAAAAIAAYagAAAAEHqNbCJtI2xVGApUde5HtNZQEFpUa7u+4muwL4+rn0EMjcU9m+xj03xdvuU+zMKQRQ==", "fe7124d5-5675-469c-9630-96c10a2c3666" });

            migrationBuilder.InsertData(
                table: "Auction",
                columns: new[] { "Id", "ArtworkId", "CreatedBy", "Date", "DateCreated", "DateUpdated", "Description", "HighestBid", "Image", "PaymentId", "ShippingId", "StartingBid", "UpdatedBy" },
                values: new object[,]
                {
                    { 888, 0, "System", 0.0, new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(2721), new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(2735), 0.0, 0, null, 0, 0, 1, "System" },
                    { 999, 0, "System", 0.0, new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(2736), new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(2737), 0.0, 0, null, 0, 0, 2, "System" }
                });

            migrationBuilder.InsertData(
                table: "Wishlist",
                columns: new[] { "Id", "ArtworkId", "CreatedBy", "DateCreated", "DateUpdated", "ImagePath", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 0, "System", new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(3022), new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(3023), null, null, "System" },
                    { 2, 1, "System", new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(3025), new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(3026), null, null, "System" }
                });
        }
    }
}
