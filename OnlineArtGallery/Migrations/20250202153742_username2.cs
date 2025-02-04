using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class username2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 23, 37, 41, 637, DateTimeKind.Local).AddTicks(9642), new DateTime(2025, 2, 2, 23, 37, 41, 637, DateTimeKind.Local).AddTicks(9656) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 23, 30, 14, 356, DateTimeKind.Local).AddTicks(2697), new DateTime(2025, 2, 2, 23, 30, 14, 356, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c64e9a81-bef3-4e7d-a46f-b77a0037d24c", "AQAAAAIAAYagAAAAEDXm6wlWD14+uJn+9EOlGatvStuS9ozS8FrCu6vcr859WMPVBeHLvvrkMBJ/8J7MzA==", "4704faeb-63eb-4924-a030-3db42c00b189" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 23, 30, 14, 356, DateTimeKind.Local).AddTicks(3342), new DateTime(2025, 2, 2, 23, 30, 14, 356, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 23, 30, 14, 356, DateTimeKind.Local).AddTicks(3345), new DateTime(2025, 2, 2, 23, 30, 14, 356, DateTimeKind.Local).AddTicks(3345) });
        }
    }
}
