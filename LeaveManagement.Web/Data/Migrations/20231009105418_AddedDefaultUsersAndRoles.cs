using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "da222b7a-8967-4dd4-b883-7259a607923b", "d7bf81e5-c9cf-4e26-8857-5a5c598158ec", "Administrator", "ADMINISTRATOR" },
                    { "dB222b7a-8967-4dd4-b773-7459a607923b", "b056d1dc-5782-483d-93c5-6d12a8614921", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e6a8527e-7d97-40e1-8092-4589b809bff0", 0, "57f18bde-c4a0-4506-a26d-0b088785d8b8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@gmail.com", false, "System", "User", false, null, "USER1@GMAIL.COM", null, "AQAAAAEAACcQAAAAEB6QmYThUnG/q2ZDfej6/63BCYhxz8AQURz1IU79jlsIyRfGtRZRKPmQz1gf2FtefQ==", null, false, "b271d80f-0969-40fb-842b-cd376a0a39b6", null, false, null },
                    { "ea222b7a-8967-4dd4-b883-7459a607923b", 0, "33fa0aec-05e6-47de-8264-bff140445aca", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1@gmail.com", false, "System", "Admin", false, null, "ADMIN1@GMAIL.COM", null, "AQAAAAEAACcQAAAAEHXy6Mm7QltOb3+t0mBJfjXNlPJzGoR1niR+Evp1srmknU4xuAFCzEDYVjogky8sHw==", null, false, "79ed86be-5895-44b8-b1e9-1ced2ecf81f0", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dB222b7a-8967-4dd4-b773-7459a607923b", "e6a8527e-7d97-40e1-8092-4589b809bff0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "da222b7a-8967-4dd4-b883-7259a607923b", "ea222b7a-8967-4dd4-b883-7459a607923b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dB222b7a-8967-4dd4-b773-7459a607923b", "e6a8527e-7d97-40e1-8092-4589b809bff0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da222b7a-8967-4dd4-b883-7259a607923b", "ea222b7a-8967-4dd4-b883-7459a607923b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da222b7a-8967-4dd4-b883-7259a607923b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dB222b7a-8967-4dd4-b773-7459a607923b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8527e-7d97-40e1-8092-4589b809bff0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea222b7a-8967-4dd4-b883-7459a607923b");
        }
    }
}
