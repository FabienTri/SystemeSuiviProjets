using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Categorie : BaseEntity
    {
        public string Description { get; set; }
        public long TarifFacturationHeure { get; set; }
        public long TarifFacturationJour { get; set; }
        public long TarifFacturationSemaine { get; set; }
        public long TarifPaiementHeure { get; set; }
        public long TarifPaiementJour { get; set; }
        public long TarifPaiementSemaine { get; set; }
    }
}
