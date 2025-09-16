using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace my_portfolio.Migrations
{
    /// <inheritdoc />
    public partial class FeatureTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Features",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SocialMedia",
                table: "Features",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "SocialMedia",
                table: "Features");
        }
    }
}
