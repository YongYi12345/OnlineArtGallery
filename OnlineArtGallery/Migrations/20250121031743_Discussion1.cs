using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Discussion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discussion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussion", x => x.Id);
                });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cf64e87-efb9-40cf-a314-ccfcba74be7b", "AQAAAAIAAYagAAAAEM1nnGKT21++eFPAGHk2sobBSR5gYWrDTWNkMBUu2OmNRl4D2xPA04yazOWiqTS7Ww==", "a2561162-aa32-49b6-a9fc-57d639dfc288" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discussion");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 14, 11, 54, 9, 485, DateTimeKind.Local).AddTicks(7113), new DateTime(2025, 1, 14, 11, 54, 9, 485, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b08a8d5-2abf-447c-bbe4-c9c714d51405", "AQAAAAIAAYagAAAAEI0DGPG0tBHcnr5e+BQPitVBslLG3XKsllwr7ceBShQZ8kAGGr8xO9C8+adIFO24jA==", "9d6ceb84-8d37-420d-bd69-4dff6bfc540e" });

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
    }
}
