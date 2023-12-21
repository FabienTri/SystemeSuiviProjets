using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core.Interfaces
{
    public interface IEmployéRepository : IAsyncRepository<Employé>, IRepository<Employé>
    {

    }
}
