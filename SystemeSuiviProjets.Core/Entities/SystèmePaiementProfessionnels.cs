using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core
{
    public class SystèmePaiementProfessionnels : BaseEntity, IAggregateRoot
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