using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemeSuiviProjets.Core;

namespace SystemeSuiviProjets
{
    public partial class FormSetProject : Form
    {
        Projet projetToChange;
        public FormSetProject()
        {
            InitializeComponent();
            Text = "Ajouter un projet";

        }

        public FormSetProject(Projet projet)
        {
            InitializeComponent();
            Text = "Modifier un projet";
            projetToChange = projet;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if checked then enable datepicker for date fin
            dateTimePicker2.Enabled = checkBox1.Checked;

        }

        private void FormSetProject_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = checkBox1.Checked;

            //display dollar sign in numericupdownbudget
            numericUpDownBudget.Controls[0].Visible = false;


        }



        private void numericUpDownBudget_ValueChanged(object sender, EventArgs e)
        {
            //show new value + dollar sign
            numericUpDownBudget.Text = numericUpDownBudget.Value.ToString() + "$";
            numericUpDownBudget.Controls[1].Text += "$";

        }
    }
}
