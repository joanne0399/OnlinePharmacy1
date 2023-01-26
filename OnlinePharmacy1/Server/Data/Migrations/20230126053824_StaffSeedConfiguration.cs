using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePharmacy1.Server.Data.Migrations
{
    public partial class StaffSeedConfiguration : Migration
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
                value: "b43486eb-e145-4718-ac62-bc380b2c827e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "0221d100-0f3d-41f0-9c39-b18263b8c870");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52fad078-d5c3-41f8-9f36-e47c3ef83580", "AQAAAAEAACcQAAAAEGSuvfBCNqGCS5cdNCC8ccg63uSlBZzEQJBfixT05oOZqD4gh8xFv552iFT6Kto0Jw==", "0a0b8ed7-cd4e-47ca-92fa-7ab2b5418561" });

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
