using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemeSuiviProjets
{
    public partial class FormGestionnaire : Form
    {
        public FormGestionnaire()
        {
            InitializeComponent();
        }

        Boolean buttonPressed = false;
        List<Projet> listeProjets = new List<Projet>
        {
            new Projet ("Projet 1",  DateTime.Now,  DateTime.Now.AddDays(30), 10000),
            new Projet ("Projet 2",  DateTime.Now,  DateTime.Now.AddDays(45), 20000),
        };

        List<Employe> listeEmploye = new List<Employe>
        {
            new Employe (  "1",  "Doe",  "John",  DateTime.Now, "123 rue de la rue", "1234567890" ),
            new Employe (  "2",  "Doe",  "Jane",  DateTime.Now, "123 rue de la rue", "1234567890" ),
            new Employe (  "3",  "Doe",  "John",  DateTime.Now, "123 rue de la rue", "1234567890" ),
            new Employe (  "4",  "Doe",  "Jane",  DateTime.Now, "123 rue de la rue", "1234567890" ),
            new Employe (  "5",  "Doe",  "John",  DateTime.Now, "123 rue de la rue", "1234567890" ),
            new Employe (  "6",  "Doe",  "Jane",  DateTime.Now, "123 rue de la rue", "1234567890" ),
            new Employe (  "7",  "Doe",  "John",  DateTime.Now, "123 rue de la rue", "1234567890" ),
            new Employe (  "8",  "Doe",  "Jane",  DateTime.Now, "123 rue de la rue", "1234567890" ),
        };

        List<Client> listeClient = new List<Client>
        {
            new Client (  "1",  "Doe",  "123 rue de la rue", "1234567890"),
            new Client (  "2",  "Doe",  "123 rue de la rue", "1234567890"),
            new Client (  "3",  "Doe",  "123 rue de la rue", "1234567890")
        };


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
            dataGridViewProjet.DataSource = listeProjets.ToArray();
            dataGridViewEmploye.DataSource = listeEmploye.ToArray();
            dataGridView1.DataSource = listeClient.ToArray();
        }

        private void buttonSetEmploye_Click(object sender, EventArgs e)
        {
            new FormSetEmploye().ShowDialog();
        }

        private void buttonGetEmploye_Click(object sender, EventArgs e)
        {
            new FormSetEmploye(new Employe("1", "Doe", "John", DateTime.Now, "123 rue de la rue", "1234567890")).ShowDialog();

        }

        private void buttonSetProject_Click(object sender, EventArgs e)
        {
            new FormSetProject().ShowDialog();
        }

        private void buttonGetProject_Click(object sender, EventArgs e)
        {
            FormGetProject form11 = new FormGetProject();
            form11.Show();
        }

        private void buttonSetClient_Click(object sender, EventArgs e)
        {
            FormSetClient formSetClient = new FormSetClient();
            formSetClient.ShowDialog();
        }

        private void buttonGetClient_Click(object sender, EventArgs e)
        {
            FormSetClient formSetClient = new FormSetClient(new Client("1", "Doe", "123 rue de la rue", "1234567890"));
            formSetClient.ShowDialog();
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
