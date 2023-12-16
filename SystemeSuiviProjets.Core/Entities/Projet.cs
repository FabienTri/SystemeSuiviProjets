using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Projet : BaseEntity
    {
        public DateOnly DateDébut { get; set; }
        public DateOnly DateFin { get; set; }
        public long BudgetTotal { get; set; }
    }
}