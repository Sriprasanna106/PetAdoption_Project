using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class cthugha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Organization");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Inquiry");

            migrationBuilder.AddColumn<bool>(
                name: "IsAnswered",
                table: "Inquiry",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0077b8a2-2ef5-402a-82d5-b851c7a1a534", "AQAAAAIAAYagAAAAEElvK8fPHHgzUB+9qHUrCwzBSaCi9wsr1gcpZ8+mm4flQl4qRoMVj8ZWOzLLdW/3Pw==", "7f530a96-cbb2-432c-8eb9-ebabc3e651c6" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 11, 22, 56, 292, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 11, 22, 56, 292, DateTimeKind.Local).AddTicks(3295));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAnswered",
                table: "Inquiry");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Inquiry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organization",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organization", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fc1a11b-c7cf-403d-ba29-ca05b99359a7", "AQAAAAIAAYagAAAAELtCATrRqHzN+QHQ3dSOpf2i5q38ObcA2jIHUhHJYp1718EjkeRIKLYgo+O6hAFbBw==", "e44936ee-a34c-4bc8-9863-03b25a0b6ea0" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Address", "ContactNumber", "CreatedBy", "DateUpdated", "Email", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Lenovo Street 45", "94656485", "System", new DateTime(2025, 2, 8, 23, 0, 5, 458, DateTimeKind.Local).AddTicks(1131), "NumberOneCrate@gmail.com", "JohnPork", "System" },
                    { 2, "HP Street 216", "86364294", "System", new DateTime(2025, 2, 8, 23, 0, 5, 458, DateTimeKind.Local).AddTicks(1134), "NumberTwoPhone@gmail.com", "Xodus", "System" }
                });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "Id", "Address", "CreatedBy", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 1, "977 Grove Street", "System", new DateTime(2025, 2, 8, 23, 0, 5, 458, DateTimeKind.Local).AddTicks(963), "HYV Animal Centre", "System" });

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
    }
}
