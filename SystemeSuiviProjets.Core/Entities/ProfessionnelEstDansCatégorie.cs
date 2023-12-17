using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class ProfessionnelEstDansCatégorie(Professionnel professionnel, Catégorie catégorie, DateOnly dateAffectation)
        : BaseEntity
    {
        public int ProfessionnelId { get; set; } = professionnel.Id;
        public Professionnel Professionnel { get; set; } = professionnel;

        public int CatégorieId { get; set; } = catégorie.Id;
        public Catégorie Catégorie { get; set; } = catégorie;

        public DateOnly DateAffectation { get; set; } = dateAffectation;
    }
}