using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class myside : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4548d5d9-4e64-4bcc-bb55-92ce7fdb6970", "AQAAAAIAAYagAAAAEB8MJeZ3j9DT3lmr7H06VuazEjico0S3iq2o5KWPqgFC9IsFIUPV4E1ZxmDTnPZN6Q==", "596e850d-ab6e-4126-9360-609b79177e32" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "354d4bf7-8ff0-42cb-a5e4-e7cedc5b27d1", "AQAAAAIAAYagAAAAEOThJQPS6+cYECNUPifqqj34Lre02kL3Lv5RZDvfIpgOEG7tBMyzQ9mHnpre5TVSLA==", "ef66d991-e9ae-44b1-8be3-b55eee6eb921" });
        }
    }
}
