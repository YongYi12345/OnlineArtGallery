using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Profile2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Artwork",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a5f6e27-3982-4076-a78d-62035c529582", "AQAAAAIAAYagAAAAEHUsI/lx4HnBIxdWcHaZSAfXVJNKeLmBBgpFCDKBqtYOqadG05DOhZIY1KGJVi9NbA==", "8cc70faf-08f6-419f-b954-1d0d82e26715" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 32, 54, 992, DateTimeKind.Local).AddTicks(7594), new DateTime(2025, 2, 8, 23, 32, 54, 992, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 23, 32, 54, 992, DateTimeKind.Local).AddTicks(7611), new DateTime(2025, 2, 8, 23, 32, 54, 992, DateTimeKind.Local).AddTicks(7611) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Artwork");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0d6afc6-5411-4806-82e2-9b15156cede0", "Admin", "User", "AQAAAAIAAYagAAAAEHdQinl5D3s42pOnNdVFGvFCvTzRAJHTNn/SGUljhFYOrm+4XyYBS+UOj29DyTyarQ==", "4b762501-9f6e-449e-93c1-b8cf2453debd" });

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
    }
}
