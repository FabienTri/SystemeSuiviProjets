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
    public partial class FormSetEmploye : Form
    {
        public FormSetEmploye()
        {
            //Fix CS8618
            //employeToChange = new Employe();

            InitializeComponent();
            Text = "Ajouter un employé";
        }

        private Employé employeToChange;

        public FormSetEmploye(Employé employe)
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
                    textBoxNom.Text = employeToChange.Nom;
                    textBoxPrenom.Text = employeToChange.Prénom;
                    textBoxAdresse.Text = employeToChange.Adresse;
                    textBoxTelephone.Text = employeToChange.Téléphone;
                    dateTimePicker1.Value = employeToChange.DateEmbauche.ToDateTime(new TimeOnly(0, 0, 0));
                    break;
                case "Ajouter un employé":
                    break;
            }
        }
    }
}
