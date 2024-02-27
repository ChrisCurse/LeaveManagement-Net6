using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1e2225c-d7bd-9e93-9601-60d5a816375b",
                column: "ConcurrencyStamp",
                value: "7be209b2-6521-4682-9711-0cae7150a2e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1f1115c-d7cd-8e83-9501-20d5a516275b",
                column: "ConcurrencyStamp",
                value: "99e777fb-b1b2-4cfc-9ace-767de02c8b99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1c1115c-d7cb-4e43-9501-19d5a312215d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5809cb3e-9346-46b4-bc25-3c0d0efef439", "AQAAAAEAACcQAAAAEAYBkf0yCQIBGYlFijVCjXRrO+GkD59mEHUrk7U+dlNPqfr8enLQZx3DjeHqp9GTwQ==", "9ac78faf-392b-4fad-b96b-75f7c32250ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfba3c53-b419-4120-86cc-8d7d44e22fbd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3949c4ca-4979-4d00-a6f1-b38e87bddfa7", "AQAAAAEAACcQAAAAECmYIBruRs0oKFSe5HS6YQGE8OvJFr487quJjpXO13FL5vUm844AU8BEaG0w7twG3A==", "0480a782-802f-42cd-9666-d618ef6d3bb8" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
