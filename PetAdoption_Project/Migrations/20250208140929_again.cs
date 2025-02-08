using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "871a9b22-7789-4700-9e4d-bb11a6ab708d", "AQAAAAIAAYagAAAAECsbfTzew78I2wWV1lgtDRC8o8zKqp2XLZIMh69qvvwGB0+GiurCRK1BNrhLadmJZQ==", "6349f1b2-66cb-4bde-9c1b-2d71c50d5dfd" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 3, 46, 884, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 3, 46, 884, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 3, 46, 884, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 3, 46, 884, DateTimeKind.Local).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 3, 46, 884, DateTimeKind.Local).AddTicks(3660));
        }
    }
}
