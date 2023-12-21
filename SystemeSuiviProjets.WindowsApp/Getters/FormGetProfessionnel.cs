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
    public partial class FormGetProfessionnel : Form
    {
        private List<Professionnel> professionnels;

        public FormGetProfessionnel(List<Professionnel> professionnels)
        {
            InitializeComponent();
            this.professionnels = professionnels;
        }

        private void FormGetProfessionnel_Load(object sender, EventArgs e)
        {
            //display matricule, nom et prénom de chaque employé dans le checkBoxList1
            foreach (Professionnel professionnel in professionnels)
            {
                checkedListBox1.Items.Add(professionnel.Nom + " " + professionnel.Prénom + " " + professionnel.Adresse + " " + professionnel.DateEmbauche);
            }
        }
    }
}
