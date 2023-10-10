using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_leaveAllocations_leaveTypes_LeaveTypeId",
                table: "leaveAllocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_leaveAllocations",
                table: "leaveAllocations");

            migrationBuilder.RenameTable(
                name: "leaveAllocations",
                newName: "LeaveAllocations");

            migrationBuilder.RenameIndex(
                name: "IX_leaveAllocations_LeaveTypeId",
                table: "LeaveAllocations",
                newName: "IX_LeaveAllocations_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveAllocations",
                table: "LeaveAllocations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_leaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "leaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_leaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "leaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_leaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveAllocations",
                table: "LeaveAllocations");

            migrationBuilder.RenameTable(
                name: "LeaveAllocations",
                newName: "leaveAllocations");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "leaveAllocations",
                newName: "IX_leaveAllocations_LeaveTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_leaveAllocations",
                table: "leaveAllocations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "aa528b68-d4cd-4f66-96b0-96960bde041d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "df421773-d161-4192-a14c-49456022e225");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6369d168-1ac6-4115-ba0d-3dccd981f7bb", "AQAAAAEAACcQAAAAEJSrXnBEmQIMFZHvBdIDKy6qcn3oQgnJE28SqT4oCO4UOi4uHHOP5ideN7plUi2Sng==", "86e90a9a-2115-4ad5-a047-458c96c167a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55685443-aafd-410f-a860-19b4c62090e2", "AQAAAAEAACcQAAAAEJc5g0ktRG4d+l+iNm7jysxLMJW/uuoCJzwvftrmTAyIEHN2JstFB7JjHZMsC2GFGw==", "b6084b91-b6c3-4aa9-b7a8-90bb4ff4a633" });

            migrationBuilder.AddForeignKey(
                name: "FK_leaveAllocations_leaveTypes_LeaveTypeId",
                table: "leaveAllocations",
                column: "LeaveTypeId",
                principalTable: "leaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
