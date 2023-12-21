using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class ProfessionnelEstDansCatégorie
        : BaseEntity
    {
        public int ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; private set; }

        public int CatégorieId { get; set; }
        public Catégorie Catégorie { get; private set; }

        public DateOnly DateAffectation { get; private set; }

        public ProfessionnelEstDansCatégorie()
        {
            // EF Core needs this one to materialize collections from DB Set
        }

        public ProfessionnelEstDansCatégorie(Professionnel professionnel, Catégorie catégorie, DateOnly dateAffectation)
        {
            Professionnel = professionnel;
            Catégorie = catégorie;
            DateAffectation = dateAffectation;
        }
    }
}