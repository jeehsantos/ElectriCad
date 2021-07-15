using Microsoft.EntityFrameworkCore.Migrations;

namespace Electricad.Migrations
{
    public partial class foreignkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortfolioSectors");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_portifolio_tb_sectors_Sectorsid",
                table: "tb_portifolio");

            migrationBuilder.DropIndex(
                name: "IX_tb_portifolio_Sectorsid",
                table: "tb_portifolio");

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
                name: "IX_PortfolioSectors_Sectorid",
                table: "PortfolioSectors",
                column: "Sectorid");
        }
    }
}
