using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Utilisateur(string nomConnexion, string motDePasse) : BaseEntity
    {
        public string NomConnexion { get; set; } = nomConnexion;
        public string MotDePasse { get; set; } = motDePasse;
    }
}