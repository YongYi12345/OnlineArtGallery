using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class File1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Artwork",
                newName: "ImagePath");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da5bd5d7-112b-430b-bf1d-81780fa684db", "AQAAAAIAAYagAAAAEHi6i24mTTu80JqMD/yclhKaJQ93ZsluveV2nDxu1gGZJebLwH0hBsj5MSL9h1ixKg==", "1e0bd8d4-24b0-49ca-89a9-d38e0585b44c" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Artwork",
                newName: "Image");

            migrationBuilder.InsertData(
                table: "Artwork",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Image", "Name", "Price", "UpdatedBy", "UserId" },
                values: new object[] { 1, "System", new DateTime(2025, 2, 2, 23, 37, 41, 637, DateTimeKind.Local).AddTicks(9642), new DateTime(2025, 2, 2, 23, 37, 41, 637, DateTimeKind.Local).AddTicks(9656), "A Description of Artwork", "https://th.bing.com/th/id/OIP.GPFEY6kfgxbsja6gmrW6rwHaE7?w=270&h=180&c=7&r=0&o=5&dpr=1.5&pid=1.7", "Name of Artwork", 0.0, "System", 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4860dd7c-34e7-4325-b50a-69630f95d3a3", "AQAAAAIAAYagAAAAEMyRKDcwruKYQRZCOhL7LSV/pMcBB73zDhI7vG2B6e7MnJsMgvHpEyWhisVrPtFdwA==", "35f2f1a1-7cf9-4e06-abff-91ba70390987" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 23, 37, 41, 637, DateTimeKind.Local).AddTicks(9895), new DateTime(2025, 2, 2, 23, 37, 41, 637, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 23, 37, 41, 637, DateTimeKind.Local).AddTicks(9897), new DateTime(2025, 2, 2, 23, 37, 41, 637, DateTimeKind.Local).AddTicks(9898) });
        }
    }
}
