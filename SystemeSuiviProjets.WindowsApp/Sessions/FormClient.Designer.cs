using System.Drawing;
using System.Windows.Forms;

namespace SystemeSuiviProjets
{
    partial class FormClient
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
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label11 = new Label();
            label10 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonNewProject = new Button();
            buttonModifyProject = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1051, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 111);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label11, 1, 2);
            tableLayoutPanel1.Controls.Add(label10, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 3);
            tableLayoutPanel1.Controls.Add(label9, 1, 0);
            tableLayoutPanel1.Controls.Add(label12, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1354, 174);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(153, 91);
            label11.Name = "label11";
            label11.Size = new Size(254, 32);
            label11.TabIndex = 6;
            label11.Text = "labelAdresseEntreprise";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(153, 48);
            label10.Name = "label10";
            label10.Size = new Size(259, 32);
            label10.TabIndex = 5;
            label10.Text = "labelNuméroEntreprise";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 5);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 0;
            label3.Text = "Entreprise";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 48);
            label6.Name = "label6";
            label6.Size = new Size(102, 32);
            label6.TabIndex = 1;
            label6.Text = "Numéro";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 91);
            label7.Name = "label7";
            label7.Size = new Size(97, 32);
            label7.TabIndex = 2;
            label7.Text = "Adresse";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 135);
            label8.Name = "label8";
            label8.Size = new Size(126, 32);
            label8.TabIndex = 3;
            label8.Text = "Téléphone";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(153, 5);
            label9.Name = "label9";
            label9.Size = new Size(224, 32);
            label9.TabIndex = 4;
            label9.Text = "labelNomEntreprise";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(153, 135);
            label12.Name = "label12";
            label12.Size = new Size(201, 32);
            label12.TabIndex = 7;
            label12.Text = "labelTelEntreprise";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 205);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 187);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1354, 428);
            dataGridView1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonNewProject, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonModifyProject, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 534);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1354, 68);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // buttonNewProject
            // 
            buttonNewProject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNewProject.Location = new Point(417, 10);
            buttonNewProject.Margin = new Padding(3, 10, 10, 3);
            buttonNewProject.Name = "buttonNewProject";
            buttonNewProject.Size = new Size(250, 50);
            buttonNewProject.TabIndex = 0;
            buttonNewProject.Text = "Nouveau projet";
            buttonNewProject.UseVisualStyleBackColor = true;
            buttonNewProject.Click += buttonNewProject_Click;
            // 
            // buttonModifyProject
            // 
            buttonModifyProject.Location = new Point(687, 10);
            buttonModifyProject.Margin = new Padding(10, 10, 3, 3);
            buttonModifyProject.Name = "buttonModifyProject";
            buttonModifyProject.Size = new Size(250, 50);
            buttonModifyProject.TabIndex = 1;
            buttonModifyProject.Text = "Modifier projet";
            buttonModifyProject.UseVisualStyleBackColor = true;
            buttonModifyProject.Click += buttonCloseProject_Click;
            // 
            // FormClient
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1354, 602);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormClient";
            Text = "Outil gestion (Client)";
            Load += FormClient_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label12;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonNewProject;
        private Button buttonModifyProject;
    }
}