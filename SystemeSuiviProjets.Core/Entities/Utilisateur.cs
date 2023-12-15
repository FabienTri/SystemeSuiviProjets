using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Utilisateur : BaseEntity
    {
        public string NomConnexion { get; set; }
        public string MotDePasse { get; set; }
    }
}
