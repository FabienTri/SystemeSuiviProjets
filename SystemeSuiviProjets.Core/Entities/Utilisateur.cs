using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Utilisateur(string nomConnexion, string motDePasse) : BaseEntity
    {
        public string NomConnexion { get; set; } = nomConnexion;
        public string MotDePasse { get; set; } = motDePasse;

        public List<Session> Sessions { get; private set; } = [];
        public void AddSession(Session session)
        {
            Sessions.Add(session);
        }
    }
}