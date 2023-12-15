using System;

namespace SystemeSuiviProjets.Core
{
    public class Employe : Utilisateur
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        public DateOnly DateEmbauche { get; set; }
    }
}