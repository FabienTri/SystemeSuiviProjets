using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class LigneFeuillePrésence(TypeTarification typeTarification, int nbUnités, double fraisDéplacement = 0, double fraisSéjour = 0) : BaseEntity
    {
        public TypeTarification TypeTarification { get; set; } = typeTarification;
        public int NombreUnités { get; set; } = nbUnités;
        public double FraisDéplacement { get; set; } = fraisDéplacement;
        public double FraisSéjour { get; set; } = fraisSéjour;
    }
}