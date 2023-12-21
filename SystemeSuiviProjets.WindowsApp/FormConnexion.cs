using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using SystemeSuiviProjets.Core;
using SystemeSuiviProjets.Core.Interfaces;

namespace SystemeSuiviProjets
{
    public partial class FormConnexion : Form
    {
        private readonly ISessionService _SessionService;
        private List<Client> listeClients;
        private List<Professionnel> listeProfessionnel;
        private List<Projet> listeProjets;
        private Utilisateur utilisateur;
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
            try
            {
                utilisateur = _SessionService.ValiderInfoConnexion(textBoxUsername.Text, textBoxPassword.Text);
                if (utilisateur != null)
                {
                    Debug.WriteLine(utilisateur.GetType().Name);
                    typeSession = _SessionService.GetTypeSession(textBoxUsername.Text);

                    listeProjets = (List<Projet>)_SessionService.GetAllProjets().Result;
                    switch (utilisateur.GetType().Name)
                    {
                        case "Client":
                            new FormClient(listeProjets).Show();
                            break;
                        case "Professionnel":
                            new FormProfessionnel(listeProjets).Show();
                            break;
                        case "Gestionnaire":

                            listeClients = (List<Client>)_SessionService.GetAllClients().Result;
                            listeProfessionnel = (List<Professionnel>)_SessionService.GetAllProfessionnels().Result;
                            listeProjets = (List<Projet>)_SessionService.GetAllProjets().Result;
                            new FormGestionnaire(listeProjets, listeProfessionnel, listeClients).Show();
                            break;
                    }
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Exeption : " + exception.Message);

                if (exception.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {exception.InnerException.Message}");
                }
            }
            
        }
    }
}