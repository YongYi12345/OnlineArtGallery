using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 14, 11, 54, 9, 485, DateTimeKind.Local).AddTicks(7113), new DateTime(2025, 1, 14, 11, 54, 9, 485, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "0b08a8d5-2abf-447c-bbe4-c9c714d51405", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEI0DGPG0tBHcnr5e+BQPitVBslLG3XKsllwr7ceBShQZ8kAGGr8xO9C8+adIFO24jA==", null, false, "9d6ceb84-8d37-420d-bd69-4dff6bfc540e", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 14, 11, 54, 9, 485, DateTimeKind.Local).AddTicks(7366), new DateTime(2025, 1, 14, 11, 54, 9, 485, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 14, 11, 54, 9, 485, DateTimeKind.Local).AddTicks(7369), new DateTime(2025, 1, 14, 11, 54, 9, 485, DateTimeKind.Local).AddTicks(7370) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 14, 11, 36, 30, 588, DateTimeKind.Local).AddTicks(8348), new DateTime(2025, 1, 14, 11, 36, 30, 588, DateTimeKind.Local).AddTicks(8361) });

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
    }
}
