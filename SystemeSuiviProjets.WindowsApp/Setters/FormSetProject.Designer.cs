using System.Drawing;
using System.Windows.Forms;

namespace SystemeSuiviProjets
{
    partial class FormSetProject
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
            textBoxMatricule = new TextBox();
            labelNumero = new Label();
            labelDateDebut = new Label();
            labelBudget = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            tableLayoutPanel4 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            labelDateFin = new Label();
            numericUpDownBudget = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBudget).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.White;
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
            tableLayoutPanel1.Size = new Size(820, 536);
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
            tableLayoutPanel2.Location = new Point(10, 468);
            tableLayoutPanel2.Margin = new Padding(10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(800, 58);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Right;
            buttonConfirm.Location = new Point(242, 6);
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
            buttonCancel.Location = new Point(408, 6);
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
            tableLayoutPanel3.Controls.Add(textBoxMatricule, 1, 0);
            tableLayoutPanel3.Controls.Add(labelNumero, 0, 0);
            tableLayoutPanel3.Controls.Add(labelDateDebut, 0, 1);
            tableLayoutPanel3.Controls.Add(labelBudget, 0, 3);
            tableLayoutPanel3.Controls.Add(dateTimePicker1, 1, 1);
            tableLayoutPanel3.Controls.Add(dateTimePicker2, 1, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel3.Controls.Add(numericUpDownBudget, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(50, 50);
            tableLayoutPanel3.Margin = new Padding(50);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.Size = new Size(720, 358);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // textBoxMatricule
            // 
            textBoxMatricule.Anchor = AnchorStyles.Left;
            textBoxMatricule.Location = new Point(249, 25);
            textBoxMatricule.Name = "textBoxMatricule";
            textBoxMatricule.Size = new Size(400, 39);
            textBoxMatricule.TabIndex = 9;
            // 
            // labelNumero
            // 
            labelNumero.Anchor = AnchorStyles.Left;
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(3, 28);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(102, 32);
            labelNumero.TabIndex = 0;
            labelNumero.Text = "Numéro";
            // 
            // labelDateDebut
            // 
            labelDateDebut.Anchor = AnchorStyles.Left;
            labelDateDebut.AutoSize = true;
            labelDateDebut.Location = new Point(3, 117);
            labelDateDebut.Name = "labelDateDebut";
            labelDateDebut.Size = new Size(134, 32);
            labelDateDebut.TabIndex = 1;
            labelDateDebut.Text = "Date début";
            // 
            // labelBudget
            // 
            labelBudget.Anchor = AnchorStyles.Left;
            labelBudget.AutoSize = true;
            labelBudget.Location = new Point(3, 296);
            labelBudget.Name = "labelBudget";
            labelBudget.Size = new Size(125, 32);
            labelBudget.TabIndex = 3;
            labelBudget.Text = "Budget ($)";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Left;
            dateTimePicker1.Location = new Point(249, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Left;
            dateTimePicker2.Location = new Point(249, 203);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(400, 39);
            dateTimePicker2.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel4.Controls.Add(labelDateFin, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 181);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(240, 83);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Left;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(28, 27);
            checkBox1.TabIndex = 4;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // labelDateFin
            // 
            labelDateFin.Anchor = AnchorStyles.Left;
            labelDateFin.AutoSize = true;
            labelDateFin.Location = new Point(43, 25);
            labelDateFin.Name = "labelDateFin";
            labelDateFin.Size = new Size(103, 32);
            labelDateFin.TabIndex = 3;
            labelDateFin.Text = "Date Fin";
            // 
            // numericUpDownBudget
            // 
            numericUpDownBudget.Anchor = AnchorStyles.Left;
            numericUpDownBudget.CausesValidation = false;
            numericUpDownBudget.DecimalPlaces = 2;
            numericUpDownBudget.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDownBudget.Location = new Point(249, 293);
            numericUpDownBudget.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDownBudget.Name = "numericUpDownBudget";
            numericUpDownBudget.Size = new Size(400, 39);
            numericUpDownBudget.TabIndex = 16;
            numericUpDownBudget.ThousandsSeparator = true;
            numericUpDownBudget.ValueChanged += numericUpDownBudget_ValueChanged;
            // 
            // FormSetProject
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 536);
            Controls.Add(tableLayoutPanel1);
            Name = "FormSetProject";
            Text = "Nouveau projet";
            Load += FormSetProject_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBudget).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonConfirm;
        private Button buttonCancel;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBoxMatricule;
        private Label labelNumero;
        private Label labelDateDebut;
        private Label labelBudget;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TableLayoutPanel tableLayoutPanel4;
        private CheckBox checkBox1;
        private Label labelDateFin;
        private NumericUpDown numericUpDownBudget;
    }
}