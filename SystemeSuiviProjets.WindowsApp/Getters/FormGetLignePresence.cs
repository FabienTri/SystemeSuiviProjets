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

namespace SystemeSuiviProjets
{
    public partial class FormGetLignePresence : Form
    {
        public FormGetLignePresence(List<LigneFeuillePrésence> lignesFeuillePresence)
        {
            InitializeComponent();
            this.ligneFeuillePresences = lignesFeuillePresence;
        }

        private List<LigneFeuillePrésence> ligneFeuillePresences;



        /*        private void button2_Click(object sender, EventArgs e)
                {
                    FormSetLignePresence formChangePresence = new FormSetLignePresence(new Projet("nom", DateTime.Now, DateTime.Now, 100));
                    formChangePresence.ShowDialog();
                }
        */
        private void FormGetLignePresence_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ligneFeuillePresences.ToArray();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormSetLignePresence formChangePresence = new FormSetLignePresence();
            formChangePresence.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
