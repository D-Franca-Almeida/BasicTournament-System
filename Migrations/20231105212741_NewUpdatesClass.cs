using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasicTournament_System.Migrations
{
    /// <inheritdoc />
    public partial class NewUpdatesClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChaveLutaId",
                table: "Campeonato",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChaveLuta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Faixa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Peso = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CampeonatoId = table.Column<int>(type: "int", nullable: false),
                    AtletaId = table.Column<int>(type: "int", nullable: false),
                    Posicao = table.Column<int>(type: "int", nullable: false),
                    NumberFight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChaveLuta", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Resultados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CampeonatoNumber = table.Column<int>(type: "int", nullable: false),
                    Faixa = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Peso = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resultados", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Atleta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CPF = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sexo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Equipe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Faixa = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Peso = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataInscricao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ChaveLutaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atleta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atleta_ChaveLuta_ChaveLutaId",
                        column: x => x.ChaveLutaId,
                        principalTable: "ChaveLuta",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CampeonatoResultados",
                columns: table => new
                {
                    CampeonatosId = table.Column<int>(type: "int", nullable: false),
                    ResultadosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampeonatoResultados", x => new { x.CampeonatosId, x.ResultadosId });
                    table.ForeignKey(
                        name: "FK_CampeonatoResultados_Campeonato_CampeonatosId",
                        column: x => x.CampeonatosId,
                        principalTable: "Campeonato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampeonatoResultados_Resultados_ResultadosId",
                        column: x => x.ResultadosId,
                        principalTable: "Resultados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChaveLutaResultados",
                columns: table => new
                {
                    ChaveLutasId = table.Column<int>(type: "int", nullable: false),
                    ResultadosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChaveLutaResultados", x => new { x.ChaveLutasId, x.ResultadosId });
                    table.ForeignKey(
                        name: "FK_ChaveLutaResultados_ChaveLuta_ChaveLutasId",
                        column: x => x.ChaveLutasId,
                        principalTable: "ChaveLuta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChaveLutaResultados_Resultados_ResultadosId",
                        column: x => x.ResultadosId,
                        principalTable: "Resultados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AtletaCampeonato",
                columns: table => new
                {
                    AtletasId = table.Column<int>(type: "int", nullable: false),
                    CampeonatoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtletaCampeonato", x => new { x.AtletasId, x.CampeonatoId });
                    table.ForeignKey(
                        name: "FK_AtletaCampeonato_Atleta_AtletasId",
                        column: x => x.AtletasId,
                        principalTable: "Atleta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtletaCampeonato_Campeonato_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AtletaResultados",
                columns: table => new
                {
                    AtletaId = table.Column<int>(type: "int", nullable: false),
                    ResultadosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtletaResultados", x => new { x.AtletaId, x.ResultadosId });
                    table.ForeignKey(
                        name: "FK_AtletaResultados_Atleta_AtletaId",
                        column: x => x.AtletaId,
                        principalTable: "Atleta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtletaResultados_Resultados_ResultadosId",
                        column: x => x.ResultadosId,
                        principalTable: "Resultados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Campeonato_ChaveLutaId",
                table: "Campeonato",
                column: "ChaveLutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atleta_ChaveLutaId",
                table: "Atleta",
                column: "ChaveLutaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtletaCampeonato_CampeonatoId",
                table: "AtletaCampeonato",
                column: "CampeonatoId");

            migrationBuilder.CreateIndex(
                name: "IX_AtletaResultados_ResultadosId",
                table: "AtletaResultados",
                column: "ResultadosId");

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoResultados_ResultadosId",
                table: "CampeonatoResultados",
                column: "ResultadosId");

            migrationBuilder.CreateIndex(
                name: "IX_ChaveLutaResultados_ResultadosId",
                table: "ChaveLutaResultados",
                column: "ResultadosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campeonato_ChaveLuta_ChaveLutaId",
                table: "Campeonato",
                column: "ChaveLutaId",
                principalTable: "ChaveLuta",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Campeonato_ChaveLuta_ChaveLutaId",
                table: "Campeonato");

            migrationBuilder.DropTable(
                name: "AtletaCampeonato");

            migrationBuilder.DropTable(
                name: "AtletaResultados");

            migrationBuilder.DropTable(
                name: "CampeonatoResultados");

            migrationBuilder.DropTable(
                name: "ChaveLutaResultados");

            migrationBuilder.DropTable(
                name: "Atleta");

            migrationBuilder.DropTable(
                name: "Resultados");

            migrationBuilder.DropTable(
                name: "ChaveLuta");

            migrationBuilder.DropIndex(
                name: "IX_Campeonato_ChaveLutaId",
                table: "Campeonato");

            migrationBuilder.DropColumn(
                name: "ChaveLutaId",
                table: "Campeonato");
        }
    }
}
