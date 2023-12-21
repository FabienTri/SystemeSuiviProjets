using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core
{
    public class Utilisateur(string nomConnexion, string motDePasse) : BaseEntity, IAggregateRoot
    {
        public string NomConnexion { get; set; } = nomConnexion;
        public string MotDePasse { get; set; } = motDePasse;

        public List<Session> Sessions { get; private set; } = [];
        public void AddSession(Session session)
        {
            Sessions.Add(session);
        }

        public bool ValiderInfoConnexion(string nomConnexion, string motDePasse)
        {
            return (nomConnexion == NomConnexion && motDePasse == MotDePasse) ? true : false;
        }
    }
}