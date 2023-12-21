using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SystemeSuiviProjets.Core;
using SystemeSuiviProjets.Core.Interfaces;

namespace SystemeSuiviProjets.Infrastructure.Repositories
{
    public class ProfessionnelRepository(SystèmeSuiviProjetsContext systemeSuiviProjetsContext)
        : EfRepository<Professionnel>(systemeSuiviProjetsContext), IProfessionnelRepository
    {
        public Professionnel GetByIdWithCatégories(int id)
        {
            return _SystemeSuiviProjetsContext.Professionnels
                .Include(p => p.Catégories)
                .FirstOrDefault(p => p.Id == id);
        }

        public Task<Professionnel> GetByIdWithCatégoriesAsync(int id)
        {
            return _SystemeSuiviProjetsContext.Professionnels
                .Include(p => p.Catégories)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
