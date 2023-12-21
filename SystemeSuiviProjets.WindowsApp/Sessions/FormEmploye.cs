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
    public partial class FormEmploye : Form
    {
        public FormEmploye()
        {
            InitializeComponent();
        }

        Boolean buttonPressed = false;
        List<Projet> listeProjets = new List<Projet>
        {
            new Projet ("Projet 1",  DateTime.Now,  DateTime.Now.AddDays(30), 10000),
            new Projet ("Projet 2",  DateTime.Now,  DateTime.Now.AddDays(45), 20000),
            new Projet ("Projet 3",  DateTime.Now,  DateTime.Now.AddDays(45), 30000),


        };


        private void saveButton_Click(object sender, EventArgs e)
        {
            buttonPressed = !buttonPressed;
            textBox2.Enabled = buttonPressed;
            textBox3.Enabled = buttonPressed;
            textBox4.Enabled = buttonPressed;
            textBox5.Enabled = buttonPressed;
            saveButton.Text = buttonPressed ? "Sauvegarder" : "Modifier";
        }

        private void FormEmploye_Load(object sender, EventArgs e)
        {
            chartPresence.Series.Clear(); // Efface les données du graphique

            // Configure le titre du graphique
            chartPresence.Titles.Add("Présence par projet");

            // Ajoute une série au graphique
            chartPresence.Series.Add("Heures travaillées");

            chartPresence.Series["Heures travaillées"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartPresence.Series["Heures travaillées"].Points.AddXY("Projet 1 (h)", 10);
            chartPresence.Series["Heures travaillées"].Points.AddXY("Projet 2 (h)", 20);
            chartPresence.Series["Heures travaillées"].Points.AddXY("Projet 3 (h)", 30);

            chartPresence.Series["Heures travaillées"].IsValueShownAsLabel = true;
            dataGridView1.DataSource = listeProjets.ToArray();
        }

        private void buttonAddPresence_Click(object sender, EventArgs e)
        {
            FormGetFeuillePresence form8 = new FormGetFeuillePresence();
            form8.ShowDialog();
        }
    }
}
