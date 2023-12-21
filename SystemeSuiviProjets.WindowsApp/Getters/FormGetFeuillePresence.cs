using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemeSuiviProjets;

namespace SystemeSuiviProjets
{
    public partial class FormGetFeuillePresence : Form
    {
        public FormGetFeuillePresence()
        {
            InitializeComponent();
        }

        List<FeuillePresence> feuillePresenceList
        {
            get
            {
                return new List<FeuillePresence>()
                {
                    new FeuillePresence(DateTime.Now, DateTime.Now,new Employe("123", "nom", "prenom", DateTime.Now, "adresse", "telephone"), new Projet("nom", DateTime.Now, DateTime.Now, 100)),
                    new FeuillePresence(DateTime.Now, DateTime.Now,new Employe("123", "nom", "prenom", DateTime.Now, "adresse", "telephone"), new Projet("nom", DateTime.Now, DateTime.Now, 100)),
                    new FeuillePresence(DateTime.Now, DateTime.Now,new Employe("123", "nom", "prenom", DateTime.Now, "adresse", "telephone"), new Projet("nom", DateTime.Now, DateTime.Now, 100)),
                    new FeuillePresence(DateTime.Now, DateTime.Now,new Employe("123", "nom", "prenom", DateTime.Now, "adresse", "telephone"), new Projet("nom", DateTime.Now, DateTime.Now, 100)),
                    new FeuillePresence(DateTime.Now, DateTime.Now,new Employe("123", "nom", "prenom", DateTime.Now, "adresse", "telephone"), new Projet("nom", DateTime.Now, DateTime.Now, 100)),
                    new FeuillePresence(DateTime.Now, DateTime.Now,new Employe("123", "nom", "prenom", DateTime.Now, "adresse", "telephone"), new Projet("nom", DateTime.Now, DateTime.Now, 100)),
                    new FeuillePresence(DateTime.Now, DateTime.Now,new Employe("123", "nom", "prenom", DateTime.Now, "adresse", "telephone"), new Projet("nom", DateTime.Now, DateTime.Now, 100)),
                };
            }
        }

        private void FormGetFeuillePresence_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = feuillePresenceList.ToArray();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //form nouvelle feuille présence
            FormSetPresence form9 = new FormSetPresence();
            form9.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGetLignePresence form10 = new FormGetLignePresence();
            form10.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
