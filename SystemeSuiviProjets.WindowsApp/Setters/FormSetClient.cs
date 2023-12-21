using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemeSuiviProjets.Core;

namespace SystemeSuiviProjets.Setters
{
    public partial class FormSetClient : Form
    {
        public FormSetClient()
        {
            InitializeComponent();
            Text = "Ajouter un client";
        }
        private Client client;
        public FormSetClient(Client client)
        {
            InitializeComponent();
            Text = "Modifier un client";
            this.client = client;
        }

        private void FormSetClient_Load(object sender, EventArgs e)
        {

            switch (Text)
            {
                case "Modifier un client":
                    textBoxNom.Text = client.NomCompagnie;
                    textBoxAdresse.Text = client.Adresse;
                    textBoxTelephone.Text = client.Téléphone;
                    break;
                case "Ajouter un client":
                    break;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Modifier un client":
                    client.NomCompagnie = textBoxNom.Text;
                    client.Adresse = textBoxAdresse.Text;
                    client.Téléphone = textBoxTelephone.Text;
                    break;
                case "Ajouter un client":
                    break;
            }
        }
    }
}
