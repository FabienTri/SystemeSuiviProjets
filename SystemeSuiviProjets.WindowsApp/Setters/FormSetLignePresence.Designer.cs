using System.Drawing;
using System.Windows.Forms;

namespace SystemeSuiviProjets
{
    partial class FormSetLignePresence
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
            tableLayoutPanel3 = new TableLayoutPanel();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 326F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label7, 0, 3);
            tableLayoutPanel3.Controls.Add(label5, 0, 2);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel3.Controls.Add(numericUpDown1, 1, 1);
            tableLayoutPanel3.Controls.Add(numericUpDown2, 1, 2);
            tableLayoutPanel3.Controls.Add(numericUpDown3, 1, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(50, 50);
            tableLayoutPanel3.Margin = new Padding(50);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel3.Size = new Size(574, 251);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 202);
            label7.Name = "label7";
            label7.Size = new Size(168, 32);
            label7.TabIndex = 6;
            label7.Text = "Frais de séjour";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 139);
            label5.Name = "label5";
            label5.Size = new Size(242, 32);
            label5.TabIndex = 4;
            label5.Text = "Frais de déplacement";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 77);
            label3.Name = "label3";
            label3.Size = new Size(194, 32);
            label3.TabIndex = 2;
            label3.Text = "Nombre d'unités";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 0;
            label1.Text = "Type tarification";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(329, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left;
            numericUpDown1.Location = new Point(329, 73);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 39);
            numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Left;
            numericUpDown2.Location = new Point(329, 135);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(240, 39);
            numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Left;
            numericUpDown3.Location = new Point(329, 199);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(240, 39);
            numericUpDown3.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonConfirm, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 361);
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
            tableLayoutPanel1.Size = new Size(674, 429);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // FormSetLignePresence
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 429);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(700, 500);
            MinimumSize = new Size(700, 500);
            Name = "FormSetLignePresence";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nouvelle ligne présence";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonConfirm;
        private Button buttonCancel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}