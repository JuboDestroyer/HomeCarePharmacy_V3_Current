using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeCarePharmacy_V3.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd2bcf0c-20db-474f-8407-5a6b159518bc", null, "Customer", "CUSTOMER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12462149-02a0-40d4-95ad-c2cef7682b7a", "AQAAAAIAAYagAAAAEH5b55nfOnPfkLswmlUhmhPybGyHVk/9T+BvZ+aiKeLWGo6R/j71vVR39MZu1RU//A==", "0e756c8f-4552-48a5-871a-4f476965303e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e0329061-f159-44eb-9352-231f75bf27a6", 0, "cf1af683-716e-4339-8d27-7ca97a01345d", "user@blazor.com", false, "User", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEI0ZZ308wwFZNWgH1L0Le9LCmhP+DOpwgpo49+ZXej358ZInIs5qp3JsL4UTlz6E8w==", null, false, "cef9ea2f-cbb1-4eae-9bc6-6d6d869f3061", false, "user@blazor.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "e0329061-f159-44eb-9352-231f75bf27a6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd2bcf0c-20db-474f-8407-5a6b159518bc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "e0329061-f159-44eb-9352-231f75bf27a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0329061-f159-44eb-9352-231f75bf27a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "488fcb3e-a9bf-4079-83d0-90c7a658ebd5", "AQAAAAIAAYagAAAAEOqYtP9e9/Tu8FxO2lp4ZnXaxAXpHJPbG9Sr5UJtXtE/jmN/NWtXIbNzxDqpoy+Nww==", "0cdd7a60-7225-4020-af90-209a9a0bba7e" });
        }
    }
}
