using SystemeSuiviProjets.SharedKernel;

namespace SystemeSuiviProjets.Core
{
    public class SystèmeFacturationClients(Client client) : BaseEntity
    {
        public int ClientId { get; set; } = client.Id;
        public Client Client { get; private set; } = client;
    }
}