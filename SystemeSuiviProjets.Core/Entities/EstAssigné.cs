using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class EstAssigné(Professionnel professionnel, Projet projet, DateOnly dateAssignation) : BaseEntity
    {
        public int ProfessionnelId { get; set; } = professionnel.Id;
        public Professionnel Professionnel { get; set; } = professionnel;

        public int ProjetId { get; set; } = projet.Id;
        public Projet Projet { get; set; } = projet;

        public DateOnly DateAssignation { get; set; } = dateAssignation;
    }
}