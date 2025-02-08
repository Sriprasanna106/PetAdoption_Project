using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class e : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d73dec0-bab5-4301-a804-b1cb268c63ad", "AQAAAAIAAYagAAAAEPOmA0lPx1zEmlhMtixCLCsl7OcbbvrjDSHJIco+oLby1tKLs8EifQ2oDvJQoUv64A==", "f845bf27-6af8-40d1-a15d-e7e70ff3b92a" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 19, 55, 365, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 19, 55, 365, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 19, 55, 365, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 19, 55, 365, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 19, 55, 365, DateTimeKind.Local).AddTicks(1652));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daa580d6-743f-4190-bb5c-0c111b6e01d7", "AQAAAAIAAYagAAAAEFm1ssBn7GfKoYPdXRRR1eOzF32AF2icogyKAVqdThEXMRE3O3XsI9jIvlPaSyw4oA==", "c92ea493-7ab8-4460-85a0-f1a605f194a3" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 9, 28, 201, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 9, 28, 201, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 9, 28, 201, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 9, 28, 201, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 9, 28, 201, DateTimeKind.Local).AddTicks(6689));
        }
    }
}
