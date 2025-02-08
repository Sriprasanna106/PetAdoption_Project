using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class appointmentupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOut",
                table: "Appointment",
                newName: "AppointmentDate");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a59876d-0e01-4ba2-99f6-51b75e34d867", "AQAAAAIAAYagAAAAEI+yN+IGPNedfvt+RHWUwRt2Kwg+/TNMEPMphi9J/2fJtVmn/OWUyBGfG+PQQsf6bA==", "ede19e7f-7d2a-454d-bf1f-4b26b4fed1fe" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "Appointment",
                newName: "DateOut");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b7d8edb-a4ba-48fe-98fb-da60c70e2073", "AQAAAAIAAYagAAAAEHzj+ou7zoqjmy1BIDzqICuYBdZY7WPrZmBt67GkexFfVfJQ/YS2AWlcTlCsDtw7Vw==", "aa659417-16b8-47c6-8cf7-6b334d00c8fc" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2566), new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2570), new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2419), new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2739), new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2745), new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2745) });
        }
    }
}
