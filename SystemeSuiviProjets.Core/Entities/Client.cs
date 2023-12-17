namespace SystemeSuiviProjets.Core
{
    public class Client(string nomCompagnie, string adresse, string téléphone) : Utilisateur
    {
        public string NomCompagnie { get; set; } = nomCompagnie;
        public string Adresse { get; set; } = adresse;
        public string Téléphone { get; set; } = téléphone;
    }
}