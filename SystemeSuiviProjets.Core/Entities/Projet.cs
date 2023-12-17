using System;
using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class Projet(Client client, DateOnly dateDébut, long budgetTotal) : BaseEntity
    {
        public int ClientId { get; set; } = client.Id;
        public Client Client { get; private set; } = client;

        public DateOnly DateDébut { get; private set; } = dateDébut;
        public DateOnly DateFin { get; set; }

        public long BudgetTotal { get; set; } = budgetTotal;

        public List<EstAssigné> Professionnels { get; set; } = [];

        public List<LigneFeuillePrésence> LignesFeuillePrésence { get; set; } = [];
    }
}