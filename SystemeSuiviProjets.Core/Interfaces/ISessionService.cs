using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeSuiviProjets.Core.Interfaces
{
    public interface ISessionService
    {
        Task<IReadOnlyList<Professionnel>> GetAllProfessionnels();
        Task<IReadOnlyList<Client>> GetAllClients();
        Task<IReadOnlyList<Projet>> GetAllProjets();
        Task<IReadOnlyList<FeuillePrésence>> GetAllFeuillesPrésence();

        Utilisateur ValiderInfoConnexion(string username, string password);
        string GetTypeSession(string username);

    }
}
