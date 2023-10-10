using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class confirmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
