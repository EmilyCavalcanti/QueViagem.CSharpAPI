using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QueViagem.Migrations
{
    /// <inheritdoc />
    public partial class firstm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cidade = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pais = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    imagem_destino = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Destinos",
                columns: new[] { "id", "cidade", "imagem_destino", "pais", "valor" },
                values: new object[,]
                {
                    { 1, "Amsterdã", "https://www.melhoresdestinos.com.br/wp-content/uploads/2019/02/passagens-aereas-amsterda-capa2019-03-820x430.jpg", "Holanda", 3100m },
                    { 2, "Paris", "https://viagemeturismo.abril.com.br/wp-content/uploads/2016/11/thinkstockphotos-4549879531.jpeg?quality=90", "França", 3600m },
                    { 3, "Santiago", "https://www.vrbo.com/pt-br/dicas-viagem/wp-content/uploads/67PoRLlKbEDl0ZGSgeKs2E/eff02c3a63848a35d322b172ebee7645/AdobeStock_209940755.jpeg", "Chile", 3300m },
                    { 4, "Buenos Aires", "https://aguiarbuenosaires.com/wp-content/uploads/2015/10/Obelisco-Mapa-de-Buenos-Aires-Foto-Wikipedia2-800x600.jpg", "Argentina", 2950m },
                    { 5, "Fernando de Noronha", "https://www.melhoresdestinos.com.br/wp-content/uploads/2022/02/fernando-noronha-capa-2022-820x430.jpg", "Brasil", 5500m },
                    { 6, "Orlando", "https://res.klook.com/image/upload/c_fill,w_1265,h_712/q_80/activities/alg3puq4hmpeobqhumjd.webp", "EUA", 4850m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinos");
        }
    }
}
