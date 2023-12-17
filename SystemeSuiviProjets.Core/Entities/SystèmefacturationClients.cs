using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class SystèmeFacturationClients : BaseEntity
    {
        public int ClientId { get; set; }
        public Client Client { get; private set; }

        public SystèmeFacturationClients()
        {
            // EF Core needs this one to materialize collections from DB Set
        }

        public SystèmeFacturationClients(Client client)
        {
            ClientId = client.Id;
            Client = client;
        }
    }
}