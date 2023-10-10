using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da222b7a-8967-4dd4-b883-7259a607923b",
                column: "ConcurrencyStamp",
                value: "7a58b259-e223-4f26-b188-9e4d4dbb3c55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dB222b7a-8967-4dd4-b773-7459a607923b",
                column: "ConcurrencyStamp",
                value: "8c5c052b-6e77-41e2-9302-cac91d4c4dab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8527e-7d97-40e1-8092-4589b809bff0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea9a704b-964d-4433-a30d-76d5f83b6d6c", "AQAAAAEAACcQAAAAEA597o3W+GLwyVN4FC+MIOZsKrnXYJBgPE96T/iBbDFb35vc0JoPBGqVPTZgKe1x3Q==", "41a72d97-52df-42ec-9878-4770f347fea0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea222b7a-8967-4dd4-b883-7459a607923b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f498d16d-d5d7-44cb-8154-eff925b83d1c", "AQAAAAEAACcQAAAAEPN/diLqDZMN2+U6Ca4B3m/vAEut2xwQ9ELJCWTizjW/1BJwtLw2D2zi7b7y1OR7QA==", "8b03d187-5467-40e5-b0c8-fe128f95459d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da222b7a-8967-4dd4-b883-7259a607923b",
                column: "ConcurrencyStamp",
                value: "643ac04d-bf86-4e32-8722-338e02caac8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dB222b7a-8967-4dd4-b773-7459a607923b",
                column: "ConcurrencyStamp",
                value: "b27a2734-b63c-4b0a-8dd9-170e52b4fde4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6a8527e-7d97-40e1-8092-4589b809bff0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38686bde-1f50-486d-9146-73aa77cc7b3f", "AQAAAAEAACcQAAAAEElGpZzOksDpmT5hcgKkExL8wtQV2P16KxrHnvulLmEPkHYoeKlRBhGLeA2Vs7E2rQ==", "20067b38-cd47-4757-80e7-bc923f2c5b53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea222b7a-8967-4dd4-b883-7459a607923b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bc1a7ee-a3b8-439c-88ad-b1c93747cf50", "AQAAAAEAACcQAAAAEPkJXDDUv4+/fHDrBF6N+dqI+lw8DsIBRPrl+pbEqJs3yWWfjYFd7Wyl73Lgi+Plkw==", "d4bfc6ac-1639-4e8e-80f5-93546ad1f6e9" });
        }
    }
}
