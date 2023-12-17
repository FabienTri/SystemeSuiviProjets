using System.Collections.Generic;

namespace SystemeSuiviProjets.Core
{
    public class Client(string nomConnexion, string motDePasse, string nomCompagnie, string adresse, string téléphone)
        : Utilisateur(nomConnexion, motDePasse)
    {
        public string NomCompagnie { get; set; } = nomCompagnie;
        public string Adresse { get; set; } = adresse;
        public string Téléphone { get; set; } = téléphone;

        public List<Projet> Projets { get; set; } = [];

        public SystèmeFacturationClients SystèmeFacturationClients { get; set; }
    }
}