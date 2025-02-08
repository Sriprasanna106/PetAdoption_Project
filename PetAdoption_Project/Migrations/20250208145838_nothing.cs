using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class nothing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdcf59f6-a196-4cfc-bfe6-da6ee4dc0dae", "AQAAAAIAAYagAAAAELgbKtN83MrAHgsiwH1HijboeC7MeZHDBm+zee6WGARiHEZmqxX2dzHhbQc78CRVDg==", "a06f2243-676f-4d06-878b-1d3e7f947b48" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 58, 37, 182, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 58, 37, 182, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 58, 37, 182, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 58, 37, 182, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 22, 58, 37, 182, DateTimeKind.Local).AddTicks(5066));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
