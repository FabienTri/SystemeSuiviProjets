using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class SystèmePaiementProfessionnels(Professionnel professionnel) : BaseEntity
    {
        public int ProfessionnelId { get; set; } = professionnel.Id;
        public Professionnel Professionnel { get; private set; } = professionnel;

        public List<FeuillePrésence> FeuillesPrésence { get; private set; } = [];
        public void AddFeuillePrésence(FeuillePrésence feuillePrésence)
        {
            FeuillesPrésence.Add(feuillePrésence);
        }
        public void RemoveFeuillePrésence(FeuillePrésence feuillePrésence)
        {
            FeuillesPrésence.Remove(feuillePrésence);
        }
    }
}