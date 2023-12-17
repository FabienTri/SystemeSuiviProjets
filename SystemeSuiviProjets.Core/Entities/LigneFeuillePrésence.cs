using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class LigneFeuillePrésence(FeuillePrésence feuillePrésence, Projet projet, TypeTarification typeTarification, int nbUnités, double fraisDéplacement = 0, double fraisSéjour = 0) : BaseEntity
    {
        public int FeuillePrésenceId { get; set; } = feuillePrésence.Id;
        public FeuillePrésence FeuillePrésence { get; set; } = feuillePrésence;

        public int ProjetId { get; set; } = projet.Id;
        public Projet Projet { get; set; } = projet;

        public TypeTarification TypeTarification { get; set; } = typeTarification;
        public int NombreUnités { get; set; } = nbUnités;
        public double FraisDéplacement { get; set; } = fraisDéplacement;
        public double FraisSéjour { get; set; } = fraisSéjour;
    }
}