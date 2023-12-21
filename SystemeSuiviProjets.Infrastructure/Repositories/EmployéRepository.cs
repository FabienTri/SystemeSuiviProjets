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
    public class EmployéRepository : EfRepository<Employé>, IEmployéRepository
    {
        public EmployéRepository(SystèmeSuiviProjetsContext systèmeSuiviProjetsContext) : base(systèmeSuiviProjetsContext)
        {
        }

        public Employé GetByIdWithSessions(int id)
        {
            return _SystemeSuiviProjetsContext.Employés.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<Employé> GetByIdWithSessionsAsync(int id)
        {
            return await _SystemeSuiviProjetsContext.Employés.FindAsync(id);
        }

        public async Task<IReadOnlyList<Employé>> ListAllAsync()
        {
            return await _SystemeSuiviProjetsContext.Employés.ToListAsync();
        }

        public IReadOnlyList<Employé> ListAll()
        {
            return _SystemeSuiviProjetsContext.Employés.ToList();
        }
    }
}
