using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemeSuiviProjets.Core;
using SystemeSuiviProjets.Core.Interfaces;

namespace SystemeSuiviProjets.Infrastructure.Repositories
{
    public class EmployéRepository(SystèmeSuiviProjetsContext systèmeSuiviProjetsContext)
        : EfRepository<Employé>(systèmeSuiviProjetsContext), IEmployéRepository
    {
        public Employé GetByIdWithSessions(int id)
        {
            return _SystemeSuiviProjetsContext.Employés
                .Include(e => e.Sessions)
                .FirstOrDefault(e => e.Id == id);
        }

        public async Task<Employé> GetByIdWithSessionsAsync(int id)
        {
            return await _SystemeSuiviProjetsContext.Employés
                .Include(e => e.Sessions)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
