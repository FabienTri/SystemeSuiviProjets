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
    public partial class FormSetLignePresence : Form
    {

        Projet projet;
        public FormSetLignePresence(Projet projet)
        {
            InitializeComponent();
            this.projet = projet;
        }

        FeuillePresence FeuillePresence = new FeuillePresence(DateTime.Now, DateTime.Now, new Employe("123", "nom", "prenom", DateTime.Now, "adresse", "telephone"), new Projet("nom", DateTime.Now, DateTime.Now, 100));


    }
}
