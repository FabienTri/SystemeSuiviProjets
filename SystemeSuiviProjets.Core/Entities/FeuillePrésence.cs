using System;
using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core
{
    public class FeuillePrésence : BaseEntity, IAggregateRoot
    {
        public int ProfessionnelId { get; set; }
        public Professionnel Professionnel { get; private set; }

        public DateTime DateDébutPériode { get; private set; }
        public DateTime DateFinPériode { get; private set; }
        public DateTime DateCréation { get; private set; }
        public DateTime DateDernièreModification { get; set; }

        public List<LigneFeuillePrésence> LignesFeuillePrésence { get; private set; }
        public void AddLigneFeuillePrésence(LigneFeuillePrésence ligneFeuillePrésence)
        {
            LignesFeuillePrésence.Add(ligneFeuillePrésence);
        }
        public void RemoveLigneFeuillePrésence(LigneFeuillePrésence ligneFeuillePrésence)
        {
            LignesFeuillePrésence.Remove(ligneFeuillePrésence);
        }

        public FeuillePrésence()
        {
            // EF Core needs this one to materialize collections from DB Set
        }

        public FeuillePrésence(Professionnel professionnel,
            DateTime dateDébutPériode, DateTime dateFinPériode, DateTime dateCréation)
        {
            ProfessionnelId = professionnel.Id;
            Professionnel = professionnel;
            DateDébutPériode = dateDébutPériode;
            DateFinPériode = dateFinPériode;
            DateCréation = dateCréation;
            DateDernièreModification = dateCréation;
            LignesFeuillePrésence = [];
        }
    }
}