using System.Drawing;
using System.Windows.Forms;

namespace SystemeSuiviProjets
{
    partial class FormConnexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Location = new Point(80, 67);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Mot de passe";
            textBox2.Size = new Size(313, 39);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(97, 127);
            button1.Name = "button1";
            button1.Size = new Size(279, 46);
            button1.TabIndex = 2;
            button1.Text = "Se connecter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Bottom;
            textBox3.Location = new Point(80, 18);
            textBox3.Margin = new Padding(5);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Nom d'utilisateur";
            textBox3.Size = new Size(313, 39);
            textBox3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(textBox3, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(474, 179);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(474, 179);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(500, 250);
            MinimumSize = new Size(500, 250);
            Name = "FormConnexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion";
            Load += FormConnexion_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}