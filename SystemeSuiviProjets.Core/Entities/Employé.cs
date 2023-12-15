using System;

namespace SystemeSuiviProjets.Core
{
    public class Employé : Utilisateur
    {
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public string Adresse { get; set; }
        public string Téléphone { get; set; }
        public DateOnly DateEmbauche { get; set; }
    }
}