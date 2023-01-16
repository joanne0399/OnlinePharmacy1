using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePharmacy1.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "b43486eb-e145-4718-ac62-bc380b2c827e", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "0221d100-0f3d-41f0-9c39-b18263b8c870", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "52fad078-d5c3-41f8-9f36-e47c3ef83580", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEGSuvfBCNqGCS5cdNCC8ccg63uSlBZzEQJBfixT05oOZqD4gh8xFv552iFT6Kto0Jw==", null, false, "0a0b8ed7-cd4e-47ca-92fa-7ab2b5418561", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "CustomerAddress", "CustomerContactNo", "CustomerDOB", "CustomerEmail", "CustomerNRIC", "CustomerName" },
                values: new object[,]
                {
                    { 1, "Bedok North Rd Blk 428 #09-387", "90818473", "15 January 1995", "Jennieninini@gmail.com", "S9523810J", "Jennie" },
                    { 2, "Sin Ming Ave Blk 76 #14-902", "98017489", "23 November 1999", "Jayjj@gmail.com", "S9901807D", "Jay" }
                });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "MedicationID", "Availability", "Description", "Ingredients", "MedicationName", "RecommendedDosage" },
                values: new object[,]
                {
                    { 1, true, "Treat mild to moderate pain (from headaches, menstrual periods, toothaches, backaches, osteoarthritis, or cold/flu aches and pains) and to reduce fever", "500 mg of paracetamol", "Panadol", "Take 1-2 tablets every 4-6 hours as required" },
                    { 2, true, "Relieves coughing, soothes sore throat, loosens phlegm and expels mucus", "Guaiphenesin, Benzoic Acid", "Woods Peppermint Adult Cough Syrup", "Adults and children (12 years and over): 2 teaspoons (10ml), to be taken every 4 hours as prescribed by a healthcare professional" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
