using Microsoft.EntityFrameworkCore.Migrations;

namespace Electricad.Migrations
{
    public partial class foreignkeyv6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_portifolio_tb_sectors_Sectorsid",
                table: "tb_portifolio");

            migrationBuilder.DropForeignKey(
                name: "FK_User_tb_about_Aboutid",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_Aboutid",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_tb_portifolio_Sectorsid",
                table: "tb_portifolio");

            migrationBuilder.DropColumn(
                name: "Aboutid",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "tb_about",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PortfolioSectors",
                columns: table => new
                {
                    Portfoliosid = table.Column<int>(type: "int", nullable: false),
                    Sectorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortfolioSectors", x => new { x.Portfoliosid, x.Sectorid });
                    table.ForeignKey(
                        name: "FK_PortfolioSectors_tb_portifolio_Portfoliosid",
                        column: x => x.Portfoliosid,
                        principalTable: "tb_portifolio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortfolioSectors_tb_sectors_Sectorid",
                        column: x => x.Sectorid,
                        principalTable: "tb_sectors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_about_Userid",
                table: "tb_about",
                column: "Userid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PortfolioSectors_Sectorid",
                table: "PortfolioSectors",
                column: "Sectorid");

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

            migrationBuilder.DropTable(
                name: "PortfolioSectors");

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

            migrationBuilder.CreateIndex(
                name: "IX_tb_portifolio_Sectorsid",
                table: "tb_portifolio",
                column: "Sectorsid");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_portifolio_tb_sectors_Sectorsid",
                table: "tb_portifolio",
                column: "Sectorsid",
                principalTable: "tb_sectors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_tb_about_Aboutid",
                table: "User",
                column: "Aboutid",
                principalTable: "tb_about",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
