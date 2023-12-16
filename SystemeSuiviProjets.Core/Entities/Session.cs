using System;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Session(DateTime dateConnexion) : BaseEntity
    {
        public DateTime DateConnexion { get; set; } = dateConnexion;
        public DateTime DateDeconnexion { get; set; }
    }
}