using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class nine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "175ca25e-4ac7-4853-9993-a1dd4c68db5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "c942efaa-123e-4d0b-b369-d3765a0b975a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd815d78-b998-4181-98b4-3294be0d4121", "AQAAAAEAACcQAAAAEMISBNV9nfFpOYMlbwr98eucIOD8sAhM46vYH1CSZwjd1LKpvyw9dbbkdpStAUBtWw==", "8a4a5ec0-5bc3-4797-a9f3-8509c6266709" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f24249f7-f87b-4274-80dc-53642f208edf", "AQAAAAEAACcQAAAAEI2zJ3riq4/8czkT1RsT8bSP0CxCowogLqSh+6B5Hv6D/ezBnPuLBPDGpwf4s+JmaA==", "f5e7d799-7177-4040-a3d9-6b720a8517b5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "7e32271f-fe17-4600-8bb4-c99d51b46e28");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "c9bf989d-5cc3-4671-81dd-c8974dfb957d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "197d79af-8b30-4c27-a722-2d127846e687", "AQAAAAEAACcQAAAAEOmkR81uPU9CN8OlP++QyEIJvLuWW1zNYSr+l2weY3um+x5/G+HTn0X9rbS1UP9Y1w==", "cc2b78fd-9a67-41ae-b36a-72cdab806bc9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71b63aca-85cc-438a-b40b-5cf92035c1c6", "AQAAAAEAACcQAAAAEP7qe7ah2001tvhtsHaak/2apOmo2fVeCiUkOOvs3wC1uOEzcL5yKA22nZEHrxx7yg==", "6bd35fe1-0ac7-4c22-8df5-1b1e08d2c702" });
        }
    }
}
