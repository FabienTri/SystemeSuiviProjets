using System;
using System.Collections.Generic;

namespace SystemeSuiviProjets.Core
{
    public class Professionnel(string nom, string prénom, string adresse, string téléphone, DateOnly dateEmbauche)
        : Employé(nom, prénom, adresse, téléphone, dateEmbauche)
    {
        public List<ProfessionnelEstDansCatégorie> Catégories { get; set; } = [];
    }
}