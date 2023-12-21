using System.Threading.Tasks;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core.Interfaces
{
    public interface IProfessionnelRepository : IAsyncRepository<Professionnel>, IRepository<Professionnel>
    {
        Task<Professionnel> GetByIdWithCatégoriesAsync(int id);
        Professionnel GetByIdWithCatégories(int id);
    }
}
