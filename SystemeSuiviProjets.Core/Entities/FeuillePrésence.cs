using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class FeuillePrésence(DateRange période, DateTime dateCréation) : BaseEntity
    {
        public DateRange Période { get; set; } = période;
        public DateTime DateCréation { get; set; } = dateCréation;
        public DateTime DateDernièreModification { get; set; } = dateCréation;
    }
}