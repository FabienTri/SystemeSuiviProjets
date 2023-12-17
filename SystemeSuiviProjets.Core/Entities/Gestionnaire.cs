using System;

namespace SystemeSuiviProjets.Core
{
    public class Gestionnaire(string nomConnexion, string motDePasse, string nom, string prénom,
        string adresse, string téléphone, DateOnly dateEmbauche)
        : Employé(nomConnexion, motDePasse, nom, prénom, adresse, téléphone, dateEmbauche)
    {
    }
}