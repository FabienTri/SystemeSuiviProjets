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
    public partial class FormGetEmploye : Form
    {
        private List<Employé> employes;

        public FormGetEmploye(List<Employé> employes)
        {
            InitializeComponent();
            this.employes = employes;
        }

        private void FormGetEmploye_Load(object sender, EventArgs e)
        {
            //display matricule, nom et prénom de chaque employé dans le checkBoxList1
            foreach (Employé employe in employes)
            {
                checkedListBox1.Items.Add(employe.Nom + " " + employe.Prénom + " " + employe.Adresse + " " + employe.DateEmbauche);
            }
        }
    }
}
