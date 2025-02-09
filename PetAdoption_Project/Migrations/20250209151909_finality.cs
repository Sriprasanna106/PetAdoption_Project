using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class finality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66a39bdd-5afc-401e-b010-79144b7cb20b", "AQAAAAIAAYagAAAAEJU3dCYFrN3STDtRorc8B9tI9wjEandrNwFIwx/4DJbz8Ae3tI9nPtr2dJ9W/or18A==", "df11b227-6860-4320-bb51-b1a648b8f0d3" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 23, 19, 8, 957, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 23, 19, 8, 957, DateTimeKind.Local).AddTicks(3714));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49c47718-82b9-40e5-82f8-bc01449dec14", "AQAAAAIAAYagAAAAEEebdGg7Pjm8ByoQqHNBoRfBK7kjd2RRMdz1rJTLxZ/wKblp4Q4P9B6P6PHdNEfozw==", "26f85ede-9913-4301-bcd6-0d2c6f8d0d08" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 23, 18, 7, 61, DateTimeKind.Local).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2025, 2, 9, 23, 18, 7, 61, DateTimeKind.Local).AddTicks(1673));
        }
    }
}
