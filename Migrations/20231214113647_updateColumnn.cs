using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diana_Project.Migrations
{
    /// <inheritdoc />
    public partial class updateColumnn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsImage",
                table: "Images",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsImage",
                table: "Images");
        }
    }
}
