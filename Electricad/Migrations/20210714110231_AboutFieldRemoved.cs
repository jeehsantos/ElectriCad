using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Electricad.Migrations
{
    public partial class AboutFieldRemoved : Migration
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

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "tb_about",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_about_User_id",
                table: "tb_about",
                column: "id",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_about_User_id",
                table: "tb_about");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "tb_about",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn);

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
