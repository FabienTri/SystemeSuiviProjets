﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemeSuiviProjets.Core;
using SystemeSuiviProjets.Core.Interfaces;

namespace SystemeSuiviProjets.Infrastructure.Repositories
{
    public class ProjetRepository : EfRepository<Projet>, IProjetRepository
    {
        public ProjetRepository(SystèmeSuiviProjetsContext dbContext) : base(dbContext)
        {
        }

        public async Task<IReadOnlyList<Projet>> ListAllAsync()
        {
            return await _SystemeSuiviProjetsContext.Projets.ToListAsync();
        }

        public IReadOnlyList<Projet> ListAll()
        {
            return _SystemeSuiviProjetsContext.Projets.ToList();
        }

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
