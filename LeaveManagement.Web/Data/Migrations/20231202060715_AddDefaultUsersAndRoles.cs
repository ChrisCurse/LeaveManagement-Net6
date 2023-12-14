using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d1e2225c-d7bd-9e93-9601-60d5a816375b", "1ac341ef-2328-45ae-bd80-8ba38d83f718", "User", "USER" },
                    { "d1f1115c-d7cd-8e83-9501-20d5a516275b", "4465fea1-2df5-4f23-aaab-d9660ef193e7", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b1c1115c-d7cb-4e43-9501-19d5a312215d", 0, "e24c7814-391f-407e-a207-cd7327d6806c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chris_curse@outlook.com", false, "Chris", "Curse", false, null, "CHRIS_CURSE@OUTLOOK.COM", null, "AQAAAAEAACcQAAAAEEwKO9JMGTtlO5rAuSiCpazw37eusQStOGXMeijkuQBgn7dV7jVNPVKyht2EZ3/MNg==", null, false, "25e41cec-f6b2-460c-b293-f576b0dd01c1", null, false, null },
                    { "dfba3c53-b419-4120-86cc-8d7d44e22fbd", 0, "e48839fb-8033-477d-9a97-16b4b824aba4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "admin", "admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEChdC3DAP++S0p7KafwLYpIHgZX1YTzmjFWTVk9kuLo+iPWV8qFPqFy3RLN4Z+YO7g==", null, false, "72c3df0a-bcde-4526-8c31-c322bdff3f75", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d1e2225c-d7bd-9e93-9601-60d5a816375b", "b1c1115c-d7cb-4e43-9501-19d5a312215d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d1f1115c-d7cd-8e83-9501-20d5a516275b", "dfba3c53-b419-4120-86cc-8d7d44e22fbd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1e2225c-d7bd-9e93-9601-60d5a816375b", "b1c1115c-d7cb-4e43-9501-19d5a312215d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d1f1115c-d7cd-8e83-9501-20d5a516275b", "dfba3c53-b419-4120-86cc-8d7d44e22fbd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1e2225c-d7bd-9e93-9601-60d5a816375b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f1115c-d7cd-8e83-9501-20d5a516275b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c1115c-d7cb-4e43-9501-19d5a312215d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfba3c53-b419-4120-86cc-8d7d44e22fbd");

            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
