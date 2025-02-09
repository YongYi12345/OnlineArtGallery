//using System;
//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace OnlineArtGallery.Migrations
//{
//    /// <inheritdoc />
//    public partial class Initial2 : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.UpdateData(
//                table: "Artwork",
//                keyColumn: "Id",
//                keyValue: 1,
//                columns: new[] { "DateCreated", "DateUpdated" },
//                values: new object[] { new DateTime(2025, 1, 13, 13, 44, 8, 907, DateTimeKind.Local).AddTicks(3613), new DateTime(2025, 1, 13, 13, 44, 8, 907, DateTimeKind.Local).AddTicks(3634) });
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.UpdateData(
//                table: "Artwork",
//                keyColumn: "Id",
//                keyValue: 1,
//                columns: new[] { "DateCreated", "DateUpdated" },
//                values: new object[] { new DateTime(2025, 1, 13, 13, 33, 0, 416, DateTimeKind.Local).AddTicks(3400), new DateTime(2025, 1, 13, 13, 33, 0, 416, DateTimeKind.Local).AddTicks(3420) });
//        }
//    }
//}
