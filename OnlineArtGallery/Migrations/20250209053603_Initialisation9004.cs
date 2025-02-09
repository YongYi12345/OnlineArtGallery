using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Initialisation9004 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(2721), new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(2736), new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(3022), new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(3023), null });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(3025), new DateTime(2025, 2, 9, 13, 36, 2, 207, DateTimeKind.Local).AddTicks(3026), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Wishlist");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2724cf05-6adb-49bb-b79b-192209ebc636", "AQAAAAIAAYagAAAAEJpM8bUTJ8/Mxsfgp/q9Gb9J0tem6m920dzDRLI37ntv6qCaKez4SHBnCVyrJzeJ3Q==", "6c203d23-510d-4de8-930e-7f279d5c78d3" });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2527), new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2543), new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2774), new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2777), new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2778) });
        }
    }
}
