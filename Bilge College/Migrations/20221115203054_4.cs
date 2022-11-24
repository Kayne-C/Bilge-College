using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilge_College.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notice_Teachers_TeacherId",
                table: "Notice");

            migrationBuilder.DropForeignKey(
                name: "FK_NoticeParent_Notice_NoticesId",
                table: "NoticeParent");

            migrationBuilder.DropForeignKey(
                name: "FK_NoticeStudent_Notice_NoticesId",
                table: "NoticeStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notice",
                table: "Notice");

            migrationBuilder.RenameTable(
                name: "Notice",
                newName: "Notices");

            migrationBuilder.RenameIndex(
                name: "IX_Notice_TeacherId",
                table: "Notices",
                newName: "IX_Notices_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notices",
                table: "Notices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NoticeParent_Notices_NoticesId",
                table: "NoticeParent",
                column: "NoticesId",
                principalTable: "Notices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notices_Teachers_TeacherId",
                table: "Notices",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NoticeStudent_Notices_NoticesId",
                table: "NoticeStudent",
                column: "NoticesId",
                principalTable: "Notices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NoticeParent_Notices_NoticesId",
                table: "NoticeParent");

            migrationBuilder.DropForeignKey(
                name: "FK_Notices_Teachers_TeacherId",
                table: "Notices");

            migrationBuilder.DropForeignKey(
                name: "FK_NoticeStudent_Notices_NoticesId",
                table: "NoticeStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notices",
                table: "Notices");

            migrationBuilder.RenameTable(
                name: "Notices",
                newName: "Notice");

            migrationBuilder.RenameIndex(
                name: "IX_Notices_TeacherId",
                table: "Notice",
                newName: "IX_Notice_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notice",
                table: "Notice",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notice_Teachers_TeacherId",
                table: "Notice",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NoticeParent_Notice_NoticesId",
                table: "NoticeParent",
                column: "NoticesId",
                principalTable: "Notice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NoticeStudent_Notice_NoticesId",
                table: "NoticeStudent",
                column: "NoticesId",
                principalTable: "Notice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
