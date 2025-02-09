using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Initialisation9003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Wishlist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "Auction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShippingId",
                table: "Auction",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "DateCreated", "DateUpdated", "PaymentId", "ShippingId" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2527), new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2541), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "DateCreated", "DateUpdated", "PaymentId", "ShippingId" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2543), new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2544), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ImagePath" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2774), new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2775), null });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ImagePath" },
                values: new object[] { new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2777), new DateTime(2025, 2, 9, 13, 9, 13, 112, DateTimeKind.Local).AddTicks(2778), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Wishlist");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "Auction");

            migrationBuilder.DropColumn(
                name: "ShippingId",
                table: "Auction");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "314216c5-bebe-4695-9803-6c28f30f5032", "AQAAAAIAAYagAAAAEPkjyRNwMAYPZXNUsHczFUwGhJXU9js6b2yvpCUoAaS7AmWrDNihRfN+PsvemF2w4w==", "ea8b54d1-81ed-4adc-b812-8ece0062002b" });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(4885), new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(4904), new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(5583), new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(5587), new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(5588) });
        }
    }
}
