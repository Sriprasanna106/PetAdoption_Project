using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class finaltestimonials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
