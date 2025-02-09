using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class bepreparedtobechallenged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ResponseDate",
                table: "Inquiry",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1b1e2aa-3776-406d-8dba-ef088ba0d4e9", "AQAAAAIAAYagAAAAEEO6ycjzUX52qOrxsbnHQGhNKZMx8fVW8wjE/3er97aqUMUdp8oCe5/X9d16S/AnLA==", "403907a9-5e71-454a-9585-abe3e156e0d2" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 11, 34, 40, 662, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 11, 34, 40, 662, DateTimeKind.Local).AddTicks(5828));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ResponseDate",
                table: "Inquiry",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
    }
}
