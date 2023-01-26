using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePharmacy1.Server.Migrations
{
    public partial class StaffSeedingConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "5f4aaf35-73af-473b-bdbe-45be78aa7571");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "61727cd3-1adf-4cba-af24-71de5b37d159");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80092014-65f4-421b-ab7e-c0376572ded3", "AQAAAAEAACcQAAAAEIjVg33bdnU8e4Bkt8M/YqlFWB0QfmfoN6GGXk60iUUnnGGTfZqt02OExqbienaHAQ==", "03c1c090-ca4b-4044-8b48-e593dd8c3318" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffID", "StaffAddress", "StaffContactNo", "StaffEmail", "StaffNRIC", "StaffName" },
                values: new object[,]
                {
                    { 1, "Bedok North Rd Blk 56 #11-902", "89103135", "Lalisa@gmail.com", "S9701923J", "Lisa" },
                    { 2, "Toh Guan Rd Blk 236 #02-651", "93018402", "Paul@gmail.com", "S86019395D", "Paul" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "3c41af48-cf15-40f9-9646-71669253a864");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "fab42ff1-cdb6-4f60-9741-829890e24e1c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a22380bc-c196-48d1-8f8a-1b9685093fb7", "AQAAAAEAACcQAAAAEAuFEgCbRytpEPjTAxEpnaYOCv99bFi6tO9OVqFcXpcGjF82B9ZvRhlXJBZ1OrShag==", "acac4808-bbfc-475a-acf3-f6bd6ae4575f" });
        }
    }
}
