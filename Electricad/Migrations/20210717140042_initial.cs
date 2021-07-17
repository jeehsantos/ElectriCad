using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Electricad.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_reviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    dateComment = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_reviews", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_sectors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    desc = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_sectors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    login = table.Column<string>(type: "text", nullable: true),
                    password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_about",
                columns: table => new
                {
                    Userid = table.Column<int>(type: "int", nullable: false),
                    about_file = table.Column<string>(type: "text", nullable: true),
                    about_desc = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_about", x => x.Userid);
                    table.ForeignKey(
                        name: "FK_tb_about_User_Userid",
                        column: x => x.Userid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_offers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    descount = table.Column<int>(type: "int", nullable: false),
                    offer_file = table.Column<string>(type: "text", nullable: true),
                    desc = table.Column<string>(type: "text", nullable: false),
                    Userid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_offers", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_offers_User_Userid",
                        column: x => x.Userid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_portifolio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    port_file = table.Column<string>(type: "text", nullable: true),
                    Userid = table.Column<int>(type: "int", nullable: true),
                    Sectorsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_portifolio", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_portifolio_tb_sectors_Sectorsid",
                        column: x => x.Sectorsid,
                        principalTable: "tb_sectors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_portifolio_User_Userid",
                        column: x => x.Userid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_offers_Userid",
                table: "tb_offers",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_portifolio_Sectorsid",
                table: "tb_portifolio",
                column: "Sectorsid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_portifolio_Userid",
                table: "tb_portifolio",
                column: "Userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_about");

            migrationBuilder.DropTable(
                name: "tb_offers");

            migrationBuilder.DropTable(
                name: "tb_portifolio");

            migrationBuilder.DropTable(
                name: "tb_reviews");

            migrationBuilder.DropTable(
                name: "tb_sectors");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
