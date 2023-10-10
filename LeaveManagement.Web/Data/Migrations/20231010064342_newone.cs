using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class newone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DefaultDays",
                table: "leaveAllocations",
                newName: "DefaultsDays");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a6a43bd8-14f4-4e8c-8063-0941561fb6b2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "bccb1e7a-9508-45ab-94f7-cbc6a35d4ef7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7252246-16f5-4ce0-8a9d-812f3f7bf2fa", "AQAAAAEAACcQAAAAEEsB4L2l5+DQ5KQxqDPVu1i0oA2xS3HFClPCbkVbtewOj/tS38KgFgfu44wQumBgTQ==", "3cd365d8-251d-437e-8bf1-2a47cd1378a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5b2ea9a-1d86-41da-bce5-619b91842c34", "AQAAAAEAACcQAAAAEN3b29LQHtoG66CiLHVF65q8V5fxi7OYYt0GpK7oIbbTdnBxdA+i/9MZf3iNiubjSQ==", "8fa482d2-2833-4a58-84cf-91d1006f758e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DefaultsDays",
                table: "leaveAllocations",
                newName: "DefaultDays");

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
    }
}
