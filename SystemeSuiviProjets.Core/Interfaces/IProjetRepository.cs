using System.Threading.Tasks;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core.Interfaces
{
    public interface IProjetRepository : IAsyncRepository<Projet>, IRepository<Projet>
    {
        Task<Projet> GetByIdWithSessionsAsync(int id);
        Projet GetByIdWithSessions(int id);
    }
}
