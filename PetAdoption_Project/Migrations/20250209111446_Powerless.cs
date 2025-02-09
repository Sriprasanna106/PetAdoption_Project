using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class Powerless : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "713ba403-a84c-4a06-8ab9-d2715e3411cb", "AQAAAAIAAYagAAAAECOYw4cpwxHy5rxF3Pr0iFYEi1HMKahyLBUo0jCxovwBXOthPrlg0QpL/GYA9/l8Lw==", "cd58414c-7bd2-4645-a4f0-a026fbc9b893" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 19, 14, 45, 138, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 19, 14, 45, 138, DateTimeKind.Local).AddTicks(1810));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "499a8da5-9828-462e-989c-7376aa5a529d", "AQAAAAIAAYagAAAAEENS3VWCtNwyea9Pul0+FwubpgEFjJGTkuaewN3lirksXYGGjcxzqfaiHRLySP56LQ==", "5dcdd8a6-f574-4858-84e3-bccd70456fb2" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 11, 41, 37, 479, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 11, 41, 37, 479, DateTimeKind.Local).AddTicks(1826));
        }
    }
}
