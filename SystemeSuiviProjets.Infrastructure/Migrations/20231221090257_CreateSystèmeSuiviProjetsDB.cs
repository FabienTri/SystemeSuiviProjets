using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SystemeSuiviProjets.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateSystèmeSuiviProjetsDB : Migration
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
                name: "SystèmeFacturationClients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documents = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystèmeFacturationClients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystèmePaiementProfessionnels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystèmePaiementProfessionnels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
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
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeuillePrésence",
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
                    table.PrimaryKey("PK_FeuillePrésence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeuillePrésence_SystèmePaiementProfessionnels_SystèmePaiementProfessionnelsId",
                        column: x => x.SystèmePaiementProfessionnelsId,
                        principalTable: "SystèmePaiementProfessionnels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeuillePrésence_Utilisateur_ProfessionnelId",
                        column: x => x.ProfessionnelId,
                        principalTable: "Utilisateur",
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
                        name: "FK_ProfessionnelEstDansCatégorie_Utilisateur_ProfessionnelId",
                        column: x => x.ProfessionnelId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projet",
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
                    table.PrimaryKey("PK_Projet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projet_Utilisateur_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Session",
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
                    table.PrimaryKey("PK_Session", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Session_Utilisateur_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "Utilisateur",
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
                        name: "FK_EstAssigné_Projet_ProjetId",
                        column: x => x.ProjetId,
                        principalTable: "Projet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstAssigné_Utilisateur_ProfessionnelId",
                        column: x => x.ProfessionnelId,
                        principalTable: "Utilisateur",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LigneFeuillePrésence",
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
                    table.PrimaryKey("PK_LigneFeuillePrésence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LigneFeuillePrésence_FeuillePrésence_FeuillePrésenceId",
                        column: x => x.FeuillePrésenceId,
                        principalTable: "FeuillePrésence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LigneFeuillePrésence_Projet_ProjetId",
                        column: x => x.ProjetId,
                        principalTable: "Projet",
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
                name: "IX_FeuillePrésence_ProfessionnelId",
                table: "FeuillePrésence",
                column: "ProfessionnelId");

            migrationBuilder.CreateIndex(
                name: "IX_FeuillePrésence_SystèmePaiementProfessionnelsId",
                table: "FeuillePrésence",
                column: "SystèmePaiementProfessionnelsId");

            migrationBuilder.CreateIndex(
                name: "IX_LigneFeuillePrésence_FeuillePrésenceId",
                table: "LigneFeuillePrésence",
                column: "FeuillePrésenceId");

            migrationBuilder.CreateIndex(
                name: "IX_LigneFeuillePrésence_ProjetId",
                table: "LigneFeuillePrésence",
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
                name: "IX_Projet_ClientId",
                table: "Projet",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_UtilisateurId",
                table: "Session",
                column: "UtilisateurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstAssigné");

            migrationBuilder.DropTable(
                name: "LigneFeuillePrésence");

            migrationBuilder.DropTable(
                name: "ProfessionnelEstDansCatégorie");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "SystèmeFacturationClients");

            migrationBuilder.DropTable(
                name: "FeuillePrésence");

            migrationBuilder.DropTable(
                name: "Projet");

            migrationBuilder.DropTable(
                name: "Catégories");

            migrationBuilder.DropTable(
                name: "SystèmePaiementProfessionnels");

            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
