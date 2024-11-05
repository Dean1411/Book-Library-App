using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Library.Migrations
{
    /// <inheritdoc />
    public partial class BooksSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorrowDate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BorrowDate",
                table: "Books",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnDate",
                table: "Books",
                type: "datetime2",
                nullable: true);
        }
    }
}
