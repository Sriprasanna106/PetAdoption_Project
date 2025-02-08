using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class move : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PetName",
                table: "Appointment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5f79f98-be34-4260-94c8-9009087a1a87", "AQAAAAIAAYagAAAAEJgKamT2E6lHkxfp0bz7wt9FVmGBlwbI2U17PqTYLBMmH9laDcV6rDDBlJKfh50idw==", "b0a3560d-1819-4111-a700-50e4c67ddfa4" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 21, 39, 2, 690, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 21, 39, 2, 690, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 21, 39, 2, 690, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 21, 39, 2, 690, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 21, 39, 2, 690, DateTimeKind.Local).AddTicks(2430));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PetName",
                table: "Appointment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5f07829-6e82-43f0-9077-bf273f064b66", "AQAAAAIAAYagAAAAEORoSDjijxpMRVMBdgFDlmEYUE6SOXTtKDFYKCo5S2dpUBGY5Rtxod0EtM1rNw8adQ==", "5c3d2cdb-0884-42ad-8b95-a9ba9c48b3b7" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 17, 4, 30, 983, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 17, 4, 30, 983, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 17, 4, 30, 983, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 17, 4, 30, 983, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 17, 4, 30, 983, DateTimeKind.Local).AddTicks(3427));
        }
    }
}
