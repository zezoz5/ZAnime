using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZAnime.Migrations
{
    /// <inheritdoc />
    public partial class AddedAnimeRatingAndEpisodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Episodes",
                table: "Animes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Animes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Episodes",
                table: "Animes");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Animes");
        }
    }
}
