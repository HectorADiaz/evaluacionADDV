using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gameApi.Migrations
{
    public partial class foreignkeyAllv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articles_scopes_scopeId",
                table: "articles");

            migrationBuilder.DropTable(
                name: "scopes");

            migrationBuilder.DropIndex(
                name: "IX_articles_scopeId",
                table: "articles");

            migrationBuilder.RenameColumn(
                name: "scopeId",
                table: "articles",
                newName: "scopeValue");

            migrationBuilder.CreateIndex(
                name: "IX_games_manticoraId",
                table: "games",
                column: "manticoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_games_manticoras_manticoraId",
                table: "games",
                column: "manticoraId",
                principalTable: "manticoras",
                principalColumn: "manticoraId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_games_manticoras_manticoraId",
                table: "games");

            migrationBuilder.DropIndex(
                name: "IX_games_manticoraId",
                table: "games");

            migrationBuilder.RenameColumn(
                name: "scopeValue",
                table: "articles",
                newName: "scopeId");

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

            migrationBuilder.CreateIndex(
                name: "IX_articles_scopeId",
                table: "articles",
                column: "scopeId");

            migrationBuilder.AddForeignKey(
                name: "FK_articles_scopes_scopeId",
                table: "articles",
                column: "scopeId",
                principalTable: "scopes",
                principalColumn: "scopeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
