using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1e2225c-d7bd-9e93-9601-60d5a816375b",
                column: "ConcurrencyStamp",
                value: "706e0834-f0e4-41f6-8785-335e25360b63");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f1115c-d7cd-8e83-9501-20d5a516275b",
                column: "ConcurrencyStamp",
                value: "a41656cc-a593-4886-b250-1cac6ba35b56");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c1115c-d7cb-4e43-9501-19d5a312215d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6821420e-28cd-4198-b65f-4c798ca22d81", "AQAAAAEAACcQAAAAEJ0yQUAp8BpyFfgGu6iL7R8piwMtwv3uNg7j4/vlVzZo66hBzFQNOdQx6ZDl4GNITA==", "9083abb5-c7fa-4dca-84f1-46828b8ba795" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfba3c53-b419-4120-86cc-8d7d44e22fbd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00b1159a-d7f8-4889-8c1f-770ac839315f", "AQAAAAEAACcQAAAAEFVKReGR/utlBOJNWgSQyL1rvgTfHVT+XH+SiJc5wZ0yI0ox2HcwUh/LMTX1hS76Ow==", "d14d27d8-af91-45f1-b62d-215dab92eafc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocation");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "249f124f-cf13-420d-aebc-60a45ed3c02c", "AQAAAAEAACcQAAAAEOWTg7F/FUPnXtJoFmZGt9vlTsO6girOdi3/HREz3es0XsVKjm5enXeADgI0st9z9A==", "8b3d76a2-6b02-4d64-9310-c95103099a11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfba3c53-b419-4120-86cc-8d7d44e22fbd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93e32ddd-2d8f-46c4-9b3a-890aeb7540d0", "AQAAAAEAACcQAAAAECXCWFzz2hIWdXhOuOgVwcqrwSPxlLU09CPw/yDqW6A3mUNVSFDyVAe+TkoZ3L5IYg==", "758ce7a3-9fa2-4759-ad9a-b99a2c4175de" });
        }
    }
}
