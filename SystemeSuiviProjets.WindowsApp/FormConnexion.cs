using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SystemeSuiviProjets.Core;
using SystemeSuiviProjets.Core.Interfaces;

namespace SystemeSuiviProjets
{
    public partial class FormConnexion : Form
    {
        private readonly ISessionService _SessionService;
        private List<Client> listeClients;
        private List<Employé> listeEmployes;
        private List<Projet> listeProjets;
        private bool auth;
        private string typeSession;

        public FormConnexion(ISessionService session)
        {
            InitializeComponent();
            _SessionService = session;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auth = _SessionService.ValiderInfoConnexion(textBoxUsername.Text, textBoxPassword.Text);
            if (auth)
            {
                typeSession = _SessionService.GetTypeSession(textBoxUsername.Text);

                listeProjets = (List<Projet>)_SessionService.GetAllProjets().Result;
                switch (typeSession)
                {
                    case "client":
                        new FormClient(listeProjets).Show();
                        break;
                    case "employé":

                        new FormEmploye(listeProjets).Show();
                        break;
                    case "gestionnaire":

                        listeClients = (List<Client>)_SessionService.GetAllClients().Result;
                        listeEmployes = (List<Employé>)_SessionService.GetAllEmployés().Result;
                        listeProjets = (List<Projet>)_SessionService.GetAllProjets().Result;
                        new FormGestionnaire(listeProjets, listeEmployes, listeClients).Show();
                        break;
                }
            }
        }
    }
}