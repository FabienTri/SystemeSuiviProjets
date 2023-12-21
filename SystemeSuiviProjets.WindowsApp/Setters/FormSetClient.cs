using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    textBoxNumero.Text = client.Numero;
                    textBoxNom.Text = client.Nom;
                    textBoxAdresse.Text = client.Adresse;
                    textBoxTelephone.Text = client.Telephone;
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
                    client.Numero = textBoxNumero.Text;
                    client.Nom = textBoxNom.Text;
                    client.Adresse = textBoxAdresse.Text;
                    client.Telephone = textBoxTelephone.Text;
                    break;
                case "Ajouter un client":
                    client = new Client(textBoxNumero.Text, textBoxNom.Text, textBoxAdresse.Text, textBoxTelephone.Text);
                    break;
            }
        }
    }
}
