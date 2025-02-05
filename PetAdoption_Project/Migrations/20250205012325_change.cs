using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetAdoption_Project.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15b34f8c-dc07-492f-a705-7bd38ebe5182", "AQAAAAIAAYagAAAAEDK1OVyl0BAT38EHPGbie1v+GwWtxGYpgw0AXkj39a9U5VXENnJhzwCTAPMcr8/B/Q==", "bfbad7d0-2b3a-4cdb-84b5-58efb6872a96" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrganizationId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4548d5d9-4e64-4bcc-bb55-92ce7fdb6970", "AQAAAAIAAYagAAAAEB8MJeZ3j9DT3lmr7H06VuazEjico0S3iq2o5KWPqgFC9IsFIUPV4E1ZxmDTnPZN6Q==", "596e850d-ab6e-4126-9360-609b79177e32" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrganizationId",
                value: 2);
        }
    }
}
