using System;
using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class FeuillePrésence(SystèmePaiementProfessionnels systèmePaiementProfessionnels,
        DateRange période, DateTime dateCréation)
        : BaseEntity
    {
        public int SystèmePaiementProfessionnelsId { get; set; } = systèmePaiementProfessionnels.Id;
        public SystèmePaiementProfessionnels SystèmePaiementProfessionnels { get; private set; } = systèmePaiementProfessionnels;

        public DateRange Période { get; set; } = période;
        public DateTime DateCréation { get; private set; } = dateCréation;
        public DateTime DateDernièreModification { get; set; } = dateCréation;

        public List<LigneFeuillePrésence> LignesFeuillePrésence { get; set; } = [];
    }
}