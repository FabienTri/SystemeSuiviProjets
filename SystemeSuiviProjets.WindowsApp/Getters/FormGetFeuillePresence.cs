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
using SystemeSuiviProjets.Core;

namespace SystemeSuiviProjets
{
    public partial class FormGetFeuillePresence : Form
    {
        public FormGetFeuillePresence(List<FeuillePrésence> feuillesPresence)
        {
            InitializeComponent();
            _ = this.feuillesPresence;
        }

        private List<FeuillePrésence> feuillesPresence;

        private void FormGetFeuillePresence_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = feuillesPresence.ToArray();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //form nouvelle feuille présence
            FormSetPresence form9 = new FormSetPresence();
            form9.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGetLignePresence form10 = new FormGetLignePresence(lignesFeuillePresence: (List<LigneFeuillePrésence>)dataGridView1.SelectedRows[0].DataBoundItem);
            form10.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
