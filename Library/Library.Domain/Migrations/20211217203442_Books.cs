using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Domain.Migrations
{
    public partial class Books : Migration
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
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PublisherName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PublishYear = table.Column<DateTime>(type: "datetime2", maxLength: 150, nullable: false),
                    ISBNNumber = table.Column<int>(type: "int", maxLength: 150, nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShowInSlider = table.Column<bool>(type: "bit", nullable: false),
                    BookGroupGroupID = table.Column<int>(type: "int", nullable: true)
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
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2021, 12, 18, 0, 4, 42, 620, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookGroupGroupID",
                table: "Books",
                column: "BookGroupGroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BookGroups");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "RegisterDate",
                value: new DateTime(2021, 12, 17, 23, 57, 22, 489, DateTimeKind.Local).AddTicks(6540));
        }
    }
}
