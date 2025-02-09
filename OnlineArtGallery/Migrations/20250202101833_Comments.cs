using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Comments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comment",
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
                    table.PrimaryKey("PK_Comment", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 18, 18, 32, 579, DateTimeKind.Local).AddTicks(6014), new DateTime(2025, 2, 2, 18, 18, 32, 579, DateTimeKind.Local).AddTicks(6028) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1458fbcd-69ab-4356-91b9-a59eff3c9a36", "AQAAAAIAAYagAAAAEO4sGEGgO/VsHJd8izM8A9fKov7SsZ00FzMtZ1CeRzbQnhUQm+hr4XTmMhooAzq1JQ==", "23e0a691-1624-4c67-9044-2d8ca661999a" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 18, 18, 32, 579, DateTimeKind.Local).AddTicks(6275), new DateTime(2025, 2, 2, 18, 18, 32, 579, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 18, 18, 32, 579, DateTimeKind.Local).AddTicks(6277), new DateTime(2025, 2, 2, 18, 18, 32, 579, DateTimeKind.Local).AddTicks(6278) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7038), new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4d49ab1-38af-48c0-ad71-fecc5e515741", "AQAAAAIAAYagAAAAELbj0lj3dlafOeOGZvrE1s9TgvYOgxhRKzeQgrAGPefdJR7TR4LKL7+BTyDb38Dkaw==", "a3560f24-5b04-4050-a696-0c7dd1535d6a" });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7381), new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "Wishlist",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7383), new DateTime(2025, 2, 2, 17, 26, 0, 382, DateTimeKind.Local).AddTicks(7384) });
        }
    }
}
