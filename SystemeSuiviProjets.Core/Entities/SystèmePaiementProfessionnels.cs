using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class SystèmePaiementProfessionnels : BaseEntity
    {
        public int ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; private set; }

        public List<FeuillePrésence> FeuillesPrésence { get; private set; }
        public void AddFeuillePrésence(FeuillePrésence feuillePrésence)
        {
            FeuillesPrésence.Add(feuillePrésence);
        }
        public void RemoveFeuillePrésence(FeuillePrésence feuillePrésence)
        {
            FeuillesPrésence.Remove(feuillePrésence);
        }

        public SystèmePaiementProfessionnels()
        {
            // EF Core needs this one to materialize collections from DB Set
        }

        public SystèmePaiementProfessionnels(Professionnel professionnel)
        {
            ProfessionnelId = professionnel.Id;
            Professionnel = professionnel;
            FeuillesPrésence = [];
        }
    }
}