using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class fshsgsg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrganizationId",
                table: "Pet",
                newName: "BranchId");

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
                columns: new[] { "BranchId", "DateUpdated" },
                values: new object[] { 1, new DateTime(2025, 2, 9, 11, 41, 37, 479, DateTimeKind.Local).AddTicks(1826) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Pet",
                newName: "OrganizationId");

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
                columns: new[] { "DateUpdated", "OrganizationId" },
                values: new object[] { new DateTime(2025, 2, 9, 11, 34, 40, 662, DateTimeKind.Local).AddTicks(5828), 0 });
        }
    }
}
