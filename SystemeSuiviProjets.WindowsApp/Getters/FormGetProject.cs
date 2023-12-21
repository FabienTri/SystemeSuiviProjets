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
    public partial class FormGetProject : Form
    {
        public FormGetProject()
        {
            InitializeComponent();
        }

        List<Employe> employes = new List<Employe>()
        {
            new Employe("1", "Jean", "Dupont", DateTime.Now, "123 rue de la rue", "123456789"),
            new Employe("2", "Jean", "Dupont", DateTime.Now, "123 rue de la rue", "123456789"),
            new Employe("3", "Jean", "Dupont", DateTime.Now, "123 rue de la rue", "123456789"),
            new Employe("4", "Jean", "Dupont", DateTime.Now, "123 rue de la rue", "123456789"),

        };

        private void FormGetProject_Load(object sender, EventArgs e)
        {
            //display matricule, nom et prénom de chaque employé dans le dataGridView1
            dataGridView1.DataSource = employes;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGetFeuillePresence form8 = new FormGetFeuillePresence();
            form8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGetEmploye form12 = new FormGetEmploye();
            form12.Show();
        }
    }
}
