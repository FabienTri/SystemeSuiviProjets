using System.Collections.Generic;
using System.Numerics;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core
{
    public class Client(string nomConnexion, string motDePasse, string nomCompagnie, string adresse, string téléphone)
        : Utilisateur(nomConnexion, motDePasse), IAggregateRoot
    {
        public string NomCompagnie { get; set; } = nomCompagnie;
        public string Adresse { get; set; } = adresse;
        public string Téléphone { get; set; } = téléphone;
        public List<Projet> Projets { get; private set; } = [];
        public void AddProjet(Projet projet)
        {
            Projets.Add(projet);
        }
        public void RemoveProjet(Projet projet)
        {
            Projets.Remove(projet);
        }
    }
}