using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35bf2f6c-373f-4f04-bf38-1007cf5f41f6", "AQAAAAIAAYagAAAAEDKudah7bn5+cwt5RDAoeyXQy6tdfJa+r/gIvkTbKsE9h9cIZodDWLOu5ft0i/mwUA==", "284c4371-c95b-4100-a210-c18743c1c7a3" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 26, 1, 148, DateTimeKind.Local).AddTicks(679), new DateTime(2025, 2, 9, 14, 26, 1, 148, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 26, 1, 148, DateTimeKind.Local).AddTicks(700), new DateTime(2025, 2, 9, 14, 26, 1, 148, DateTimeKind.Local).AddTicks(701) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
