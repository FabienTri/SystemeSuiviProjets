using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Catégorie(string description, long tarifFacturationHeure, long tarifFacturationJour,
        long tarifFacturationSemaine, long tarifPaiementHeure, long tarifPaiementJour, long tarifPaiementSemaine)
        : BaseEntity
    {
        public string Description { get; set; } = description;

        public long TarifFacturationHeure { get; set; } = tarifFacturationHeure;
        public long TarifFacturationJour { get; set; } = tarifFacturationJour;
        public long TarifFacturationSemaine { get; set; } = tarifFacturationSemaine;

        public long TarifPaiementHeure { get; set; } = tarifPaiementHeure;
        public long TarifPaiementJour { get; set; } = tarifPaiementJour;
        public long TarifPaiementSemaine { get; set; } = tarifPaiementSemaine;

        public List<ProfessionnelEstDansCatégorie> Professionnels { get; private set; } = [];
        public void AddProfessionnelEstDansCatégorie(ProfessionnelEstDansCatégorie professionnelEstDansCatégorie)
        {
            Professionnels.Add(professionnelEstDansCatégorie);
        }
        public void RemoveProfessionnelEstDansCatégorie(ProfessionnelEstDansCatégorie professionnelEstDansCatégorie)
        {
            Professionnels.Remove(professionnelEstDansCatégorie);
        }
    }
}