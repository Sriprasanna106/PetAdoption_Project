using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class srrggre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fc1a11b-c7cf-403d-ba29-ca05b99359a7", "AQAAAAIAAYagAAAAELtCATrRqHzN+QHQ3dSOpf2i5q38ObcA2jIHUhHJYp1718EjkeRIKLYgo+O6hAFbBw==", "e44936ee-a34c-4bc8-9863-03b25a0b6ea0" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 23, 0, 5, 458, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 23, 0, 5, 458, DateTimeKind.Local).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 23, 0, 5, 458, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 23, 0, 5, 458, DateTimeKind.Local).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 23, 0, 5, 458, DateTimeKind.Local).AddTicks(1265));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
