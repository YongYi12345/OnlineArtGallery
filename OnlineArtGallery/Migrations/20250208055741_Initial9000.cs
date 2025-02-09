using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Initial9000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SettingPage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Profile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingPage", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SettingPage");

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
    }
}
