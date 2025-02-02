using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSiri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Age");

            migrationBuilder.DropTable(
                name: "Breed");

            migrationBuilder.DropTable(
                name: "Colour");

            migrationBuilder.RenameColumn(
                name: "ColourId",
                table: "Pet",
                newName: "Colour");

            migrationBuilder.RenameColumn(
                name: "BreedId",
                table: "Pet",
                newName: "Breed");

            migrationBuilder.RenameColumn(
                name: "AgeId",
                table: "Pet",
                newName: "Age");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "Id", "CreatedBy", "CustomerId", "DateCreated", "DateIn", "DateOut", "DateUpdated", "PetId", "UpdatedBy" },
                values: new object[] { 1, "System", 1, new DateTime(2025, 1, 31, 14, 19, 28, 312, DateTimeKind.Local).AddTicks(1074), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 31, 14, 19, 28, 312, DateTimeKind.Local).AddTicks(1091), 1, "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Colour",
                table: "Pet",
                newName: "ColourId");

            migrationBuilder.RenameColumn(
                name: "Breed",
                table: "Pet",
                newName: "BreedId");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Pet",
                newName: "AgeId");

            migrationBuilder.CreateTable(
                name: "Age",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Age", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Breed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    colour = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colour", x => x.Id);
                });
        }
    }
}
