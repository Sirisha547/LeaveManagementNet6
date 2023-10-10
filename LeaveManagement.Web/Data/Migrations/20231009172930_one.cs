using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da222b7a-8967-4dd4-b883-7259a607923b",
                column: "ConcurrencyStamp",
                value: "b6f27521-529a-41c8-b272-1f4b18c35c17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dB222b7a-8967-4dd4-b773-7459a607923b",
                column: "ConcurrencyStamp",
                value: "f8751dbd-99ae-4c14-a193-ce6a09669e77");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8527e-7d97-40e1-8092-4589b809bff0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fad0e2dc-2cc9-4276-ac20-3bff56d1c13d", "AQAAAAEAACcQAAAAEFhpOsUTIc3ctLvfVBv3k9lR/op6ACQzXtQHjNIWz2qKgSMQlPbU2wOtharLiDqpfQ==", "90a3a18f-44ec-46bd-a567-3d9511cea0c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea222b7a-8967-4dd4-b883-7459a607923b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6365d746-a1cc-46f0-8b78-d63b5829e7c0", "AQAAAAEAACcQAAAAEJ+nFLd0p9laxnMaR35W7jj9QfhQen+Nuh3r7QjDqofFBXuiL7YqNeZ7BSrNMjr09A==", "066d09e0-57b9-4258-af51-ba0c0684aeec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
