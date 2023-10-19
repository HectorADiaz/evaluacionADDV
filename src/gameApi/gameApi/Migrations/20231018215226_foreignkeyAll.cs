using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gameApi.Migrations
{
    public partial class foreignkeyAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "defenders",
                columns: table => new
                {
                    defenderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    defenderName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    balance = table.Column<int>(type: "INTEGER", nullable: false),
                    shot = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_defenders", x => x.defenderId);
                });

            migrationBuilder.CreateTable(
                name: "games",
                columns: table => new
                {
                    gameId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cityPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    manticoraId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_games", x => x.gameId);
                });

            migrationBuilder.CreateTable(
                name: "manticoras",
                columns: table => new
                {
                    manticoraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    manticoraPoints = table.Column<int>(type: "INTEGER", nullable: false),
                    manticoraPosition = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manticoras", x => x.manticoraId);
                });

            migrationBuilder.CreateTable(
                name: "scopes",
                columns: table => new
                {
                    scopeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    scopeValue = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scopes", x => x.scopeId);
                });

            migrationBuilder.CreateTable(
                name: "attacks",
                columns: table => new
                {
                    attackId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    gameId = table.Column<int>(type: "INTEGER", nullable: false),
                    defenderId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attacks", x => x.attackId);
                    table.ForeignKey(
                        name: "FK_attacks_defenders_defenderId",
                        column: x => x.defenderId,
                        principalTable: "defenders",
                        principalColumn: "defenderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_attacks_games_gameId",
                        column: x => x.gameId,
                        principalTable: "games",
                        principalColumn: "gameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "articles",
                columns: table => new
                {
                    articleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    articleName = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    articlePrice = table.Column<int>(type: "INTEGER", nullable: false),
                    scopeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articles", x => x.articleId);
                    table.ForeignKey(
                        name: "FK_articles_scopes_scopeId",
                        column: x => x.scopeId,
                        principalTable: "scopes",
                        principalColumn: "scopeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stocks",
                columns: table => new
                {
                    stockId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    defenderId = table.Column<int>(type: "INTEGER", nullable: false),
                    articleId = table.Column<int>(type: "INTEGER", nullable: false),
                    status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stocks", x => x.stockId);
                    table.ForeignKey(
                        name: "FK_stocks_articles_articleId",
                        column: x => x.articleId,
                        principalTable: "articles",
                        principalColumn: "articleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stocks_defenders_defenderId",
                        column: x => x.defenderId,
                        principalTable: "defenders",
                        principalColumn: "defenderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_articles_scopeId",
                table: "articles",
                column: "scopeId");

            migrationBuilder.CreateIndex(
                name: "IX_attacks_defenderId",
                table: "attacks",
                column: "defenderId");

            migrationBuilder.CreateIndex(
                name: "IX_attacks_gameId",
                table: "attacks",
                column: "gameId");

            migrationBuilder.CreateIndex(
                name: "IX_stocks_articleId",
                table: "stocks",
                column: "articleId");

            migrationBuilder.CreateIndex(
                name: "IX_stocks_defenderId",
                table: "stocks",
                column: "defenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attacks");

            migrationBuilder.DropTable(
                name: "manticoras");

            migrationBuilder.DropTable(
                name: "stocks");

            migrationBuilder.DropTable(
                name: "games");

            migrationBuilder.DropTable(
                name: "articles");

            migrationBuilder.DropTable(
                name: "defenders");

            migrationBuilder.DropTable(
                name: "scopes");
        }
    }
}
