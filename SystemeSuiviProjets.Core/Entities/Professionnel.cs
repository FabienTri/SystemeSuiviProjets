using System;

namespace SystemeSuiviProjets.Core
{
    public class Professionnel(string nom, string prénom, string adresse, string téléphone, DateOnly dateEmbauche)
        : Employé(nom, prénom, adresse, téléphone, dateEmbauche)
    {
    }
}