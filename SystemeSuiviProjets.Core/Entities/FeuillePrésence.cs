using System;
using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class FeuillePrésence : BaseEntity
    {
        public int SystèmePaiementProfessionnelsId { get; set; }
        public SystèmePaiementProfessionnels SystèmePaiementProfessionnels { get; private set; }

        public DateRange Période { get; set; }
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

        public FeuillePrésence(SystèmePaiementProfessionnels systèmePaiementProfessionnels,
            DateRange période, DateTime dateCréation)
        {
            SystèmePaiementProfessionnelsId = systèmePaiementProfessionnels.Id;
            SystèmePaiementProfessionnels = systèmePaiementProfessionnels;
            Période = période;
            DateCréation = dateCréation;
            DateDernièreModification = dateCréation;
            LignesFeuillePrésence = [];
        }
    }
}