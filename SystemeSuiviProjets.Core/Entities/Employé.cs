using System;

namespace SystemeSuiviProjets.Core
{
    public class Employé(string nomConnexion, string motDePasse, string nom, string prénom,
        string adresse, string téléphone, DateOnly dateEmbauche)
        : Utilisateur(nomConnexion, motDePasse)
    {
        public string Nom { get; set; } = nom;
        public string Prénom { get; set; } = prénom;
        public string Adresse { get; set; } = adresse;
        public string Téléphone { get; set; } = téléphone;
        public DateOnly DateEmbauche { get; set; } = dateEmbauche;
    }
}