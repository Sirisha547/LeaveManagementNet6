using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da222b7a-8967-4dd4-b883-7259a607923b",
                column: "ConcurrencyStamp",
                value: "d8478810-30b9-4eac-ac2e-53a214ea2918");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dB222b7a-8967-4dd4-b773-7459a607923b",
                column: "ConcurrencyStamp",
                value: "39946db1-64e1-4003-9854-7c6494483a7d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8527e-7d97-40e1-8092-4589b809bff0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eeee2218-1923-46a7-82e4-57b283ffeb30", "AQAAAAEAACcQAAAAECDSoW6ZIpuzkslhtfsxyd3GfyYNPtFA8rC0QAP8MyltLcM4TX1RxkaeWsWikANCJw==", "45dfac69-6de2-4bbf-9d21-0bb5cda6d6d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea222b7a-8967-4dd4-b883-7459a607923b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50de7782-6073-4ac9-a2eb-c1917a2af7a3", "AQAAAAEAACcQAAAAEIHaxGa0on4hChovaScSTR+1gZeNY4eWaRaRD07YPpZvWuMmg6rDMx/J1rfIBQxKxA==", "47ca2201-4ef0-4f6e-9ed9-bf3eb486db26" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f5f216e-0b6f-4099-9080-94a0d9953cf1", "AQAAAAEAACcQAAAAENtZU0HrOdI1HWW8OWPxnPvyB8X4Ez8/wXFokYWDKt9AOcPq33g4XniEfVxzW9TmzA==", "d3f18bbe-ee31-4b1c-b02e-a9e25697971a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea222b7a-8967-4dd4-b883-7459a607923b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2117316-00e7-42be-911e-e8678395864d", "AQAAAAEAACcQAAAAEJ2yP0R7Zmbx4GK7aqG9YLvBwC2LS1vRzc9F1jQP8xyXpp5lAbAByUarPEphcKstMg==", "e81e9317-7aa2-4839-b5c4-afb9c85dbee4" });
        }
    }
}
