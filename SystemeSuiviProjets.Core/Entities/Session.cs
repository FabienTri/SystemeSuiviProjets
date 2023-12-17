using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Session(Utilisateur utilisateur, DateTime dateConnexion) : BaseEntity
    {
        public int UtilisateurId { get; set; } = utilisateur.Id;
        public Utilisateur Utilisateur { get; private set; } = utilisateur;

        public DateTime DateConnexion { get; private set; } = dateConnexion;
        public DateTime DateDeconnexion { get; set; }
    }
}