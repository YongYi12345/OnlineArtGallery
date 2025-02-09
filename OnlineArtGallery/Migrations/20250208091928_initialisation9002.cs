using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class initialisation9002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtworkId",
                table: "Auction",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ArtworkId", "DateCreated", "DateUpdated" },
                values: new object[] { 0, new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(4885), new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "ArtworkId", "DateCreated", "DateUpdated" },
                values: new object[] { 0, new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(4904), new DateTime(2025, 2, 8, 17, 19, 27, 596, DateTimeKind.Local).AddTicks(4905) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtworkId",
                table: "Auction");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18e9671-97a7-4643-99b5-f62916438bd1", "AQAAAAIAAYagAAAAEJkYSAQBfU7uWCAzV84manpeXDW87CtLkbTOpOhsu7rD1rzptUGmfvquIoxB3+15nA==", "8d54b1fb-de24-4cf6-9ded-42d49f6face0" });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 57, 40, 344, DateTimeKind.Local).AddTicks(3237), new DateTime(2025, 2, 8, 13, 57, 40, 344, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 57, 40, 344, DateTimeKind.Local).AddTicks(3256), new DateTime(2025, 2, 8, 13, 57, 40, 344, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 57, 40, 344, DateTimeKind.Local).AddTicks(3533), new DateTime(2025, 2, 8, 13, 57, 40, 344, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 13, 57, 40, 344, DateTimeKind.Local).AddTicks(3536), new DateTime(2025, 2, 8, 13, 57, 40, 344, DateTimeKind.Local).AddTicks(3536) });
        }
    }
}
