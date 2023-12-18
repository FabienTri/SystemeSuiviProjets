using System.Collections.Generic;
using System.Text.Json;
using SystemeSuiviProjets.SharedKernel;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core
{
    public class SystèmeFacturationClients : BaseEntity, IAggregateRoot
    {
        public List<string> Documents { get; private set; } = [];
        public void AddDocument(string document)
        {
            Documents.Add(document);
        }
        public void RemoveDocument(string document)
        {
            Documents.Remove(document);
        }
    }
}