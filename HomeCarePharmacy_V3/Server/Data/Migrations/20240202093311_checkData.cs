using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeCarePharmacy_V3.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class checkData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "488fcb3e-a9bf-4079-83d0-90c7a658ebd5", "AQAAAAIAAYagAAAAEOqYtP9e9/Tu8FxO2lp4ZnXaxAXpHJPbG9Sr5UJtXtE/jmN/NWtXIbNzxDqpoy+Nww==", "0cdd7a60-7225-4020-af90-209a9a0bba7e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b42ac7c-bb17-4a76-a8d6-493eec8156db", "AQAAAAIAAYagAAAAEP57tHh9pIQ378uwu06aKD1ni458h50zx/i5ReTx9JW0m5o1xkkaX+CPhpIXdHHtPA==", "e5b3efe4-bc9f-4699-9455-fcfe167dd301" });
        }
    }
}
