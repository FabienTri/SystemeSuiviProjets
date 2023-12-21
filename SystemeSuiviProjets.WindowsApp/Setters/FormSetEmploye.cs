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
    public partial class FormSetEmploye : Form
    {
        public FormSetEmploye()
        {
            //Fix CS8618
            //employeToChange = new Employe();

            InitializeComponent();
            Text = "Ajouter un employé";
        }

        private Employe employeToChange;

        public FormSetEmploye(Employe employe)
        {
            InitializeComponent();
            Text = "Modifier un employé";
            employeToChange = employe;
        }

        private void FormSetEmploye_Load(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Modifier un employé":
                    textBoxMatricule.Text = employeToChange.Matricule;
                    textBoxNom.Text = employeToChange.Nom;
                    textBoxPrenom.Text = employeToChange.Prenom;
                    textBoxAdresse.Text = employeToChange.Adresse;
                    textBoxTelephone.Text = employeToChange.Telephone;
                    dateTimePicker1.Value = employeToChange.DateEmbauche;
                    break;
                case "Ajouter un employé":
                    break;
            }
        }
    }
}
