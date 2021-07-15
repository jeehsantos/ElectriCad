using Microsoft.EntityFrameworkCore.Migrations;

namespace Electricad.Migrations
{
    public partial class foreignkeyv5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Aboutid",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Aboutid",
                table: "User",
                column: "Aboutid");

            migrationBuilder.AddForeignKey(
                name: "FK_User_tb_about_Aboutid",
                table: "User",
                column: "Aboutid",
                principalTable: "tb_about",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_tb_about_Aboutid",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_Aboutid",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Aboutid",
                table: "User");

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
    }
}
