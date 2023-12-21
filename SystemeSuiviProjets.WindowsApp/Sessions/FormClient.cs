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
    public partial class FormClient : Form
    {
        public FormClient(List<Projet> projets)
        {
            InitializeComponent();
            this.projets = projets;
        }

        private List<Projet> projets;


        private void FormClient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = projets.ToArray();
        }

        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            //Ouvre une boite de dialogue pour saisir les informations du projet
            //Ajoute le projet à la liste
            //Affiche le projet dans la liste


        }

        private void buttonCloseProject_Click(object sender, EventArgs e)
        {
            //desactiver tant qu'un element de la liste n'est pas selectionné
            //supprimer l'element selectionné
            //afficher un message de confirmation

            if (dataGridView1.SelectedRows.Count > 0)
            {
                //confirmation
                string nomprojet = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer le projet : " +
                    nomprojet + " ?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    projets.RemoveAt(dataGridView1.SelectedRows[0].Index);
                    dataGridView1.DataSource = projets.ToArray();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un projet à supprimer");
            }

        }
    }
}
