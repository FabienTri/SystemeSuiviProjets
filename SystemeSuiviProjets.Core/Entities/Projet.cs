using System;
using System.Collections.Generic;
using SystemeSuiviProjets.SharedKernel;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core
{
    public class Projet : BaseEntity, IAggregateRoot
    {
        public int ClientId { get; set; }
        public Client Client { get; private set; }

        public DateOnly DateDébut { get; private set; }
        public DateOnly DateFin { get; set; }

        public long BudgetTotal { get; set; }

        public List<EstAssigné> Professionnels { get; private set; }
        public void AddEstAssigné(EstAssigné estAssigné)
        {
            Professionnels.Add(estAssigné);
        }
        public void RemoveEstAssigné(EstAssigné estAssigné)
        {
            Professionnels.Remove(estAssigné);
        }

        public List<LigneFeuillePrésence> LignesFeuillePrésence { get; private set; }
        public void AddLigneFeuillePrésence(LigneFeuillePrésence ligneFeuillePrésence)
        {
            LignesFeuillePrésence.Add(ligneFeuillePrésence);
        }
        public void RemoveLigneFeuillePrésence(LigneFeuillePrésence ligneFeuillePrésence)
        {
            LignesFeuillePrésence.Remove(ligneFeuillePrésence);
        }

        public Projet()
        {
            // EF Core needs this one to materialize collections from DB Set
        }

        public Projet(Client client, DateOnly dateDébut, long budgetTotal)
        {
            ClientId = client.Id;
            Client = client;
            DateDébut = dateDébut;
            BudgetTotal = budgetTotal;
            Professionnels = [];
            LignesFeuillePrésence = [];
        }
    }
}