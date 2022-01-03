using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Domain.Migrations
{
    public partial class Rent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Rents_RentID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_RentID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "RentID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "RentOrNot",
                table: "Books");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookRent");

            migrationBuilder.AddColumn<int>(
                name: "RentID",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "RentOrNot",
                table: "Books",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2022, 1, 3, 22, 42, 25, 444, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.CreateIndex(
                name: "IX_Books_RentID",
                table: "Books",
                column: "RentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Rents_RentID",
                table: "Books",
                column: "RentID",
                principalTable: "Rents",
                principalColumn: "RentID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
