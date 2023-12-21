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
        public DbSet<FeuillePrésence> FeuillePrésence { get; set; }
        public DbSet<Gestionnaire> Gestionnaire { get; set; }
        public DbSet<LigneFeuillePrésence> LigneFeuillePrésence { get; set; }
        public DbSet<Professionnel> Professionnel { get; set; }
        public DbSet<ProfessionnelEstDansCatégorie> ProfessionnelEstDansCatégorie { get; set; }
        public DbSet<Projet> Projet { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<SystèmeFacturationClients> SystèmeFacturationClients { get; set; }
        public DbSet<SystèmePaiementProfessionnels> SystèmePaiementProfessionnels { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }


        public SystèmeSuiviProjetsContext(DbContextOptions options) : base(options) { }

        public SystèmeSuiviProjetsContext() : base(new DbContextOptionsBuilder<SystèmeSuiviProjetsContext>()
                    .UseSqlServer(@"Server=.;Database=SystèmeSuiviProjetsDB;Trusted_Connection=True;TrustServerCertificate=True;")
                    .Options)
        { }
    }
}
