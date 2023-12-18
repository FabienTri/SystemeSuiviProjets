using System.Collections.Generic;
using System.Text.Json;
using SystemeSuiviProjets.SharedKernel;
using SystemeSuiviProjets.SharedKernel.Interfaces;

namespace SystemeSuiviProjets.Core
{
    public class SystèmeFacturationClients : BaseEntity, IAggregateRoot
    {
        public List<JsonDocument> Documents { get; private set; } = [];
        public void AddDocument(JsonDocument document)
        {
            Documents.Add(document);
        }
        public void RemoveDocument(JsonDocument document)
        {
            Documents.Remove(document);
        }
    }
}