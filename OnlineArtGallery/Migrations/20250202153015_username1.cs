using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class username1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 18, 34, 38, 127, DateTimeKind.Local).AddTicks(9558), new DateTime(2025, 2, 2, 18, 34, 38, 127, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4715830-f034-410a-85c2-0fc8157a133e", "AQAAAAIAAYagAAAAEAqqlzrHWza+bXPo9sF53lUPYp5P4+Vngmmns4PpCySM2C1NRVJsnemyUKVlgvEnVA==", "64b8c173-0fd2-494c-bb6f-70103b2aee69" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 18, 34, 38, 127, DateTimeKind.Local).AddTicks(9987), new DateTime(2025, 2, 2, 18, 34, 38, 127, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 18, 34, 38, 127, DateTimeKind.Local).AddTicks(9992), new DateTime(2025, 2, 2, 18, 34, 38, 127, DateTimeKind.Local).AddTicks(9993) });
        }
    }
}
