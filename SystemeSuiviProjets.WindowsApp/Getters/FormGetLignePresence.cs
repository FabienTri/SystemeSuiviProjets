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
    public partial class FormGetLignePresence : Form
    {
        public FormGetLignePresence()
        {
            InitializeComponent();
        }

        List<LigneFeuillePresence> ligneFeuillePresences = new List<LigneFeuillePresence>
        {
            new LigneFeuillePresence { typeTarification = "typeTarification", nombreUnites = 1, fraisDeplacement = 1, fraisSejour = 1 },
            new LigneFeuillePresence { typeTarification = "typeTarification", nombreUnites = 1, fraisDeplacement = 1, fraisSejour = 1 },
            new LigneFeuillePresence { typeTarification = "typeTarification", nombreUnites = 1, fraisDeplacement = 1, fraisSejour = 1 },
            new LigneFeuillePresence { typeTarification = "typeTarification", nombreUnites = 1, fraisDeplacement = 1, fraisSejour = 1 },
            new LigneFeuillePresence { typeTarification = "typeTarification", nombreUnites = 1, fraisDeplacement = 1, fraisSejour = 1 },
            new LigneFeuillePresence { typeTarification = "typeTarification", nombreUnites = 1, fraisDeplacement = 1, fraisSejour = 1 },
            new LigneFeuillePresence { typeTarification = "typeTarification", nombreUnites = 1, fraisDeplacement = 1, fraisSejour = 1 },
        };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSetLignePresence formChangePresence = new FormSetLignePresence(new Projet("nom", DateTime.Now, DateTime.Now, 100));
            formChangePresence.ShowDialog();
        }

        private void FormGetLignePresence_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ligneFeuillePresences.ToArray();
        }
    }
}
