using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gameApi.Migrations
{
    public partial class Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                });

            //migrationBuilder.CreateTable(
            //    name: "defenders",
            //    columns: table => new
            //    {
            //        defenderId = table.Column<int>(type: "INTEGER", nullable: false)
            //            .Annotation("Sqlite:Autoincrement", true),
            //        defenderName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
            //        balance = table.Column<int>(type: "INTEGER", nullable: false),
            //        shot = table.Column<int>(type: "INTEGER", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_defenders", x => x.defenderId);
            //    });

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
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "articles");

            migrationBuilder.DropTable(
                name: "attacks");

            migrationBuilder.DropTable(
                name: "defenders");

            migrationBuilder.DropTable(
                name: "games");

            migrationBuilder.DropTable(
                name: "manticoras");

            migrationBuilder.DropTable(
                name: "scopes");

            migrationBuilder.DropTable(
                name: "stocks");
        }
    }
}
