using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class _02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfileImageFileName",
                table: "tblUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "tblCategories",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "ModifiedUserName", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5066), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5078), "system", "Boya İşleri" },
                    { 2, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5080), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5081), "system", "Elektrik İşleri" },
                    { 3, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5082), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5082), "system", "Temizlik İşleri" }
                });

            migrationBuilder.InsertData(
                table: "tblUsers",
                columns: new[] { "Id", "CreatedOn", "Email", "IsActive", "IsAdmin", "IsDelete", "LastName", "ModifiedOn", "ModifiedUserName", "Name", "Password", "ProfileImageFileName", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5364), "tuna@gmail.com", true, true, false, "Kıraç", new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5366), "system", "Tunahan", "123", null, "Feleket" },
                    { 2, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5368), "efe@gmail.com", true, false, false, "cemal", new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5369), "system", "Efe", "123", null, "efenbuy" }
                });

            migrationBuilder.InsertData(
                table: "tblWorks",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "IsActive", "ModifiedOn", "ModifiedUserName", "OwnerId", "Price", "Title" },
                values: new object[] { 1, 1, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5439), "Evin bir odası boyanacak", true, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5444), "system", 1, 250m, "Acil boya işi" });

            migrationBuilder.InsertData(
                table: "tblWorks",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "IsActive", "ModifiedOn", "ModifiedUserName", "OwnerId", "Price", "Title" },
                values: new object[] { 2, 2, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5445), "Evin elektirik tesisatına bakılacak", true, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5446), "system", 1, 500m, "Acil elektirik işi" });

            migrationBuilder.InsertData(
                table: "tblWorks",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Description", "IsActive", "ModifiedOn", "ModifiedUserName", "OwnerId", "Price", "Title" },
                values: new object[] { 3, 3, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5448), "Ev temizlenecek", true, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5449), "system", 2, 75m, "Acil temizlik işi" });

            migrationBuilder.InsertData(
                table: "tblComments",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "ModifiedUserName", "OwnerId", "Text", "WorkId" },
                values: new object[] { 1, new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5303), new DateTime(2022, 5, 16, 23, 15, 52, 858, DateTimeKind.Local).AddTicks(5301), "efenbuy", 2, "ben yaparım kuzen", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblComments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblWorks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblWorks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblWorks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "ProfileImageFileName",
                table: "tblUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
