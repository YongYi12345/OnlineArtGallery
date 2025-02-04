using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineArtGallery.Migrations
{
    /// <inheritdoc />
    public partial class Comments1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscussionId",
                table: "Comment",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscussionId",
                table: "Comment");

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
    }
}
