using System;
using System.Windows.Forms;

namespace SystemeSuiviProjets
{
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();

        }

        FormClient form2 = new FormClient();
        FormEmploye form3 = new FormEmploye();
        FormGestionnaire form4 = new FormGestionnaire();
        FormSetEmploye form5 = new FormSetEmploye();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form4.Show();
        }
    }
}