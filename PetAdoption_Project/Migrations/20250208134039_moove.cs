using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class moove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56af10a1-a6dc-471c-b89e-d6515e808dcc", "AQAAAAIAAYagAAAAEE7L4B3e8hYp5yA7AOcBOhcEoaxUhi3WVg3pX/2Djhpjcuk7j/4YVTS9CpcY92ZMLg==", "49a0d348-3f7a-4eb6-8f32-55f9d20188c2" });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 21, 40, 38, 189, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 21, 40, 38, 189, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 21, 40, 38, 189, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 21, 40, 38, 189, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 8, 21, 40, 38, 189, DateTimeKind.Local).AddTicks(2610));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
