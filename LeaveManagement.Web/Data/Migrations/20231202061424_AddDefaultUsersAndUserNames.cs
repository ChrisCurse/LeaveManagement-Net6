using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddDefaultUsersAndUserNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1e2225c-d7bd-9e93-9601-60d5a816375b",
                column: "ConcurrencyStamp",
                value: "234d8701-81aa-4691-871b-3a120f9d10fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f1115c-d7cd-8e83-9501-20d5a516275b",
                column: "ConcurrencyStamp",
                value: "c62a469d-6126-41c4-8cb9-72d341dc0736");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c1115c-d7cb-4e43-9501-19d5a312215d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "249f124f-cf13-420d-aebc-60a45ed3c02c", true, "CHRIS_CURSE@OUTLOOK.COM", "AQAAAAEAACcQAAAAEOWTg7F/FUPnXtJoFmZGt9vlTsO6girOdi3/HREz3es0XsVKjm5enXeADgI0st9z9A==", "8b3d76a2-6b02-4d64-9310-c95103099a11", "chris_curse@outlook.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfba3c53-b419-4120-86cc-8d7d44e22fbd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "93e32ddd-2d8f-46c4-9b3a-890aeb7540d0", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAECXCWFzz2hIWdXhOuOgVwcqrwSPxlLU09CPw/yDqW6A3mUNVSFDyVAe+TkoZ3L5IYg==", "758ce7a3-9fa2-4759-ad9a-b99a2c4175de", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1e2225c-d7bd-9e93-9601-60d5a816375b",
                column: "ConcurrencyStamp",
                value: "1ac341ef-2328-45ae-bd80-8ba38d83f718");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f1115c-d7cd-8e83-9501-20d5a516275b",
                column: "ConcurrencyStamp",
                value: "4465fea1-2df5-4f23-aaab-d9660ef193e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c1115c-d7cb-4e43-9501-19d5a312215d",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e24c7814-391f-407e-a207-cd7327d6806c", false, null, "AQAAAAEAACcQAAAAEEwKO9JMGTtlO5rAuSiCpazw37eusQStOGXMeijkuQBgn7dV7jVNPVKyht2EZ3/MNg==", "25e41cec-f6b2-460c-b293-f576b0dd01c1", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfba3c53-b419-4120-86cc-8d7d44e22fbd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e48839fb-8033-477d-9a97-16b4b824aba4", false, null, "AQAAAAEAACcQAAAAEChdC3DAP++S0p7KafwLYpIHgZX1YTzmjFWTVk9kuLo+iPWV8qFPqFy3RLN4Z+YO7g==", "72c3df0a-bcde-4526-8c31-c322bdff3f75", null });
        }
    }
}
