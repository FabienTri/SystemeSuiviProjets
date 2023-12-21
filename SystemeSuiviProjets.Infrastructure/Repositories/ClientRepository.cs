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
              .FirstOrDefault(c => c.Id == id);
        }
        

        public Task<Client> GetByIdWithSessionsAsync(int id)
        {
            return _SystemeSuiviProjetsContext.Clients
              .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IReadOnlyList<Client>> ListAllAsync()
        {
            return await _SystemeSuiviProjetsContext.Clients
                .ToListAsync();
        }

        public IReadOnlyList<Client> ListAll()
        {
            return _SystemeSuiviProjetsContext.Clients
                .ToList();
        }


    }
}
