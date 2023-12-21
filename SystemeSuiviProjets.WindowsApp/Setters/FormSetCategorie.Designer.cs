using System.Drawing;
using System.Windows.Forms;

namespace SystemeSuiviProjets.Setters
{
    partial class FormSetCategorie
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
            buttonSet = new Button();
            buttonCancel = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelNumero = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
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
            tableLayoutPanel1.Size = new Size(674, 526);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonSet, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 451);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(668, 72);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonSet
            // 
            buttonSet.Anchor = AnchorStyles.Right;
            buttonSet.Location = new Point(181, 13);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(150, 46);
            buttonSet.TabIndex = 0;
            buttonSet.Text = "Confirmer";
            buttonSet.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left;
            buttonCancel.Location = new Point(337, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 46);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Annuler";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel3.Controls.Add(labelNumero, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(label5, 0, 4);
            tableLayoutPanel3.Controls.Add(label6, 0, 5);
            tableLayoutPanel3.Controls.Add(label7, 0, 6);
            tableLayoutPanel3.Controls.Add(label8, 0, 7);
            tableLayoutPanel3.Controls.Add(numericUpDown1, 1, 2);
            tableLayoutPanel3.Controls.Add(numericUpDown2, 1, 3);
            tableLayoutPanel3.Controls.Add(numericUpDown3, 1, 4);
            tableLayoutPanel3.Controls.Add(numericUpDown4, 1, 5);
            tableLayoutPanel3.Controls.Add(numericUpDown5, 1, 6);
            tableLayoutPanel3.Controls.Add(numericUpDown6, 1, 7);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.Size = new Size(668, 442);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(303, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(303, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 39);
            textBox2.TabIndex = 1;
            // 
            // labelNumero
            // 
            labelNumero.Anchor = AnchorStyles.Left;
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(3, 11);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(102, 32);
            labelNumero.TabIndex = 8;
            labelNumero.Text = "Numéro";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 66);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 121);
            label3.Name = "label3";
            label3.Size = new Size(249, 32);
            label3.TabIndex = 10;
            label3.Text = "Tarif facturation heure";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 176);
            label4.Name = "label4";
            label4.Size = new Size(229, 32);
            label4.TabIndex = 11;
            label4.Text = "Tarif facturation jour";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 231);
            label5.Name = "label5";
            label5.Size = new Size(276, 32);
            label5.TabIndex = 12;
            label5.Text = "Tarif facturation semaine";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 286);
            label6.Name = "label6";
            label6.Size = new Size(244, 32);
            label6.TabIndex = 13;
            label6.Text = "Trarif paiement heure";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 341);
            label7.Name = "label7";
            label7.Size = new Size(216, 32);
            label7.TabIndex = 14;
            label7.Text = "Traif paiement jour";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 397);
            label8.Name = "label8";
            label8.Size = new Size(262, 32);
            label8.TabIndex = 15;
            label8.Text = "Tarif paiement semaine";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(303, 118);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 39);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.Tag = "";
            numericUpDown1.ThousandsSeparator = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.Left;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(303, 173);
            numericUpDown2.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(240, 39);
            numericUpDown2.TabIndex = 17;
            numericUpDown2.Tag = "";
            numericUpDown2.ThousandsSeparator = true;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.Left;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Location = new Point(303, 228);
            numericUpDown3.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(240, 39);
            numericUpDown3.TabIndex = 18;
            numericUpDown3.Tag = "";
            numericUpDown3.ThousandsSeparator = true;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Anchor = AnchorStyles.Left;
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown4.Location = new Point(303, 283);
            numericUpDown4.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(240, 39);
            numericUpDown4.TabIndex = 19;
            numericUpDown4.Tag = "";
            numericUpDown4.ThousandsSeparator = true;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Anchor = AnchorStyles.Left;
            numericUpDown5.DecimalPlaces = 2;
            numericUpDown5.Location = new Point(303, 338);
            numericUpDown5.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(240, 39);
            numericUpDown5.TabIndex = 20;
            numericUpDown5.Tag = "";
            numericUpDown5.ThousandsSeparator = true;
            // 
            // numericUpDown6
            // 
            numericUpDown6.Anchor = AnchorStyles.Left;
            numericUpDown6.DecimalPlaces = 2;
            numericUpDown6.Location = new Point(303, 394);
            numericUpDown6.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(240, 39);
            numericUpDown6.TabIndex = 21;
            numericUpDown6.Tag = "";
            numericUpDown6.ThousandsSeparator = true;
            // 
            // FormSetCategorie
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 526);
            Controls.Add(tableLayoutPanel1);
            Name = "FormSetCategorie";
            Text = "FormSetCategory";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonSet;
        private Button buttonCancel;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelNumero;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
    }
}