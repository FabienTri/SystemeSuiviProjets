using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Session : BaseEntity
    {
        public int UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; private set; }

        public DateTime DateConnexion { get; private set; }
        public DateTime DateDeconnexion { get; set; }

        public Session()
        {
            // EF Core needs this one to materialize collections from DB Set
        }

        public Session(Utilisateur utilisateur, DateTime dateConnexion)
        {
            UtilisateurId = utilisateur.Id;
            Utilisateur = utilisateur;
            DateConnexion = dateConnexion;
        }
    }
}