using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePharmacy1.Server.Data.Migrations
{
    public partial class SSC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "ee437c81-1996-4d2f-bb6e-2fad4afb93e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "540e6273-7f4e-4a26-9148-0b58269d2eeb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54776859-4e77-44a9-9b94-5538e25c8e53", "AQAAAAEAACcQAAAAEA1loyieiJ766RGP3ZoPyzV4X7qaIm9NwrESQiaJPu3cKu+uMcr3pm/CMaX2mKS83w==", "e33a9fae-2245-48db-823c-740913ce2c94" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "StaffID", "StaffAddress", "StaffContactNo", "StaffEmail", "StaffNRIC", "StaffName" },
                values: new object[,]
                {
                    { 1, "Bedok North Rd Blk 56 #11-902", "89103135", "Lalisa@gmail.com", "S9701923J", "Lisa" },
                    { 2, "Toh Guan Rd Blk 236 #02-651", "93018402", "Paul@gmail.com", "S86019395D", "Paul" },
                    { 3, "Toh Guan Rd Blk 237 #02-651", "93018403", "Pauline@gmail.com", "S87019395D", "Pauline" }
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

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "StaffID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "0ac8a917-ef64-49b6-9e8a-f71284e886c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "da4bb557-1a89-424c-9e78-60a5facb5bf7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "859d0e25-88c5-48b7-a55d-949ab5932eb2", "AQAAAAEAACcQAAAAEEyKUUmRUh7KthOgfZl61fLAw8dAGHMOXQ9BQIIDDv5hXzDqqrmHFmrUFnT/nbzzVQ==", "80b8e36c-5e5b-4d1f-85e9-fc01624730e0" });
        }
    }
}
