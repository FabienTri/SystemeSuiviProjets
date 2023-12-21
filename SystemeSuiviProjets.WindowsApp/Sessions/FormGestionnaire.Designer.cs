using System.Drawing;
using System.Windows.Forms;

namespace SystemeSuiviProjets
{
    partial class FormGestionnaire
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
            tableLayoutPanel12 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            label19 = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            buttonSetClient = new Button();
            buttonGetClient = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            buttonSetProjet = new Button();
            buttonGetProjet = new Button();
            dataGridViewProjet = new DataGridView();
            label1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            dataGridViewProfessionnel = new DataGridView();
            label2 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            buttonSetEmploye = new Button();
            buttonGetEmploye = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            saveButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel4 = new Panel();
            label17 = new Label();
            label18 = new Label();
            panel3 = new Panel();
            label15 = new Label();
            label16 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            label14 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            rapportsToolStripMenuItem = new ToolStripMenuItem();
            professionnelsToolStripMenuItem = new ToolStripMenuItem();
            exporterToolStripMenuItem = new ToolStripMenuItem();
            imprimerToolStripMenuItem = new ToolStripMenuItem();
            tarifsToolStripMenuItem = new ToolStripMenuItem();
            exporterToolStripMenuItem1 = new ToolStripMenuItem();
            imprimerToolStripMenuItem1 = new ToolStripMenuItem();
            projetsToolStripMenuItem = new ToolStripMenuItem();
            tousToolStripMenuItem = new ToolStripMenuItem();
            exporterToolStripMenuItem2 = new ToolStripMenuItem();
            imprimerToolStripMenuItem2 = new ToolStripMenuItem();
            selectionnerToolStripMenuItem = new ToolStripMenuItem();
            mensuelToolStripMenuItem = new ToolStripMenuItem();
            exporterToolStripMenuItem3 = new ToolStripMenuItem();
            imprimerToolStripMenuItem3 = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            catégoriesProfessionellesToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem1 = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjet).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfessionnel).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel12, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 42);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1774, 1337);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel12.Controls.Add(label19, 0, 0);
            tableLayoutPanel12.Controls.Add(tableLayoutPanel13, 0, 2);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(21, 1028);
            tableLayoutPanel12.Margin = new Padding(20);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 3;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel12.Size = new Size(1732, 288);
            tableLayoutPanel12.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1726, 182);
            dataGridView1.TabIndex = 0;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(139, 50);
            label19.TabIndex = 1;
            label19.Text = "Clients";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.Anchor = AnchorStyles.Right;
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(buttonSetClient, 0, 0);
            tableLayoutPanel13.Controls.Add(buttonGetClient, 1, 0);
            tableLayoutPanel13.Location = new Point(1329, 241);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(400, 44);
            tableLayoutPanel13.TabIndex = 2;
            // 
            // buttonSetClient
            // 
            buttonSetClient.Anchor = AnchorStyles.None;
            buttonSetClient.Location = new Point(25, 3);
            buttonSetClient.Name = "buttonSetClient";
            buttonSetClient.Size = new Size(150, 38);
            buttonSetClient.TabIndex = 0;
            buttonSetClient.Text = "Ajouter";
            buttonSetClient.UseVisualStyleBackColor = true;
            buttonSetClient.Click += buttonSetClient_Click;
            // 
            // buttonGetClient
            // 
            buttonGetClient.Anchor = AnchorStyles.None;
            buttonGetClient.Location = new Point(225, 3);
            buttonGetClient.Name = "buttonGetClient";
            buttonGetClient.Size = new Size(150, 38);
            buttonGetClient.TabIndex = 1;
            buttonGetClient.Text = "Modifier";
            buttonGetClient.UseVisualStyleBackColor = true;
            buttonGetClient.Click += buttonGetClient_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel11, 0, 2);
            tableLayoutPanel2.Controls.Add(dataGridViewProjet, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(21, 372);
            tableLayoutPanel2.Margin = new Padding(20);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.Size = new Size(1732, 287);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = AnchorStyles.Right;
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.Controls.Add(buttonSetProjet, 0, 0);
            tableLayoutPanel11.Controls.Add(buttonGetProjet, 1, 0);
            tableLayoutPanel11.Location = new Point(1329, 240);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(400, 44);
            tableLayoutPanel11.TabIndex = 3;
            // 
            // buttonSetProjet
            // 
            buttonSetProjet.Anchor = AnchorStyles.None;
            buttonSetProjet.Location = new Point(25, 3);
            buttonSetProjet.Name = "buttonSetProjet";
            buttonSetProjet.Size = new Size(150, 38);
            buttonSetProjet.TabIndex = 0;
            buttonSetProjet.Text = "Ajouter";
            buttonSetProjet.UseVisualStyleBackColor = true;
            buttonSetProjet.Click += buttonSetProject_Click;
            // 
            // buttonGetProjet
            // 
            buttonGetProjet.Anchor = AnchorStyles.None;
            buttonGetProjet.Location = new Point(225, 3);
            buttonGetProjet.Name = "buttonGetProjet";
            buttonGetProjet.Size = new Size(150, 38);
            buttonGetProjet.TabIndex = 1;
            buttonGetProjet.Text = "Modifier";
            buttonGetProjet.UseVisualStyleBackColor = true;
            buttonGetProjet.Click += buttonGetClient_Click;
            // 
            // dataGridViewProjet
            // 
            dataGridViewProjet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProjet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProjet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjet.Dock = DockStyle.Fill;
            dataGridViewProjet.Location = new Point(3, 53);
            dataGridViewProjet.Name = "dataGridViewProjet";
            dataGridViewProjet.ReadOnly = true;
            dataGridViewProjet.RowHeadersVisible = false;
            dataGridViewProjet.RowHeadersWidth = 82;
            dataGridViewProjet.RowTemplate.Height = 41;
            dataGridViewProjet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProjet.Size = new Size(1726, 181);
            dataGridViewProjet.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 50);
            label1.TabIndex = 1;
            label1.Text = "Projets";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dataGridViewProfessionnel, 0, 1);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel9, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(21, 700);
            tableLayoutPanel4.Margin = new Padding(20);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1732, 287);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // dataGridViewEmploye
            // 
            dataGridViewProfessionnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProfessionnel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProfessionnel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProfessionnel.Dock = DockStyle.Fill;
            dataGridViewProfessionnel.Location = new Point(3, 53);
            dataGridViewProfessionnel.Name = "dataGridViewEmploye";
            dataGridViewProfessionnel.ReadOnly = true;
            dataGridViewProfessionnel.RowHeadersVisible = false;
            dataGridViewProfessionnel.RowHeadersWidth = 82;
            dataGridViewProfessionnel.RowTemplate.Height = 41;
            dataGridViewProfessionnel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProfessionnel.Size = new Size(1726, 181);
            dataGridViewProfessionnel.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 50);
            label2.TabIndex = 1;
            label2.Text = "Employés";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = AnchorStyles.Right;
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(buttonSetEmploye, 0, 0);
            tableLayoutPanel9.Controls.Add(buttonGetEmploye, 1, 0);
            tableLayoutPanel9.Location = new Point(1329, 240);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(400, 44);
            tableLayoutPanel9.TabIndex = 2;
            // 
            // buttonSetEmploye
            // 
            buttonSetEmploye.Anchor = AnchorStyles.None;
            buttonSetEmploye.Location = new Point(25, 3);
            buttonSetEmploye.Name = "buttonSetEmploye";
            buttonSetEmploye.Size = new Size(150, 38);
            buttonSetEmploye.TabIndex = 0;
            buttonSetEmploye.Text = "Ajouter";
            buttonSetEmploye.UseVisualStyleBackColor = true;
            buttonSetEmploye.Click += buttonSetProfessionnel_Click;
            // 
            // buttonGetEmploye
            // 
            buttonGetEmploye.Anchor = AnchorStyles.None;
            buttonGetEmploye.Location = new Point(225, 3);
            buttonGetEmploye.Name = "buttonGetEmploye";
            buttonGetEmploye.Size = new Size(150, 38);
            buttonGetEmploye.TabIndex = 1;
            buttonGetEmploye.Text = "Modifier";
            buttonGetEmploye.UseVisualStyleBackColor = true;
            buttonGetEmploye.Click += buttonSetProject_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 650F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(4, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1766, 344);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel7.Controls.Add(saveButton, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.MinimumSize = new Size(590, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel7.Size = new Size(644, 338);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 218F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel8.Controls.Add(label4, 0, 4);
            tableLayoutPanel8.Controls.Add(label5, 0, 0);
            tableLayoutPanel8.Controls.Add(label6, 0, 1);
            tableLayoutPanel8.Controls.Add(label8, 0, 5);
            tableLayoutPanel8.Controls.Add(label7, 0, 3);
            tableLayoutPanel8.Controls.Add(label9, 0, 2);
            tableLayoutPanel8.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel8.Controls.Add(textBox4, 1, 5);
            tableLayoutPanel8.Controls.Add(textBox3, 1, 3);
            tableLayoutPanel8.Controls.Add(label10, 1, 0);
            tableLayoutPanel8.Controls.Add(label11, 1, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 6;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel8.Size = new Size(638, 282);
            tableLayoutPanel8.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left;
            textBox5.Enabled = false;
            textBox5.Location = new Point(221, 188);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(352, 39);
            textBox5.TabIndex = 13;
            textBox5.Text = "labelTelephoneEmploye";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 192);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 5;
            label4.Text = "Télephone";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 7);
            label5.Name = "label5";
            label5.Size = new Size(114, 32);
            label5.TabIndex = 0;
            label5.Text = "Matricule";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 54);
            label6.Name = "label6";
            label6.Size = new Size(203, 32);
            label6.TabIndex = 8;
            label6.Text = "Date d'embauche";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 240);
            label8.Name = "label8";
            label8.Size = new Size(97, 32);
            label8.TabIndex = 3;
            label8.Text = "Adresse";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 146);
            label7.Name = "label7";
            label7.Size = new Size(97, 32);
            label7.TabIndex = 2;
            label7.Text = "Prénom";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 100);
            label9.Name = "label9";
            label9.Size = new Size(67, 32);
            label9.TabIndex = 1;
            label9.Text = "Nom";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Enabled = false;
            textBox2.Location = new Point(221, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(352, 39);
            textBox2.TabIndex = 10;
            textBox2.Text = "labelNomEmploye";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            textBox4.Enabled = false;
            textBox4.Location = new Point(221, 237);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(352, 39);
            textBox4.TabIndex = 12;
            textBox4.Text = "labelAdresseEmploye";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Enabled = false;
            textBox3.Location = new Point(221, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(352, 39);
            textBox3.TabIndex = 11;
            textBox3.Text = "labelPrenomEmploye";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(221, 7);
            label10.Name = "label10";
            label10.Size = new Size(257, 32);
            label10.TabIndex = 14;
            label10.Text = "labelMatriculeEmploye";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(221, 54);
            label11.Name = "label11";
            label11.Size = new Size(318, 32);
            label11.TabIndex = 15;
            label11.Text = "labelDateEmbaucheEmploye";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Location = new Point(241, 293);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(162, 40);
            saveButton.TabIndex = 15;
            saveButton.Text = "Modifier";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel4, 1, 1);
            tableLayoutPanel5.Controls.Add(panel3, 0, 1);
            tableLayoutPanel5.Controls.Add(panel2, 1, 0);
            tableLayoutPanel5.Controls.Add(panel1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(653, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(1110, 338);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(25, 130, 196);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label18);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(562, 176);
            panel4.Margin = new Padding(7);
            panel4.Name = "panel4";
            panel4.Size = new Size(541, 155);
            panel4.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(0, 50);
            label17.Name = "label17";
            label17.Size = new Size(369, 71);
            label17.TabIndex = 3;
            label17.Text = "labelNumber";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Top;
            label18.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(0, 0);
            label18.Name = "label18";
            label18.Size = new Size(240, 50);
            label18.TabIndex = 2;
            label18.Text = "Budget total";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(138, 201, 38);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(7, 176);
            panel3.Margin = new Padding(7);
            panel3.Name = "panel3";
            panel3.Size = new Size(541, 155);
            panel3.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(0, 50);
            label15.Name = "label15";
            label15.Size = new Size(369, 71);
            label15.TabIndex = 3;
            label15.Text = "labelNumber";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Top;
            label16.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(377, 50);
            label16.TabIndex = 2;
            label16.Text = "Nombre d'employés";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 202, 58);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(562, 7);
            panel2.Margin = new Padding(7);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 155);
            panel2.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(0, 50);
            label12.Name = "label12";
            label12.Size = new Size(369, 71);
            label12.TabIndex = 1;
            label12.Text = "labelNumber";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(311, 50);
            label3.TabIndex = 0;
            label3.Text = "Projets Terminés";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 89, 94);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(7, 7);
            panel1.Margin = new Padding(7);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 155);
            panel1.TabIndex = 0;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI Black", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(0, 50);
            label13.Name = "label13";
            label13.Size = new Size(369, 71);
            label13.TabIndex = 3;
            label13.Text = "labelNumber";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(300, 50);
            label14.TabIndex = 2;
            label14.Text = "Projets en cours";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Location = new Point(0, 0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(200, 100);
            tableLayoutPanel10.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { rapportsToolStripMenuItem, modifierToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1774, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // rapportsToolStripMenuItem
            // 
            rapportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { professionnelsToolStripMenuItem, tarifsToolStripMenuItem, projetsToolStripMenuItem, mensuelToolStripMenuItem });
            rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            rapportsToolStripMenuItem.Size = new Size(128, 38);
            rapportsToolStripMenuItem.Text = "Rapports";
            // 
            // professionnelsToolStripMenuItem
            // 
            professionnelsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exporterToolStripMenuItem, imprimerToolStripMenuItem });
            professionnelsToolStripMenuItem.Name = "professionnelsToolStripMenuItem";
            professionnelsToolStripMenuItem.Size = new Size(300, 44);
            professionnelsToolStripMenuItem.Text = "Professionnels";
            // 
            // exporterToolStripMenuItem
            // 
            exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            exporterToolStripMenuItem.Size = new Size(259, 44);
            exporterToolStripMenuItem.Text = "Exporter...";
            // 
            // imprimerToolStripMenuItem
            // 
            imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            imprimerToolStripMenuItem.Size = new Size(259, 44);
            imprimerToolStripMenuItem.Text = "Imprimer...";
            // 
            // tarifsToolStripMenuItem
            // 
            tarifsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exporterToolStripMenuItem1, imprimerToolStripMenuItem1 });
            tarifsToolStripMenuItem.Name = "tarifsToolStripMenuItem";
            tarifsToolStripMenuItem.Size = new Size(300, 44);
            tarifsToolStripMenuItem.Text = "Tarifs";
            // 
            // exporterToolStripMenuItem1
            // 
            exporterToolStripMenuItem1.Name = "exporterToolStripMenuItem1";
            exporterToolStripMenuItem1.Size = new Size(259, 44);
            exporterToolStripMenuItem1.Text = "Exporter...";
            // 
            // imprimerToolStripMenuItem1
            // 
            imprimerToolStripMenuItem1.Name = "imprimerToolStripMenuItem1";
            imprimerToolStripMenuItem1.Size = new Size(259, 44);
            imprimerToolStripMenuItem1.Text = "Imprimer...";
            // 
            // projetsToolStripMenuItem
            // 
            projetsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tousToolStripMenuItem, selectionnerToolStripMenuItem });
            projetsToolStripMenuItem.Name = "projetsToolStripMenuItem";
            projetsToolStripMenuItem.Size = new Size(300, 44);
            projetsToolStripMenuItem.Text = "Projets";
            // 
            // tousToolStripMenuItem
            // 
            tousToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exporterToolStripMenuItem2, imprimerToolStripMenuItem2 });
            tousToolStripMenuItem.Name = "tousToolStripMenuItem";
            tousToolStripMenuItem.Size = new Size(295, 44);
            tousToolStripMenuItem.Text = "Tous";
            // 
            // exporterToolStripMenuItem2
            // 
            exporterToolStripMenuItem2.Name = "exporterToolStripMenuItem2";
            exporterToolStripMenuItem2.Size = new Size(259, 44);
            exporterToolStripMenuItem2.Text = "Exporter...";
            // 
            // imprimerToolStripMenuItem2
            // 
            imprimerToolStripMenuItem2.Name = "imprimerToolStripMenuItem2";
            imprimerToolStripMenuItem2.Size = new Size(259, 44);
            imprimerToolStripMenuItem2.Text = "Imprimer...";
            // 
            // selectionnerToolStripMenuItem
            // 
            selectionnerToolStripMenuItem.Name = "selectionnerToolStripMenuItem";
            selectionnerToolStripMenuItem.Size = new Size(295, 44);
            selectionnerToolStripMenuItem.Text = "Selectionner...";
            // 
            // mensuelToolStripMenuItem
            // 
            mensuelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exporterToolStripMenuItem3, imprimerToolStripMenuItem3 });
            mensuelToolStripMenuItem.Name = "mensuelToolStripMenuItem";
            mensuelToolStripMenuItem.Size = new Size(300, 44);
            mensuelToolStripMenuItem.Text = "Mensuel";
            // 
            // exporterToolStripMenuItem3
            // 
            exporterToolStripMenuItem3.Name = "exporterToolStripMenuItem3";
            exporterToolStripMenuItem3.Size = new Size(259, 44);
            exporterToolStripMenuItem3.Text = "Exporter...";
            // 
            // imprimerToolStripMenuItem3
            // 
            imprimerToolStripMenuItem3.Name = "imprimerToolStripMenuItem3";
            imprimerToolStripMenuItem3.Size = new Size(259, 44);
            imprimerToolStripMenuItem3.Text = "Imprimer...";
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catégoriesProfessionellesToolStripMenuItem });
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(125, 38);
            modifierToolStripMenuItem.Text = "Modifier";
            // 
            // catégoriesProfessionellesToolStripMenuItem
            // 
            catégoriesProfessionellesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterToolStripMenuItem, modifierToolStripMenuItem1 });
            catégoriesProfessionellesToolStripMenuItem.Name = "catégoriesProfessionellesToolStripMenuItem";
            catégoriesProfessionellesToolStripMenuItem.Size = new Size(426, 44);
            catégoriesProfessionellesToolStripMenuItem.Text = "Catégories professionelles";
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(359, 44);
            ajouterToolStripMenuItem.Text = "Ajouter...";
            // 
            // modifierToolStripMenuItem1
            // 
            modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            modifierToolStripMenuItem1.Size = new Size(359, 44);
            modifierToolStripMenuItem1.Text = "Modifier...";
            // 
            // FormGestionnaire
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1774, 1379);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormGestionnaire";
            Text = "Outil gestion (Gestionnaire)";
            Load += FormGestionnaire_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjet).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfessionnel).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridViewProjet;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridViewProfessionnel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label10;
        private Label label11;
        private Button saveButton;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel11;
        private Button buttonSetProjet;
        private Button buttonGetProjet;
        private TableLayoutPanel tableLayoutPanel9;
        private Button buttonSetEmploye;
        private Button buttonGetEmploye;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label17;
        private Label label18;
        private Label label15;
        private Label label16;
        private Label label12;
        private Label label3;
        private Label label13;
        private Label label14;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem rapportsToolStripMenuItem;
        private ToolStripMenuItem professionnelsToolStripMenuItem;
        private ToolStripMenuItem tarifsToolStripMenuItem;
        private ToolStripMenuItem projetsToolStripMenuItem;
        private ToolStripMenuItem exporterToolStripMenuItem;
        private ToolStripMenuItem imprimerToolStripMenuItem;
        private ToolStripMenuItem exporterToolStripMenuItem1;
        private ToolStripMenuItem imprimerToolStripMenuItem1;
        private ToolStripMenuItem tousToolStripMenuItem;
        private ToolStripMenuItem exporterToolStripMenuItem2;
        private ToolStripMenuItem imprimerToolStripMenuItem2;
        private ToolStripMenuItem selectionnerToolStripMenuItem;
        private ToolStripMenuItem mensuelToolStripMenuItem;
        private ToolStripMenuItem exporterToolStripMenuItem3;
        private ToolStripMenuItem imprimerToolStripMenuItem3;
        private TableLayoutPanel tableLayoutPanel12;
        private DataGridView dataGridView1;
        private Label label19;
        private TableLayoutPanel tableLayoutPanel13;
        private Button buttonSetClient;
        private Button buttonGetClient;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem catégoriesProfessionellesToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem1;
    }
}