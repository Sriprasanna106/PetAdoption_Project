using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class pet_adoption_status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdopted",
                table: "Pet",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "DateUpdated", "IsAdopted" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 3, 46, 884, DateTimeKind.Local).AddTicks(3657), false });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateUpdated", "IsAdopted" },
                values: new object[] { new DateTime(2025, 2, 8, 22, 3, 46, 884, DateTimeKind.Local).AddTicks(3660), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdopted",
                table: "Pet");

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
    }
}
