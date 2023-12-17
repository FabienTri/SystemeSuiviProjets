using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Session(Utilisateur utilisateur, DateTime dateConnexion) : BaseEntity
    {
        public Utilisateur Utilisateur { get; set; } = utilisateur;

        public DateTime DateConnexion { get; set; } = dateConnexion;
        public DateTime DateDeconnexion { get; set; }
    }
}