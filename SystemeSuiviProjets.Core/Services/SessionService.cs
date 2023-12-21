using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemeSuiviProjets.Core.Interfaces;

namespace SystemeSuiviProjets.Core.Services
{
    public class SessionService : ISessionService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IEmployéRepository _employéRepository;
        private readonly IFeuillePrésenceRepository _feuillePrésenceRepository;
        private readonly IProjetRepository _projetRepository;
        private readonly IUtilisateurRepository _utilisateurRepository;

        public Task<IReadOnlyList<Client>> GetAllClients()
        {
            //Get the list of clients from the database
            //return the list of clients
            return _clientRepository.ListAllAsync();
        }

        public Task<IReadOnlyList<Employé>> GetAllEmployés()
        {
            return _employéRepository.ListAllAsync();
        }

        public Task<IReadOnlyList<FeuillePrésence>> GetAllFeuillesPrésence()
        {
            return _feuillePrésenceRepository.ListAllAsync();
        }

        public Task<IReadOnlyList<Projet>> GetAllProjets()
        {
            return _projetRepository.ListAllAsync();
        }

        public Task<string> GetTypeSession(string username)
        {
            //retieve the type of session with the username from the database
            //return the type of session
            throw new NotImplementedException();
        }

        public Task<bool> ValiderInfoConnexion(string username, string password)
        {
            //retrieve the password from the database with the username
            //compare the password with the password from the database
            //return true if the password is correct
            //return false if the password is incorrect
            throw new NotImplementedException();    
        }
    }
}
