using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SystemeSuiviProjets.Core;
using SystemeSuiviProjets.Core.Interfaces;

namespace SystemeSuiviProjets.Infrastructure.Repositories
{
    public class UtilisateurRepository(SystèmeSuiviProjetsContext systemeSuiviProjetsContext)
        : EfRepository<Utilisateur>(systemeSuiviProjetsContext), IUtilisateurRepository
    {
        public Utilisateur GetByIdWithSessions(int id)
        {
            return _SystemeSuiviProjetsContext.Utilisateurs
                .Include(u => u.Sessions)
                .FirstOrDefault(u => u.Id == id);
        }

        public Task<Utilisateur> GetByIdWithSessionsAsync(int id)
        {
            return _SystemeSuiviProjetsContext.Utilisateurs
                .Include(u => u.Sessions)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public Utilisateur GetByNomConnexionWithSessions(string nomConnexion)
        {
            return _SystemeSuiviProjetsContext.Utilisateurs
                .Include(u => u.Sessions)
                .FirstOrDefault(u => u.NomConnexion == nomConnexion);
        }

        public Task<Utilisateur> GetByNomConnexionWithSessionsAsync(string nomConnexion)
        {
            return _SystemeSuiviProjetsContext.Utilisateurs
                .Include(u => u.Sessions)
                .FirstOrDefaultAsync(u => u.NomConnexion == nomConnexion);
        }
    }
}
