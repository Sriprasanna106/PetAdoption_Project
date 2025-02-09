using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class inquiryupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "Inquiry",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResponseDate",
                table: "Inquiry",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84bcc970-e865-4b09-8e33-c60a808b59e1", "AQAAAAIAAYagAAAAEL3GS5FnWY20kdWPmW9SvBXFvDX0eyOsLnv6nf1oytubeE9dYy79N0xNi5R1rYblEA==", "42511327-2195-4865-9838-149b331ba57f" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 11, 27, 24, 542, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 11, 27, 24, 542, DateTimeKind.Local).AddTicks(9932));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Response",
                table: "Inquiry");

            migrationBuilder.DropColumn(
                name: "ResponseDate",
                table: "Inquiry");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0077b8a2-2ef5-402a-82d5-b851c7a1a534", "AQAAAAIAAYagAAAAEElvK8fPHHgzUB+9qHUrCwzBSaCi9wsr1gcpZ8+mm4flQl4qRoMVj8ZWOzLLdW/3Pw==", "7f530a96-cbb2-432c-8eb9-ebabc3e651c6" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 11, 22, 56, 292, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 11, 22, 56, 292, DateTimeKind.Local).AddTicks(3295));
        }
    }
}
