using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Artwork");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "049af969-465b-4293-8e6d-8a22f162819e", "AQAAAAIAAYagAAAAEDJPaRKEq8XeiLAByfSkJhaEzxKlsx7xTRWct56v02o1+AHd+fGzL1SkNEBYQBLYOQ==", "a7e72751-dd3d-4318-bb14-c5941a76ac38" });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 12, 23, 34, 2, DateTimeKind.Local).AddTicks(6034), new DateTime(2025, 2, 4, 12, 23, 34, 2, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 12, 23, 34, 2, DateTimeKind.Local).AddTicks(6051), new DateTime(2025, 2, 4, 12, 23, 34, 2, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 12, 23, 34, 2, DateTimeKind.Local).AddTicks(6235), new DateTime(2025, 2, 4, 12, 23, 34, 2, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 12, 23, 34, 2, DateTimeKind.Local).AddTicks(6237), new DateTime(2025, 2, 4, 12, 23, 34, 2, DateTimeKind.Local).AddTicks(6238) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Artwork",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Artwork",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ImagePath", "Name", "Price", "UpdatedBy", "UserId" },
                values: new object[] { 1, "System", new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4250), new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4263), "A Monkey", null, "Monkey", 0.01, "System", 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da5bd5d7-112b-430b-bf1d-81780fa684db", "AQAAAAIAAYagAAAAEHi6i24mTTu80JqMD/yclhKaJQ93ZsluveV2nDxu1gGZJebLwH0hBsj5MSL9h1ixKg==", "1e0bd8d4-24b0-49ca-89a9-d38e0585b44c" });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4507), new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Auction",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4510), new DateTime(2025, 1, 14, 12, 56, 24, 556, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 3, 13, 41, 828, DateTimeKind.Local).AddTicks(2443), new DateTime(2025, 2, 3, 3, 13, 41, 828, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 3, 3, 13, 41, 828, DateTimeKind.Local).AddTicks(2460), new DateTime(2025, 2, 3, 3, 13, 41, 828, DateTimeKind.Local).AddTicks(2460) });
        }
    }
}
