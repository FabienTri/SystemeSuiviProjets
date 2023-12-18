using System;
using System.Collections.Generic;

namespace SystemeSuiviProjets.Core
{
    public class Professionnel(string nomConnexion, string motDePasse, string nom, string prénom,
                   string adresse, string téléphone, DateOnly dateEmbauche) : Employé(nomConnexion, motDePasse, nom, prénom, adresse, téléphone, dateEmbauche)
    {
        public List<ProfessionnelEstDansCatégorie> Catégories { get; private set; } = [];
        public void AddProfessionnelEstDansCatégorie(ProfessionnelEstDansCatégorie professionnelEstDansCatégorie)
        {
            Catégories.Add(professionnelEstDansCatégorie);
        }
        public void RemoveProfessionnelEstDansCatégorie(ProfessionnelEstDansCatégorie professionnelEstDansCatégorie)
        {
            Catégories.Remove(professionnelEstDansCatégorie);
        }

        public List<EstAssigné> Projets { get; private set; } = [];
        public void AddEstAssigné(EstAssigné estAssigné)
        {
            Projets.Add(estAssigné);
        }
        public void RemoveEstAssigné(EstAssigné estAssigné)
        {
            Projets.Remove(estAssigné);
        }
    }
}