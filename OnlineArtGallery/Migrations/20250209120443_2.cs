using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a52268d9-3771-44f0-821c-a0c035960ac6", "AQAAAAIAAYagAAAAEIFRjk//Cqi8NRcxWnDnaaimqwp0Z5Ex89TEjJ8DK7jHrFnTlKGZQGoakCZp3LUiNg==", "cb277ea1-e9ee-4580-bb1b-fd7f61524095" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 4, 42, 761, DateTimeKind.Local).AddTicks(4674), new DateTime(2025, 2, 9, 20, 4, 42, 761, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 9, 20, 4, 42, 761, DateTimeKind.Local).AddTicks(4689), new DateTime(2025, 2, 9, 20, 4, 42, 761, DateTimeKind.Local).AddTicks(4690) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Comment");

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
    }
}
