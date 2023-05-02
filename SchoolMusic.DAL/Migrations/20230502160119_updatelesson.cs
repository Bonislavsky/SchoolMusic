using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolMusic.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatelesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Lessons",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Lessons",
                newName: "id");
        }
    }
}
