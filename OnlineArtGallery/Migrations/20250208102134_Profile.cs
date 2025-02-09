using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Profile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Artwork");

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Artwork",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
