using Microsoft.EntityFrameworkCore.Migrations;

namespace Electricad.Migrations
{
    public partial class SectorForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortifolioSectors");

            migrationBuilder.AddColumn<int>(
                name: "SectorsId",
                table: "tb_portifolio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "offer_file",
                table: "tb_offers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_tb_portifolio_SectorsId",
                table: "tb_portifolio",
                column: "SectorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_portifolio_tb_sectors_SectorsId",
                table: "tb_portifolio",
                column: "SectorsId",
                principalTable: "tb_sectors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_portifolio_tb_sectors_SectorsId",
                table: "tb_portifolio");

            migrationBuilder.DropIndex(
                name: "IX_tb_portifolio_SectorsId",
                table: "tb_portifolio");

            migrationBuilder.DropColumn(
                name: "SectorsId",
                table: "tb_portifolio");

            migrationBuilder.AlterColumn<string>(
                name: "offer_file",
                table: "tb_offers",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PortifolioSectors",
                columns: table => new
                {
                    Portifoliosid = table.Column<int>(type: "int", nullable: false),
                    Sectorsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortifolioSectors", x => new { x.Portifoliosid, x.Sectorsid });
                    table.ForeignKey(
                        name: "FK_PortifolioSectors_tb_portifolio_Portifoliosid",
                        column: x => x.Portifoliosid,
                        principalTable: "tb_portifolio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PortifolioSectors_tb_sectors_Sectorsid",
                        column: x => x.Sectorsid,
                        principalTable: "tb_sectors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PortifolioSectors_Sectorsid",
                table: "PortifolioSectors",
                column: "Sectorsid");
        }
    }
}
