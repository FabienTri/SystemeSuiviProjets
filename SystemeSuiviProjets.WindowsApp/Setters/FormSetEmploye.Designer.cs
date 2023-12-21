using System.Drawing;
using System.Windows.Forms;

namespace SystemeSuiviProjets
{
    partial class FormSetEmploye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBoxAdresse = new TextBox();
            textBoxPrenom = new TextBox();
            textBoxNom = new TextBox();
            textBoxMatricule = new TextBox();
            labelMatricule = new Label();
            labelNom = new Label();
            labelPrenom = new Label();
            labelAdresse = new Label();
            labelCategorie = new Label();
            comboBoxCategorie = new ComboBox();
            textBoxTelephone = new TextBox();
            labelTelephone = new Label();
            labelDateEmbauche = new Label();
            dateTimePicker1 = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel1.Size = new Size(774, 529);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonConfirm, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 461);
            tableLayoutPanel2.Margin = new Padding(10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(754, 58);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Right;
            buttonConfirm.Location = new Point(219, 6);
            buttonConfirm.Margin = new Padding(3, 3, 8, 3);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(150, 46);
            buttonConfirm.TabIndex = 0;
            buttonConfirm.Text = "Confirmer";
            buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left;
            buttonCancel.Location = new Point(385, 6);
            buttonCancel.Margin = new Padding(8, 3, 3, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 46);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 246F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(textBoxAdresse, 1, 3);
            tableLayoutPanel3.Controls.Add(textBoxPrenom, 1, 2);
            tableLayoutPanel3.Controls.Add(textBoxNom, 1, 1);
            tableLayoutPanel3.Controls.Add(textBoxMatricule, 1, 0);
            tableLayoutPanel3.Controls.Add(labelMatricule, 0, 0);
            tableLayoutPanel3.Controls.Add(labelNom, 0, 1);
            tableLayoutPanel3.Controls.Add(labelPrenom, 0, 2);
            tableLayoutPanel3.Controls.Add(labelAdresse, 0, 3);
            tableLayoutPanel3.Controls.Add(labelCategorie, 0, 6);
            tableLayoutPanel3.Controls.Add(comboBoxCategorie, 1, 6);
            tableLayoutPanel3.Controls.Add(textBoxTelephone, 1, 4);
            tableLayoutPanel3.Controls.Add(labelTelephone, 0, 4);
            tableLayoutPanel3.Controls.Add(labelDateEmbauche, 0, 5);
            tableLayoutPanel3.Controls.Add(dateTimePicker1, 1, 5);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(50, 25);
            tableLayoutPanel3.Margin = new Padding(50, 25, 50, 25);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.Size = new Size(674, 401);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // textBoxAdresse
            // 
            textBoxAdresse.Anchor = AnchorStyles.Left;
            textBoxAdresse.Location = new Point(249, 180);
            textBoxAdresse.Name = "textBoxAdresse";
            textBoxAdresse.Size = new Size(400, 39);
            textBoxAdresse.TabIndex = 12;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Anchor = AnchorStyles.Left;
            textBoxPrenom.Location = new Point(249, 123);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(400, 39);
            textBoxPrenom.TabIndex = 11;
            // 
            // textBoxNom
            // 
            textBoxNom.Anchor = AnchorStyles.Left;
            textBoxNom.Location = new Point(249, 66);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(400, 39);
            textBoxNom.TabIndex = 10;
            // 
            // textBoxMatricule
            // 
            textBoxMatricule.Anchor = AnchorStyles.Left;
            textBoxMatricule.Location = new Point(249, 9);
            textBoxMatricule.Name = "textBoxMatricule";
            textBoxMatricule.Size = new Size(400, 39);
            textBoxMatricule.TabIndex = 9;
            // 
            // labelMatricule
            // 
            labelMatricule.Anchor = AnchorStyles.Left;
            labelMatricule.AutoSize = true;
            labelMatricule.Location = new Point(3, 12);
            labelMatricule.Name = "labelMatricule";
            labelMatricule.Size = new Size(114, 32);
            labelMatricule.TabIndex = 0;
            labelMatricule.Text = "Matricule";
            // 
            // labelNom
            // 
            labelNom.Anchor = AnchorStyles.Left;
            labelNom.AutoSize = true;
            labelNom.Location = new Point(3, 69);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(67, 32);
            labelNom.TabIndex = 1;
            labelNom.Text = "Nom";
            // 
            // labelPrenom
            // 
            labelPrenom.Anchor = AnchorStyles.Left;
            labelPrenom.AutoSize = true;
            labelPrenom.Location = new Point(3, 126);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(97, 32);
            labelPrenom.TabIndex = 2;
            labelPrenom.Text = "Prénom";
            // 
            // labelAdresse
            // 
            labelAdresse.Anchor = AnchorStyles.Left;
            labelAdresse.AutoSize = true;
            labelAdresse.Location = new Point(3, 183);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(97, 32);
            labelAdresse.TabIndex = 3;
            labelAdresse.Text = "Adresse";
            // 
            // labelCategorie
            // 
            labelCategorie.Anchor = AnchorStyles.Left;
            labelCategorie.AutoSize = true;
            labelCategorie.Location = new Point(3, 355);
            labelCategorie.Name = "labelCategorie";
            labelCategorie.Size = new Size(117, 32);
            labelCategorie.TabIndex = 6;
            labelCategorie.Text = "Catégorie";
            // 
            // comboBoxCategorie
            // 
            comboBoxCategorie.Anchor = AnchorStyles.Left;
            comboBoxCategorie.FormattingEnabled = true;
            comboBoxCategorie.Location = new Point(249, 351);
            comboBoxCategorie.Name = "comboBoxCategorie";
            comboBoxCategorie.Size = new Size(400, 40);
            comboBoxCategorie.TabIndex = 7;
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Anchor = AnchorStyles.Left;
            textBoxTelephone.Location = new Point(249, 237);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(400, 39);
            textBoxTelephone.TabIndex = 13;
            // 
            // labelTelephone
            // 
            labelTelephone.Anchor = AnchorStyles.Left;
            labelTelephone.AutoSize = true;
            labelTelephone.Location = new Point(3, 240);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(126, 32);
            labelTelephone.TabIndex = 5;
            labelTelephone.Text = "Téléphone";
            // 
            // labelDateEmbauche
            // 
            labelDateEmbauche.Anchor = AnchorStyles.Left;
            labelDateEmbauche.AutoSize = true;
            labelDateEmbauche.Location = new Point(3, 297);
            labelDateEmbauche.Name = "labelDateEmbauche";
            labelDateEmbauche.Size = new Size(203, 32);
            labelDateEmbauche.TabIndex = 4;
            labelDateEmbauche.Text = "Date d'embauche";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left;
            dateTimePicker1.Location = new Point(249, 294);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 14;
            // 
            // FormSetEmploye
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 529);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "FormSetEmploye";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += FormSetEmploye_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonConfirm;
        private Button buttonCancel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelMatricule;
        private Label labelNom;
        private Label labelPrenom;
        private Label labelAdresse;
        private Label labelDateEmbauche;
        private Label labelTelephone;
        private TextBox textBoxAdresse;
        private TextBox textBoxPrenom;
        private TextBox textBoxNom;
        private TextBox textBoxMatricule;
        private Label labelCategorie;
        private ComboBox comboBoxCategorie;
        private TextBox textBoxTelephone;
        private DateTimePicker dateTimePicker1;
    }
}