using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "leaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "7b96ff5c-a5fa-4fe3-aae4-75f428b232b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "5c9dde5b-2d2b-4d68-962c-9bce0435fe81");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6d9c87e-1451-4140-b502-8e35f613cafb", "AQAAAAEAACcQAAAAEDzBt3KiDAIk3N8bt57zgXs0Ra9ThRJ91nSGQHFCeQdjg6lAnX0FO6ojL76e3OiS1w==", "48e7f818-74b3-444c-9619-82e1c6f62770" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "724486c6-1759-48f7-b21c-99c83c6036a9", "AQAAAAEAACcQAAAAENC2ugv5PjspFIe4eWaVhS9McI7fZdDAYyoon0TRESCgifK87t0KH3Id9mhCiykWeA==", "dbe69ac3-266f-4d03-bd72-7d3b21b7271a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "leaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0512709e-0ebc-41de-99a2-3c6ef34ff266");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "503e54ed-621d-4eab-97fd-e88811d3ded7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b7b41bd-eae7-49bf-b589-e4591e979605", "AQAAAAEAACcQAAAAEHz2t9pSU9+x6feN4WV5FwSXaOJdYvWUU9WuOcMgbS4DOWZ1uPLCWDF/TAjsHDSnhQ==", "b71ccc50-234d-4ba2-a241-c7fbc0fea4b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a4017a8-6f61-4c86-a6e8-b2f202567982", "AQAAAAEAACcQAAAAELZELLMbOylOjsGZ88wWXY7dpHahtnG6h05tQ/9QreXLXUMW0fD2YQ+0AjvCvZhVjw==", "3605e8a5-1a5c-4391-b94f-84292cc0831b" });
        }
    }
}
