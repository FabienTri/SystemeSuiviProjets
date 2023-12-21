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
    public class FeuillePrésenceRepository(SystèmeSuiviProjetsContext systemeSuiviProjetsContext)
        : EfRepository<FeuillePrésence>(systemeSuiviProjetsContext), IFeuillePrésenceRepository
    {
        public FeuillePrésence GetByIdWithSessions(int id)
        {
            throw new NotImplementedException();
        }

        public Task<FeuillePrésence> GetByIdWithSessionsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
