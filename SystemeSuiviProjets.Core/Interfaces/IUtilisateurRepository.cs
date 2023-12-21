using System.Threading.Tasks;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core.Interfaces
{
    public interface IUtilisateurRepository : IAsyncRepository<Utilisateur>, IRepository<Utilisateur>
    {
        Task<Utilisateur> GetByIdWithSessionsAsync(int id);
        Utilisateur GetByIdWithSessions(int id);
    }
}
