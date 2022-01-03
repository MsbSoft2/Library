using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Domain.Migrations
{
    public partial class Missing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookGroups",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGroups", x => x.GroupID);
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    RentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.RentID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    BookName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    PublisherName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    PublishYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ISBNNumber = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowInSlider = table.Column<bool>(type: "bit", nullable: false),
                    BookVisit = table.Column<int>(type: "int", nullable: false),
                    BookGroupGroupID = table.Column<int>(type: "int", nullable: true),
                    RentOrNot = table.Column<bool>(type: "bit", nullable: true),
                    RentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Books_BookGroups_BookGroupGroupID",
                        column: x => x.BookGroupGroupID,
                        principalTable: "BookGroups",
                        principalColumn: "GroupID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Rents_RentID",
                        column: x => x.RentID,
                        principalTable: "Rents",
                        principalColumn: "RentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FullName", "Password", "RegisterDate", "Role" },
                values: new object[] { 1, "محمد صدرا برومند", "sadra123", new DateTime(2022, 1, 3, 22, 42, 25, 444, DateTimeKind.Local).AddTicks(9193), "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookGroupGroupID",
                table: "Books",
                column: "BookGroupGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_RentID",
                table: "Books",
                column: "RentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BookGroups");

            migrationBuilder.DropTable(
                name: "Rents");
        }
    }
}
