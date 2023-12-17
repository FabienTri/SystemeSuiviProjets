using System;

namespace SystemeSuiviProjets.Core
{
    public class Employé(string nom, string prénom, string adresse, string téléphone, DateOnly dateEmbauche) : Utilisateur
    {
        public string Nom { get; set; } = nom;
        public string Prénom { get; set; } = prénom;
        public string Adresse { get; set; } = adresse;
        public string Téléphone { get; set; } = téléphone;
        public DateOnly DateEmbauche { get; set; } = dateEmbauche;
    }
}