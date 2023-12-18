using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class SystèmePaiementProfessionnels : BaseEntity
    {
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