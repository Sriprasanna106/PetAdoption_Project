using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class NewUPDATE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Colour",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Breed",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Pet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "Pet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "Name", "OrganizationId", "UpdatedBy" },
                values: new object[] { 1, "Street 54, Ave 5, 120987", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tampines", 2, "System" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "ContactNumber", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Lenovo Street 45", "94656485", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NumberOneCrate@gmail.com", "JohnPork", "System" },
                    { 2, "HP Street 216", "86364294", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NumberTwoPhone@gmail.com", "Xodus", "System" }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 1, "977 Grove Street", "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HYV Animal Centre", "System" });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "Id", "Age", "Breed", "Colour", "CreatedBy", "DateCreated", "DateUpdated", "Gender", "Name", "OrganizationId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 5, "Dog", "White", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unspecified", "Kohaku", 2, null },
                    { 2, 1, "Monitor Lizard", "Brown", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "Bean", 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Organization",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "Pet");

            migrationBuilder.AlterColumn<int>(
                name: "Colour",
                table: "Pet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Breed",
                table: "Pet",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "CreatedBy", "CustomerId", "DateCreated", "DateIn", "DateOut", "DateUpdated", "PetId", "UpdatedBy" },
                values: new object[] { 1, "System", 1, new DateTime(2025, 1, 31, 14, 19, 28, 312, DateTimeKind.Local).AddTicks(1074), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 31, 14, 19, 28, 312, DateTimeKind.Local).AddTicks(1091), 1, "System" });
        }
    }
}
