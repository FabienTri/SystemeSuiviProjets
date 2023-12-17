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

        public List<EstAssigné> Professionnels { get; private set; } = [];
        public void AddEstAssigné(EstAssigné estAssigné)
        {
            Professionnels.Add(estAssigné);
        }
        public void RemoveEstAssigné(EstAssigné estAssigné)
        {
            Professionnels.Remove(estAssigné);
        }

        public List<LigneFeuillePrésence> LignesFeuillePrésence { get; private set; } = [];
        public void AddLigneFeuillePrésence(LigneFeuillePrésence ligneFeuillePrésence)
        {
            LignesFeuillePrésence.Add(ligneFeuillePrésence);
        }
        public void RemoveLigneFeuillePrésence(LigneFeuillePrésence ligneFeuillePrésence)
        {
            LignesFeuillePrésence.Remove(ligneFeuillePrésence);
        }
    }
}