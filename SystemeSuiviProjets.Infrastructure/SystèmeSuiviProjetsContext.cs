using Microsoft.EntityFrameworkCore;
using SystemeSuiviProjets.Core;

namespace SystemeSuiviProjets.Infrastructure
{
    public class SystèmeSuiviProjetsContext : DbContext
    {
        public DbSet<Catégorie> Catégories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employé> Employés { get; set; }
        public DbSet<EstAssigné> EstAssigné { get; set; }
        public DbSet<FeuillePrésence> FeuillesPrésence { get; set; }
        public DbSet<Gestionnaire> Gestionnaires { get; set; }
        public DbSet<LigneFeuillePrésence> LignesFeuillePrésence { get; set; }
        public DbSet<Professionnel> Professionnels { get; set; }
        public DbSet<ProfessionnelEstDansCatégorie> ProfessionnelEstDansCatégorie { get; set; }
        public DbSet<Projet> Projets { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SystèmeFacturationClients> SystèmesFacturationClients { get; set; }
        public DbSet<SystèmePaiementProfessionnels> SystèmesPaiementProfessionnels { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }


        public SystèmeSuiviProjetsContext(DbContextOptions options) : base(options) { }

        public SystèmeSuiviProjetsContext() : base(new DbContextOptionsBuilder<SystèmeSuiviProjetsContext>()
                    .UseSqlServer(@"Server=.;Database=SystèmeSuiviProjetsDB;Trusted_Connection=True;TrustServerCertificate=True;")
                    .Options)
        { }
    }
}
