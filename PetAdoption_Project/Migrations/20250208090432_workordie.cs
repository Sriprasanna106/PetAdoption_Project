using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class workordie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Organization");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Inquiry");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Donation");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "DateCreated",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Pet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Organization",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Inquiry",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Donation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Branch",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a59876d-0e01-4ba2-99f6-51b75e34d867", "AQAAAAIAAYagAAAAEI+yN+IGPNedfvt+RHWUwRt2Kwg+/TNMEPMphi9J/2fJtVmn/OWUyBGfG+PQQsf6bA==", "ede19e7f-7d2a-454d-bf1f-4b26b4fed1fe" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OrganizationId" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 22, 38, 1, DateTimeKind.Local).AddTicks(2825), new DateTime(2025, 2, 8, 16, 22, 38, 1, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 22, 38, 1, DateTimeKind.Local).AddTicks(2829), new DateTime(2025, 2, 8, 16, 22, 38, 1, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 22, 38, 1, DateTimeKind.Local).AddTicks(2652), new DateTime(2025, 2, 8, 16, 22, 38, 1, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 22, 38, 1, DateTimeKind.Local).AddTicks(2983), new DateTime(2025, 2, 8, 16, 22, 38, 1, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 22, 38, 1, DateTimeKind.Local).AddTicks(2988), new DateTime(2025, 2, 8, 16, 22, 38, 1, DateTimeKind.Local).AddTicks(2988) });
        }
    }
}
