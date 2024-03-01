using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CW18.Migrations
{
    /// <inheritdoc />
    public partial class DeleteArticleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
