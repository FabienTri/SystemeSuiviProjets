using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Projet(DateOnly dateDébut, long budgetTotal) : BaseEntity
    {
        public DateOnly DateDébut { get; set; } = dateDébut;
        public DateOnly? DateFin { get; set; }
        public long BudgetTotal { get; set; } = budgetTotal;
    }
}