using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManage.Migrations
{
    public partial class ChangeAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Publishers_Publisher_ID",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Translators_Translator_ID",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_Publisher_ID",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_Translator_ID",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Publisher_ID",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Translator_ID",
                table: "Authors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_ID",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Translator_ID",
                table: "Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Publisher_ID",
                table: "Authors",
                column: "Publisher_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Translator_ID",
                table: "Authors",
                column: "Translator_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Publishers_Publisher_ID",
                table: "Authors",
                column: "Publisher_ID",
                principalTable: "Publishers",
                principalColumn: "Publisher_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Translators_Translator_ID",
                table: "Authors",
                column: "Translator_ID",
                principalTable: "Translators",
                principalColumn: "Translator_ID");
        }
    }
}
