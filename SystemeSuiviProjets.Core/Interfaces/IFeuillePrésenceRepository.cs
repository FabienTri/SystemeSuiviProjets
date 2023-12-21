using System.Threading.Tasks;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core.Interfaces
{
    public interface IFeuillePrésenceRepository : IAsyncRepository<FeuillePrésence>, IRepository<FeuillePrésence>
    {
        Task<FeuillePrésence> GetByIdWithSessionsAsync(int id);
        FeuillePrésence GetByIdWithSessions(int id);
    }
}
