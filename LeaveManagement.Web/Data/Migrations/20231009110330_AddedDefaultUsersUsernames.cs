using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da222b7a-8967-4dd4-b883-7259a607923b",
                column: "ConcurrencyStamp",
                value: "d871403f-9e07-4dde-89a7-5bea01098dde");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dB222b7a-8967-4dd4-b773-7459a607923b",
                column: "ConcurrencyStamp",
                value: "2db6f534-3fd7-4ad8-adda-8d56dc3be94c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8527e-7d97-40e1-8092-4589b809bff0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2f5f216e-0b6f-4099-9080-94a0d9953cf1", true, "USER1@GMAIL.COM", "AQAAAAEAACcQAAAAENtZU0HrOdI1HWW8OWPxnPvyB8X4Ez8/wXFokYWDKt9AOcPq33g4XniEfVxzW9TmzA==", "d3f18bbe-ee31-4b1c-b02e-a9e25697971a", "user1@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea222b7a-8967-4dd4-b883-7459a607923b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e2117316-00e7-42be-911e-e8678395864d", true, "ADMIN1@GMAIL.COM", "AQAAAAEAACcQAAAAEJ2yP0R7Zmbx4GK7aqG9YLvBwC2LS1vRzc9F1jQP8xyXpp5lAbAByUarPEphcKstMg==", "e81e9317-7aa2-4839-b5c4-afb9c85dbee4", "admin1@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da222b7a-8967-4dd4-b883-7259a607923b",
                column: "ConcurrencyStamp",
                value: "d7bf81e5-c9cf-4e26-8857-5a5c598158ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dB222b7a-8967-4dd4-b773-7459a607923b",
                column: "ConcurrencyStamp",
                value: "b056d1dc-5782-483d-93c5-6d12a8614921");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8527e-7d97-40e1-8092-4589b809bff0",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "57f18bde-c4a0-4506-a26d-0b088785d8b8", false, null, "AQAAAAEAACcQAAAAEB6QmYThUnG/q2ZDfej6/63BCYhxz8AQURz1IU79jlsIyRfGtRZRKPmQz1gf2FtefQ==", "b271d80f-0969-40fb-842b-cd376a0a39b6", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea222b7a-8967-4dd4-b883-7459a607923b",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "33fa0aec-05e6-47de-8264-bff140445aca", false, null, "AQAAAAEAACcQAAAAEHXy6Mm7QltOb3+t0mBJfjXNlPJzGoR1niR+Evp1srmknU4xuAFCzEDYVjogky8sHw==", "79ed86be-5895-44b8-b1e9-1ced2ecf81f0", null });
        }
    }
}
