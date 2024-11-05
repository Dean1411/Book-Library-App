using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Library.Migrations
{
    /// <inheritdoc />
    public partial class RemoveBorrowDateAndReturnDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Remove the BorrowDate and ReturnDate columns from the Books table
            migrationBuilder.DropColumn(
                name: "BorrowDate",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ReturnDate",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Add the columns back if the migration is rolled back
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
