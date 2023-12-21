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
    public class ClientRepository : EfRepository<Client>, IClientRepository
    {
        public ClientRepository(SystèmeSuiviProjetsContext systèmeSuiviProjetsContext) : base(systèmeSuiviProjetsContext)
        {
        }

        public Client GetByIdWithSessions(int id)
        {
            return _SystemeSuiviProjetsContext.Clients
              .Include(c => c.Session)
              .FirstOrDefault(c => c.Id == id);
        }
        

        public Task<Client> GetByIdWithSessionsAsync(int id)
        {
            return _SystemeSuiviProjetsContext.Clients
              .Include(c => c.Session)
              .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
