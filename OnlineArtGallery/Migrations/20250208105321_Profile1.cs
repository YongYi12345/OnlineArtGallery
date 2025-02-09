using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Profile1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Profile",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0d6afc6-5411-4806-82e2-9b15156cede0", "AQAAAAIAAYagAAAAEHdQinl5D3s42pOnNdVFGvFCvTzRAJHTNn/SGUljhFYOrm+4XyYBS+UOj29DyTyarQ==", "4b762501-9f6e-449e-93c1-b8cf2453debd" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 53, 21, 157, DateTimeKind.Local).AddTicks(7909), new DateTime(2025, 2, 8, 18, 53, 21, 157, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 53, 21, 157, DateTimeKind.Local).AddTicks(7926), new DateTime(2025, 2, 8, 18, 53, 21, 157, DateTimeKind.Local).AddTicks(7926) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Profile");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d1f2256-10cd-48e0-bb0b-4683498a8d61", "AQAAAAIAAYagAAAAEIeT6G/lRZsu60KXi7fZv2ZK6WoM64zw977dRsmXVgKwUJMoeuF/EIY5FxCYiaBKJQ==", "64c16c1b-7ec2-43d2-9da1-2f909c542a64" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 21, 32, 695, DateTimeKind.Local).AddTicks(8878), new DateTime(2025, 2, 8, 18, 21, 32, 695, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 18, 21, 32, 695, DateTimeKind.Local).AddTicks(8903), new DateTime(2025, 2, 8, 18, 21, 32, 695, DateTimeKind.Local).AddTicks(8904) });
        }
    }
}
