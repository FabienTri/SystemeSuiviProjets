using System.Collections.Generic;

namespace SystemeSuiviProjets.Core
{
    public class Client : Utilisateur
    {
        public string NomCompagnie { get; set; }
        public string Adresse { get; set; }
        public string Téléphone { get; set; }

        public List<Projet> Projets { get; private set; }
        public void AddProjet(Projet projet)
        {
            Projets.Add(projet);
        }
        public void RemoveProjet(Projet projet)
        {
            Projets.Remove(projet);
        }

        public SystèmeFacturationClients SystèmeFacturationClients { get; private set; }

        public Client(string nomConnexion, string motDePasse, string nomCompagnie, string adresse, string téléphone)
            : base(nomConnexion, motDePasse)
        {
            NomCompagnie = nomCompagnie;
            Adresse = adresse;
            Téléphone = téléphone;
            Projets = [];
            SystèmeFacturationClients = new SystèmeFacturationClients(this);
        }
    }
}