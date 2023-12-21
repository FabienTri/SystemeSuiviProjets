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
    public class ProjetRepository(SystèmeSuiviProjetsContext dbContext)
        : EfRepository<Projet>(dbContext), IProjetRepository
    {
        public Task<Projet> GetByIdWithSessionsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Projet GetByIdWithSessions(int id)
        {
            throw new NotImplementedException();
        }
    }
}
