using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class EstAssigné(DateOnly dateAssignation) : BaseEntity
    {
        public DateOnly DateAssignation { get; set; } = dateAssignation;
    }
}