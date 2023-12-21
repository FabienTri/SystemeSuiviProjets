using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class EstAssigné : BaseEntity
    {
        public int ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; private set; }

        public int ProjetId { get; set; }
        public Projet Projet { get; private set; }

        public DateOnly DateAssignation { get; private set; }

        public EstAssigné()
        {
            // EF Core needs this one to materialize collections from DB Set
        }

        public EstAssigné(Professionnel professionnel, Projet projet, DateOnly dateAssignation)
        {
            Professionnel = professionnel;
            Projet = projet;
            DateAssignation = dateAssignation;
        }
    }
}