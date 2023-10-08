using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Test.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCorse_Corse_CurseId",
                table: "StudentCorse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCorse_Students_StudentId",
                table: "StudentCorse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCorse",
                table: "StudentCorse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Corse",
                table: "Corse");

            migrationBuilder.RenameTable(
                name: "StudentCorse",
                newName: "StudentCorses");

            migrationBuilder.RenameTable(
                name: "Corse",
                newName: "Corses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCorse_CurseId",
                table: "StudentCorses",
                newName: "IX_StudentCorses_CurseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCorses",
                table: "StudentCorses",
                columns: new[] { "StudentId", "CurseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Corses",
                table: "Corses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCorses_Corses_CurseId",
                table: "StudentCorses",
                column: "CurseId",
                principalTable: "Corses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCorses_Students_StudentId",
                table: "StudentCorses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCorses_Corses_CurseId",
                table: "StudentCorses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCorses_Students_StudentId",
                table: "StudentCorses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCorses",
                table: "StudentCorses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Corses",
                table: "Corses");

            migrationBuilder.RenameTable(
                name: "StudentCorses",
                newName: "StudentCorse");

            migrationBuilder.RenameTable(
                name: "Corses",
                newName: "Corse");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCorses_CurseId",
                table: "StudentCorse",
                newName: "IX_StudentCorse_CurseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCorse",
                table: "StudentCorse",
                columns: new[] { "StudentId", "CurseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Corse",
                table: "Corse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCorse_Corse_CurseId",
                table: "StudentCorse",
                column: "CurseId",
                principalTable: "Corse",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCorse_Students_StudentId",
                table: "StudentCorse",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
