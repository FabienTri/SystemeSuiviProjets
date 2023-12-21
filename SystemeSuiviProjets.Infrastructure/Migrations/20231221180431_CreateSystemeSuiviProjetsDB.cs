using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemeSuiviProjets.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateSystemeSuiviProjetsDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catégories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarifFacturationHeure = table.Column<long>(type: "bigint", nullable: false),
                    TarifFacturationJour = table.Column<long>(type: "bigint", nullable: false),
                    TarifFacturationSemaine = table.Column<long>(type: "bigint", nullable: false),
                    TarifPaiementHeure = table.Column<long>(type: "bigint", nullable: false),
                    TarifPaiementJour = table.Column<long>(type: "bigint", nullable: false),
                    TarifPaiementSemaine = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catégories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystèmesFacturationClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documents = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystèmesFacturationClients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystèmesPaiementProfessionnels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystèmesPaiementProfessionnels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomConnexion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    NomCompagnie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client_Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client_Téléphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prénom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Téléphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateEmbauche = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeuillesPrésence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionnelId = table.Column<int>(type: "int", nullable: false),
                    DateDébutPériode = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFinPériode = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCréation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDernièreModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SystèmePaiementProfessionnelsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeuillesPrésence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeuillesPrésence_SystèmesPaiementProfessionnels_SystèmePaiementProfessionnelsId",
                        column: x => x.SystèmePaiementProfessionnelsId,
                        principalTable: "SystèmesPaiementProfessionnels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeuillesPrésence_Utilisateurs_ProfessionnelId",
                        column: x => x.ProfessionnelId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionnelEstDansCatégorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionnelId = table.Column<int>(type: "int", nullable: false),
                    CatégorieId = table.Column<int>(type: "int", nullable: false),
                    DateAffectation = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionnelEstDansCatégorie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionnelEstDansCatégorie_Catégories_CatégorieId",
                        column: x => x.CatégorieId,
                        principalTable: "Catégories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionnelEstDansCatégorie_Utilisateurs_ProfessionnelId",
                        column: x => x.ProfessionnelId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    DateDébut = table.Column<DateOnly>(type: "date", nullable: false),
                    DateFin = table.Column<DateOnly>(type: "date", nullable: false),
                    BudgetTotal = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projets_Utilisateurs_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false),
                    DateConnexion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeconnexion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Utilisateurs_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstAssigné",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionnelId = table.Column<int>(type: "int", nullable: true),
                    ProjetId = table.Column<int>(type: "int", nullable: false),
                    DateAssignation = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstAssigné", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstAssigné_Projets_ProjetId",
                        column: x => x.ProjetId,
                        principalTable: "Projets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstAssigné_Utilisateurs_ProfessionnelId",
                        column: x => x.ProfessionnelId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LignesFeuillePrésence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeuillePrésenceId = table.Column<int>(type: "int", nullable: false),
                    ProjetId = table.Column<int>(type: "int", nullable: true),
                    TypeTarification = table.Column<int>(type: "int", nullable: false),
                    NombreUnités = table.Column<int>(type: "int", nullable: false),
                    FraisDéplacement = table.Column<double>(type: "float", nullable: false),
                    FraisSéjour = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LignesFeuillePrésence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LignesFeuillePrésence_FeuillesPrésence_FeuillePrésenceId",
                        column: x => x.FeuillePrésenceId,
                        principalTable: "FeuillesPrésence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LignesFeuillePrésence_Projets_ProjetId",
                        column: x => x.ProjetId,
                        principalTable: "Projets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstAssigné_ProfessionnelId",
                table: "EstAssigné",
                column: "ProfessionnelId");

            migrationBuilder.CreateIndex(
                name: "IX_EstAssigné_ProjetId",
                table: "EstAssigné",
                column: "ProjetId");

            migrationBuilder.CreateIndex(
                name: "IX_FeuillesPrésence_ProfessionnelId",
                table: "FeuillesPrésence",
                column: "ProfessionnelId");

            migrationBuilder.CreateIndex(
                name: "IX_FeuillesPrésence_SystèmePaiementProfessionnelsId",
                table: "FeuillesPrésence",
                column: "SystèmePaiementProfessionnelsId");

            migrationBuilder.CreateIndex(
                name: "IX_LignesFeuillePrésence_FeuillePrésenceId",
                table: "LignesFeuillePrésence",
                column: "FeuillePrésenceId");

            migrationBuilder.CreateIndex(
                name: "IX_LignesFeuillePrésence_ProjetId",
                table: "LignesFeuillePrésence",
                column: "ProjetId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionnelEstDansCatégorie_CatégorieId",
                table: "ProfessionnelEstDansCatégorie",
                column: "CatégorieId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionnelEstDansCatégorie_ProfessionnelId",
                table: "ProfessionnelEstDansCatégorie",
                column: "ProfessionnelId");

            migrationBuilder.CreateIndex(
                name: "IX_Projets_ClientId",
                table: "Projets",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UtilisateurId",
                table: "Sessions",
                column: "UtilisateurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstAssigné");

            migrationBuilder.DropTable(
                name: "LignesFeuillePrésence");

            migrationBuilder.DropTable(
                name: "ProfessionnelEstDansCatégorie");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "SystèmesFacturationClients");

            migrationBuilder.DropTable(
                name: "FeuillesPrésence");

            migrationBuilder.DropTable(
                name: "Projets");

            migrationBuilder.DropTable(
                name: "Catégories");

            migrationBuilder.DropTable(
                name: "SystèmesPaiementProfessionnels");

            migrationBuilder.DropTable(
                name: "Utilisateurs");
        }
    }
}
