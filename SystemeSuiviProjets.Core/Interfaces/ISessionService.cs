using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemeSuiviProjets.Core.Interfaces
{
    public interface ISessionService
    {
        Task<IReadOnlyList<Employé>> GetAllEmployés();
        Task<IReadOnlyList<Client>> GetAllClients();
        Task<IReadOnlyList<Projet>> GetAllProjets();
        Task<IReadOnlyList<FeuillePrésence>> GetAllFeuillesPrésence();

        Task<bool> ValiderInfoConnexion(string username, string password);
        Task<string> GetTypeSession(string username);

    }
}
