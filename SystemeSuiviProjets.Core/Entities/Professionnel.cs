using System;
using System.Collections.Generic;

namespace SystemeSuiviProjets.Core
{
    public class Professionnel(string nomConnexion, string motDePasse, string nom, string prénom,
        string adresse, string téléphone, DateOnly dateEmbauche)
        : Employé(nomConnexion, motDePasse, nom, prénom, adresse, téléphone, dateEmbauche)
    {
        public List<ProfessionnelEstDansCatégorie> Catégories { get; set; } = [];

        public List<EstAssigné> Projets { get; set; } = [];

        public SystèmePaiementProfessionnels SystèmePaiementProfessionnels { get; set; }
    }
}