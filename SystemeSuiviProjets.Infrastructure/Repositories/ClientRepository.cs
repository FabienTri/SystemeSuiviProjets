using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemeSuiviProjets.Core.Interfaces;
using SystemeSuiviProjets.Core;
using Microsoft.EntityFrameworkCore;

namespace SystemeSuiviProjets.Infrastructure.Repositories
{
    public class ClientRepository(SystèmeSuiviProjetsContext systèmeSuiviProjetsContext)
        : EfRepository<Client>(systèmeSuiviProjetsContext), IClientRepository
    {
        public Client GetByIdWithSessions(int id)
        {
            return _SystemeSuiviProjetsContext.Clients
                .Include(c => c.Sessions)
                .FirstOrDefault(c => c.Id == id);
        }
        

        public Task<Client> GetByIdWithSessionsAsync(int id)
        {
            return _SystemeSuiviProjetsContext.Clients
                .Include(c => c.Sessions)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
