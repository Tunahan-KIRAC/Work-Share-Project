using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class _03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "tblUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "tblCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9601), new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "tblCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9604), new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "tblCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9607), new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "tblComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9798), new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9880), new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9885), new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "tblWorks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9948), new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "tblWorks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9955), new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "tblWorks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9958), new DateTime(2022, 6, 4, 9, 18, 41, 763, DateTimeKind.Local).AddTicks(9959) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "tblUsers");

            migrationBuilder.UpdateData(
                table: "tblCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5066), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "tblCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5080), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "tblCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5082), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "tblComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5303), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5364), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5368), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "tblWorks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5439), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "tblWorks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5445), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "tblWorks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5448), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5449) });
        }
    }
}
