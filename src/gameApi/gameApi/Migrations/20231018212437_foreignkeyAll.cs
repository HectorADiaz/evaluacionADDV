using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gameApi.Migrations
{
    public partial class foreignkeyAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_stocks_articleId",
                table: "stocks",
                column: "articleId");

            migrationBuilder.CreateIndex(
                name: "IX_stocks_defenderId",
                table: "stocks",
                column: "defenderId");

            migrationBuilder.CreateIndex(
                name: "IX_attacks_defenderId",
                table: "attacks",
                column: "defenderId");

            migrationBuilder.CreateIndex(
                name: "IX_attacks_gameId",
                table: "attacks",
                column: "gameId");

            migrationBuilder.AddForeignKey(
                name: "FK_attacks_defenders_defenderId",
                table: "attacks",
                column: "defenderId",
                principalTable: "defenders",
                principalColumn: "defenderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_attacks_games_gameId",
                table: "attacks",
                column: "gameId",
                principalTable: "games",
                principalColumn: "gameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stocks_articles_articleId",
                table: "stocks",
                column: "articleId",
                principalTable: "articles",
                principalColumn: "articleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stocks_defenders_defenderId",
                table: "stocks",
                column: "defenderId",
                principalTable: "defenders",
                principalColumn: "defenderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_attacks_defenders_defenderId",
                table: "attacks");

            migrationBuilder.DropForeignKey(
                name: "FK_attacks_games_gameId",
                table: "attacks");

            migrationBuilder.DropForeignKey(
                name: "FK_stocks_articles_articleId",
                table: "stocks");

            migrationBuilder.DropForeignKey(
                name: "FK_stocks_defenders_defenderId",
                table: "stocks");

            migrationBuilder.DropIndex(
                name: "IX_stocks_articleId",
                table: "stocks");

            migrationBuilder.DropIndex(
                name: "IX_stocks_defenderId",
                table: "stocks");

            migrationBuilder.DropIndex(
                name: "IX_attacks_defenderId",
                table: "attacks");

            migrationBuilder.DropIndex(
                name: "IX_attacks_gameId",
                table: "attacks");
        }
    }
}
