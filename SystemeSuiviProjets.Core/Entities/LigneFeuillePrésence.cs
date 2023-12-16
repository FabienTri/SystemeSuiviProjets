using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class LigneFeuillePrésence(TypeTarification typeTarification, int nbUnités, decimal fraisDéplacement = 0, decimal fraisSéjour = 0) : BaseEntity
    {
        public TypeTarification TypeTarification { get; set; } = typeTarification;
        public int NombreUnités { get; set; } = nbUnités;
        public decimal FraisDéplacement { get; set; } = fraisDéplacement;
        public decimal FraisSéjour { get; set; } = fraisSéjour;
    }
}