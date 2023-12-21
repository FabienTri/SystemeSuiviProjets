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
using SystemeSuiviProjets.Setters;

namespace SystemeSuiviProjets
{
    public partial class FormGestionnaire : Form
    {
        public FormGestionnaire(List<Projet> projets, List<Professionnel> professionnels, List<Client> clients)
        {
            InitializeComponent();
            this.projets = projets;
            this.professionnels = professionnels;
            this.clients = clients;
        }

        private List<Projet> projets;
        private List<Professionnel> professionnels;
        private List<Client> clients;

        Boolean buttonPressed = false;




        private void saveButton_Click(object sender, EventArgs e)
        {
            buttonPressed = !buttonPressed;
            textBox2.Enabled = buttonPressed;
            textBox3.Enabled = buttonPressed;
            textBox4.Enabled = buttonPressed;
            textBox5.Enabled = buttonPressed;
            saveButton.Text = buttonPressed ? "Sauvegarder" : "Modifier";
        }

        private void FormGestionnaire_Load(object sender, EventArgs e)
        {
            dataGridViewProjet.DataSource = projets.ToArray();
            dataGridViewProfessionnel.DataSource = professionnels.ToArray();
            dataGridView1.DataSource = clients.ToArray();
        }

        private void buttonSetProfessionnel_Click(object sender, EventArgs e)
        {
            new FormSetProfessionnel().ShowDialog();
        }

        private void buttonGetProfessionnel_Click(object sender, EventArgs e)
        {
            new FormSetProfessionnel(
                //get selected employe
                professionnel: (Professionnel)dataGridViewProfessionnel.SelectedRows[0].DataBoundItem).ShowDialog();

        }

        private void buttonSetProject_Click(object sender, EventArgs e)
        {
            new FormSetProject().ShowDialog();
        }

        private void buttonGetProject_Click(object sender, EventArgs e)
        {
            FormGetProject form11 = new FormGetProject(
                //get projects of selected professionnel
                professionnels: (List<Professionnel>)dataGridViewProfessionnel.SelectedRows[0].DataBoundItem
                );
            form11.Show();
        }

        private void buttonSetClient_Click(object sender, EventArgs e)
        {
            FormSetClient formSetClient = new FormSetClient();
            formSetClient.ShowDialog();
        }

        private void buttonGetClient_Click(object sender, EventArgs e)
        {
            FormSetClient formSetClient = new FormSetClient();
            formSetClient.ShowDialog();
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
