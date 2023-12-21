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
    public partial class FormSetProfessionnel : Form
    {
        public FormSetProfessionnel()
        {
            //Fix CS8618
            //employeToChange = new Employe();

            InitializeComponent();
            Text = "Ajouter un professionnel";
        }

        private Professionnel professionnelToChange;

        public FormSetProfessionnel(Professionnel professionnel)
        {
            InitializeComponent();
            Text = "Modifier un professionnel";
            professionnelToChange = professionnel;
        }

        private void FormSetProfessionnel_Load(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Modifier un professionnel":
                    textBoxNom.Text = professionnelToChange.Nom;
                    textBoxPrenom.Text = professionnelToChange.Prénom;
                    textBoxAdresse.Text = professionnelToChange.Adresse;
                    textBoxTelephone.Text = professionnelToChange.Téléphone;
                    dateTimePicker1.Value = professionnelToChange.DateEmbauche.ToDateTime(new TimeOnly(0, 0, 0));
                    break;
                case "Ajouter un professionnel":
                    break;
            }
        }
    }
}
