using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class ProfessionnelEstDansCatégorie(DateOnly dateAffectation) : BaseEntity
    {
        public DateOnly DateAffectation { get; set; } = dateAffectation;
    }
}