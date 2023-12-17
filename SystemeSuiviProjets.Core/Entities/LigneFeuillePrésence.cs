using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class LigneFeuillePrésence : BaseEntity
    {
        public int FeuillePrésenceId { get; set; }
        public FeuillePrésence FeuillePrésence { get; private set; }

        public int ProjetId { get; set; }
        public Projet Projet { get; private set; }

        public TypeTarification TypeTarification { get; set; }
        public int NombreUnités { get; set; }
        public double FraisDéplacement { get; set; }
        public double FraisSéjour { get; set; }

        public LigneFeuillePrésence()
        {
            // EF Core needs this one to materialize collections from DB Set
        }

        public LigneFeuillePrésence(FeuillePrésence feuillePrésence, Projet projet, TypeTarification typeTarification,
            int nbUnités, double fraisDéplacement = 0, double fraisSéjour = 0)
        {
            FeuillePrésenceId = feuillePrésence.Id;
            FeuillePrésence = feuillePrésence;
            ProjetId = projet.Id;
            Projet = projet;
            TypeTarification = typeTarification;
            NombreUnités = nbUnités;
            FraisDéplacement = fraisDéplacement;
            FraisSéjour = fraisSéjour;
        }
    }
}