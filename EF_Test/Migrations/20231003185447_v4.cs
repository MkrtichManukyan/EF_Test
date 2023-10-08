using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Test.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCorses_Corses_CurseId",
                table: "StudentCorses");

            migrationBuilder.RenameColumn(
                name: "CurseId",
                table: "StudentCorses",
                newName: "CorseId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCorses_CurseId",
                table: "StudentCorses",
                newName: "IX_StudentCorses_CorseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCorses_Corses_CorseId",
                table: "StudentCorses",
                column: "CorseId",
                principalTable: "Corses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCorses_Corses_CorseId",
                table: "StudentCorses");

            migrationBuilder.RenameColumn(
                name: "CorseId",
                table: "StudentCorses",
                newName: "CurseId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCorses_CorseId",
                table: "StudentCorses",
                newName: "IX_StudentCorses_CurseId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCorses_Corses_CurseId",
                table: "StudentCorses",
                column: "CurseId",
                principalTable: "Corses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
