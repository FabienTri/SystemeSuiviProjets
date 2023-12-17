﻿using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class SystèmePaiementProfessionnels(Professionnel professionnel) : BaseEntity
    {
        public int ProfessionnelId { get; set; } = professionnel.Id;
        public Professionnel Professionnel { get; set; } = professionnel;

        public List<FeuillePrésence> FeuillesPrésence { get; set; } = [];
    }
}