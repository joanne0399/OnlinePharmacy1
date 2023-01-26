using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePharmacy1.Server.Migrations
{
    public partial class medication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Availability",
                table: "Medications",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "c6b76983-6290-401e-9765-210167ce6290");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "974a3d02-3054-4139-bcb9-350f4080b35b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cbed344-8475-461d-9235-9079d74e06ae", "AQAAAAEAACcQAAAAEF5gfjAULHP9dx4xe3BH2qREefa9G9bbAakFqSH4l4g908r7kAr+d+BAVGrCJht7Iw==", "dc56e83c-7d1c-4304-8569-700f76fc19d2" });

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: 1,
                column: "Availability",
                value: "In stock");

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: 2,
                column: "Availability",
                value: "In stock");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Medications",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: 1,
                column: "Availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: 2,
                column: "Availability",
                value: true);
        }
    }
}
