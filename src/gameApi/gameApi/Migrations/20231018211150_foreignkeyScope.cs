using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gameApi.Migrations
{
    public partial class foreignkeyScope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articles_scopes_scopeId",
                table: "articles");

            migrationBuilder.DropIndex(
                name: "IX_articles_scopeId",
                table: "articles");
        }
    }
}
