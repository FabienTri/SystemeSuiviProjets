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
    public partial class FormGetProject : Form
    {
        public FormGetProject(List<Employé> employes)
        {
            InitializeComponent();
            this.employes = employes;
        }

        private List<Employé> employes;

        private void FormGetProject_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employes;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGetFeuillePresence form8 = new FormGetFeuillePresence(
                //get feuilles de présence de l'employé sélectionné
                feuillesPresence: (List<FeuillePrésence>)dataGridView1.SelectedRows[0].DataBoundItem
                );
            form8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGetEmploye form12 = new FormGetEmploye(
                //get employés du projet sélectionné
                employes: (List<Employé>)dataGridView1.SelectedRows[0].DataBoundItem
                );
            form12.Show();
        }
    }
}
