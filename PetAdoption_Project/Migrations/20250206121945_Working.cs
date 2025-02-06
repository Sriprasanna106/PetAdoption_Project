using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class Working : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2739), new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2739), "System" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2745), new DateTime(2025, 2, 6, 20, 19, 44, 709, DateTimeKind.Local).AddTicks(2745), "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40df73d6-bb5b-4130-9fc0-e63c7980000e", "AQAAAAIAAYagAAAAEOdJ5J1An/4JoeE3RLDORa6rh8zUGasX6WLMpmItKYYDEZ9vOR2O8ojlTh8UEn1Mig==", "e093b597-99cd-4585-870e-7f5b6f430a49" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}
