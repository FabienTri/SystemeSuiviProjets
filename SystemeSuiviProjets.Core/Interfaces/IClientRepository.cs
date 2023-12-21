using System.Collections.Generic;
using System.Threading.Tasks;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core.Interfaces
{
    public interface IClientRepository : IAsyncRepository<Client>, IRepository<Client>
    {
        Task<Client> GetByIdWithSessionsAsync(int id);
        Client GetByIdWithSessions(int id);

        //List all clients
        Task<IReadOnlyList<Client>> ListAllAsync();

    }
}
