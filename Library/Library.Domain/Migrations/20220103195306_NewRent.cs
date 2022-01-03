using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Domain.Migrations
{
    public partial class NewRent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookRent");

            migrationBuilder.AddColumn<int>(
                name: "BookID",
                table: "Rents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 1, 3, 23, 23, 6, 285, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.CreateIndex(
                name: "IX_Rents_BookID",
                table: "Rents",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Books_BookID",
                table: "Rents",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Books_BookID",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_BookID",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "BookID",
                table: "Rents");

            migrationBuilder.CreateTable(
                name: "BookRent",
                columns: table => new
                {
                    BooksBookID = table.Column<int>(type: "int", nullable: false),
                    RentsRentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookRent", x => new { x.BooksBookID, x.RentsRentID });
                    table.ForeignKey(
                        name: "FK_BookRent_Books_BooksBookID",
                        column: x => x.BooksBookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookRent_Rents_RentsRentID",
                        column: x => x.RentsRentID,
                        principalTable: "Rents",
                        principalColumn: "RentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 1, 3, 22, 49, 53, 294, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.CreateIndex(
                name: "IX_BookRent_RentsRentID",
                table: "BookRent",
                column: "RentsRentID");
        }
    }
}
