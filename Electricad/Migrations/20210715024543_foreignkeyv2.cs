using Microsoft.EntityFrameworkCore.Migrations;

namespace Electricad.Migrations
{
    public partial class foreignkeyv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_about_User_user_id",
                table: "tb_about");

            migrationBuilder.DropIndex(
                name: "IX_tb_about_user_id",
                table: "tb_about");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "tb_about");

            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "tb_about",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_about_Userid",
                table: "tb_about",
                column: "Userid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_about_User_Userid",
                table: "tb_about",
                column: "Userid",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_about_User_Userid",
                table: "tb_about");

            migrationBuilder.DropIndex(
                name: "IX_tb_about_Userid",
                table: "tb_about");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "tb_about");

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "tb_about",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_about_user_id",
                table: "tb_about",
                column: "user_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_about_User_user_id",
                table: "tb_about",
                column: "user_id",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
