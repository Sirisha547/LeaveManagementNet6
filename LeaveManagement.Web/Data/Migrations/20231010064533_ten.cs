using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class ten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
