using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Discussion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Discussion",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7038), new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a4d49ab1-38af-48c0-ad71-fecc5e515741", "AQAAAAIAAYagAAAAELbj0lj3dlafOeOGZvrE1s9TgvYOgxhRKzeQgrAGPefdJR7TR4LKL7+BTyDb38Dkaw==", "a3560f24-5b04-4050-a696-0c7dd1535d6a", null });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7381), new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7383), new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7384) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Discussion");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 11, 17, 42, 526, DateTimeKind.Local).AddTicks(7231), new DateTime(2025, 1, 21, 11, 17, 42, 526, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0cf64e87-efb9-40cf-a314-ccfcba74be7b", "AQAAAAIAAYagAAAAEM1nnGKT21++eFPAGHk2sobBSR5gYWrDTWNkMBUu2OmNRl4D2xPA04yazOWiqTS7Ww==", "a2561162-aa32-49b6-a9fc-57d639dfc288", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 11, 17, 42, 526, DateTimeKind.Local).AddTicks(7558), new DateTime(2025, 1, 21, 11, 17, 42, 526, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 11, 17, 42, 526, DateTimeKind.Local).AddTicks(7562), new DateTime(2025, 1, 21, 11, 17, 42, 526, DateTimeKind.Local).AddTicks(7562) });
        }
    }
}
