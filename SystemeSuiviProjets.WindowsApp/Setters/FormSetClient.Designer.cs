using System.Drawing;
using System.Windows.Forms;

namespace SystemeSuiviProjets.Setters
{
    partial class FormSetClient
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
            textBoxNom = new TextBox();
            labelNom = new Label();
            labelAdresse = new Label();
            textBoxTelephone = new TextBox();
            labelTelephone = new Label();
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
            tableLayoutPanel1.Size = new Size(674, 329);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonConfirm, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 261);
            tableLayoutPanel2.Margin = new Padding(10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(654, 58);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Right;
            buttonConfirm.Location = new Point(169, 6);
            buttonConfirm.Margin = new Padding(3, 3, 8, 3);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(150, 46);
            buttonConfirm.TabIndex = 0;
            buttonConfirm.Text = "Confirmer";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left;
            buttonCancel.Location = new Point(335, 6);
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
            tableLayoutPanel3.Controls.Add(textBoxAdresse, 1, 1);
            tableLayoutPanel3.Controls.Add(textBoxNom, 1, 0);
            tableLayoutPanel3.Controls.Add(labelNom, 0, 0);
            tableLayoutPanel3.Controls.Add(labelAdresse, 0, 1);
            tableLayoutPanel3.Controls.Add(textBoxTelephone, 1, 2);
            tableLayoutPanel3.Controls.Add(labelTelephone, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(25, 25);
            tableLayoutPanel3.Margin = new Padding(25);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(624, 201);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // textBoxAdresse
            // 
            textBoxAdresse.Anchor = AnchorStyles.Left;
            textBoxAdresse.Location = new Point(249, 80);
            textBoxAdresse.Name = "textBoxAdresse";
            textBoxAdresse.Size = new Size(372, 39);
            textBoxAdresse.TabIndex = 12;
            // 
            // textBoxNom
            // 
            textBoxNom.Anchor = AnchorStyles.Left;
            textBoxNom.Location = new Point(249, 13);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(372, 39);
            textBoxNom.TabIndex = 10;
            // 
            // labelNom
            // 
            labelNom.Anchor = AnchorStyles.Left;
            labelNom.AutoSize = true;
            labelNom.Location = new Point(3, 17);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(67, 32);
            labelNom.TabIndex = 1;
            labelNom.Text = "Nom";
            // 
            // labelAdresse
            // 
            labelAdresse.Anchor = AnchorStyles.Left;
            labelAdresse.AutoSize = true;
            labelAdresse.Location = new Point(3, 83);
            labelAdresse.Name = "labelAdresse";
            labelAdresse.Size = new Size(97, 32);
            labelAdresse.TabIndex = 3;
            labelAdresse.Text = "Adresse";
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Anchor = AnchorStyles.Left;
            textBoxTelephone.Location = new Point(249, 147);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(372, 39);
            textBoxTelephone.TabIndex = 13;
            // 
            // labelTelephone
            // 
            labelTelephone.Anchor = AnchorStyles.Left;
            labelTelephone.AutoSize = true;
            labelTelephone.Location = new Point(3, 151);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(126, 32);
            labelTelephone.TabIndex = 5;
            labelTelephone.Text = "Téléphone";
            // 
            // FormSetClient
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 329);
            Controls.Add(tableLayoutPanel1);
            Name = "FormSetClient";
            Text = "FormSetClient";
            Load += FormSetClient_Load;
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
        private TextBox textBoxAdresse;
        private TextBox textBoxNom;
        private Label labelNom;
        private Label labelAdresse;
        private TextBox textBoxTelephone;
        private Label labelTelephone;
    }
}