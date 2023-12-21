using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemeSuiviProjets.Core.Interfaces;

namespace SystemeSuiviProjets.Core.Services
{
    public class SessionService(IClientRepository clientRepository, IProfessionnelRepository professionnelRepository,
        IFeuillePrésenceRepository feuillePrésenceRepository, IProjetRepository projetRepository,
        IUtilisateurRepository utilisateurRepository) : ISessionService
    {
        private readonly IClientRepository _clientRepository = clientRepository;
        private readonly IProfessionnelRepository _professionnelRepository = professionnelRepository;
        private readonly IFeuillePrésenceRepository _feuillePrésenceRepository = feuillePrésenceRepository;
        private readonly IProjetRepository _projetRepository = projetRepository;
        private readonly IUtilisateurRepository _utilisateurRepository = utilisateurRepository;

        public Task<IReadOnlyList<Client>> GetAllClients()
        {
            //Get the list of clients from the database
            //return the list of clients
            return _clientRepository.ListAllAsync();
        }

        public Task<IReadOnlyList<Professionnel>> GetAllProfessionnels()
        {
            return _professionnelRepository.ListAllAsync();
        }

        public Task<IReadOnlyList<FeuillePrésence>> GetAllFeuillesPrésence()
        {
            return _feuillePrésenceRepository.ListAllAsync();
        }

        public Task<IReadOnlyList<Projet>> GetAllProjets()
        {
            return _projetRepository.ListAllAsync();
        }

        public string GetTypeSession(string username)
        {
            //retieve the type of session with the username from the database
            //return the type of session
            throw new NotImplementedException();
        }

        public Utilisateur ValiderInfoConnexion(string username, string password)
        {
            Utilisateur utilisateur = _utilisateurRepository.GetByNomConnexionWithSessions(username);

            if (utilisateur != null && utilisateur.MotDePasse == password)
            {
                return utilisateur;
            }
            return null;
        }
    }
}
