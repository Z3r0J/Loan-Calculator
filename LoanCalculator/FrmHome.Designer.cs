﻿
namespace LoanCalculator
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.Lbltitle = new System.Windows.Forms.Label();
            this.lblAmountLoan = new System.Windows.Forms.Label();
            this.LblAmountofDues = new System.Windows.Forms.Label();
            this.TxtLoanAmount = new System.Windows.Forms.TextBox();
            this.CbxMonthlyDues = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblAnualInterestRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PbxIcon = new System.Windows.Forms.PictureBox();
            this.PbxClose = new System.Windows.Forms.PictureBox();
            this.pnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(149)))));
            this.pnPrincipal.Controls.Add(this.PbxClose);
            this.pnPrincipal.Controls.Add(this.PbxIcon);
            this.pnPrincipal.Controls.Add(this.Lbltitle);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(376, 37);
            this.pnPrincipal.TabIndex = 0;
            this.pnPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnPrincipal_MouseDown);
            // 
            // Lbltitle
            // 
            this.Lbltitle.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbltitle.ForeColor = System.Drawing.Color.White;
            this.Lbltitle.Location = new System.Drawing.Point(41, 4);
            this.Lbltitle.Name = "Lbltitle";
            this.Lbltitle.Size = new System.Drawing.Size(178, 27);
            this.Lbltitle.TabIndex = 0;
            this.Lbltitle.Text = "Personal Loan Calculator";
            // 
            // lblAmountLoan
            // 
            this.lblAmountLoan.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmountLoan.ForeColor = System.Drawing.Color.White;
            this.lblAmountLoan.Location = new System.Drawing.Point(13, 57);
            this.lblAmountLoan.Name = "lblAmountLoan";
            this.lblAmountLoan.Size = new System.Drawing.Size(89, 24);
            this.lblAmountLoan.TabIndex = 1;
            this.lblAmountLoan.Text = "Loan Amount: ";
            // 
            // LblAmountofDues
            // 
            this.LblAmountofDues.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAmountofDues.ForeColor = System.Drawing.Color.White;
            this.LblAmountofDues.Location = new System.Drawing.Point(13, 99);
            this.LblAmountofDues.Name = "LblAmountofDues";
            this.LblAmountofDues.Size = new System.Drawing.Size(148, 26);
            this.LblAmountofDues.TabIndex = 2;
            this.LblAmountofDues.Text = "Monthly amount of dues: ";
            // 
            // TxtLoanAmount
            // 
            this.TxtLoanAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLoanAmount.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLoanAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.TxtLoanAmount.Location = new System.Drawing.Point(108, 57);
            this.TxtLoanAmount.Multiline = true;
            this.TxtLoanAmount.Name = "TxtLoanAmount";
            this.TxtLoanAmount.Size = new System.Drawing.Size(237, 24);
            this.TxtLoanAmount.TabIndex = 3;
            // 
            // CbxMonthlyDues
            // 
            this.CbxMonthlyDues.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CbxMonthlyDues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMonthlyDues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbxMonthlyDues.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxMonthlyDues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.CbxMonthlyDues.FormattingEnabled = true;
            this.CbxMonthlyDues.Location = new System.Drawing.Point(167, 99);
            this.CbxMonthlyDues.Name = "CbxMonthlyDues";
            this.CbxMonthlyDues.Size = new System.Drawing.Size(178, 26);
            this.CbxMonthlyDues.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.textBox1.Location = new System.Drawing.Point(167, 185);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(178, 24);
            this.textBox1.TabIndex = 5;
            // 
            // LblAnualInterestRate
            // 
            this.LblAnualInterestRate.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAnualInterestRate.ForeColor = System.Drawing.Color.White;
            this.LblAnualInterestRate.Location = new System.Drawing.Point(13, 185);
            this.LblAnualInterestRate.Name = "LblAnualInterestRate";
            this.LblAnualInterestRate.Size = new System.Drawing.Size(148, 24);
            this.LblAnualInterestRate.TabIndex = 6;
            this.LblAnualInterestRate.Text = "Annual interest rate (%): ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type of Loan: ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 26);
            this.comboBox1.TabIndex = 8;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.AutoEllipsis = true;
            this.BtnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(76)))));
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalculate.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCalculate.ForeColor = System.Drawing.Color.White;
            this.BtnCalculate.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalculate.Image")));
            this.BtnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalculate.Location = new System.Drawing.Point(249, 230);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(96, 40);
            this.BtnCalculate.TabIndex = 9;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCalculate.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bodoni MT Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Monthly Dues: ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(221)))), ((int)(((byte)(215)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(46)))), ((int)(((byte)(119)))));
            this.textBox2.Location = new System.Drawing.Point(167, 290);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(178, 24);
            this.textBox2.TabIndex = 10;
            // 
            // PbxIcon
            // 
            this.PbxIcon.Image = ((System.Drawing.Image)(resources.GetObject("PbxIcon.Image")));
            this.PbxIcon.Location = new System.Drawing.Point(1, 2);
            this.PbxIcon.Name = "PbxIcon";
            this.PbxIcon.Size = new System.Drawing.Size(39, 33);
            this.PbxIcon.TabIndex = 1;
            this.PbxIcon.TabStop = false;
            // 
            // PbxClose
            // 
            this.PbxClose.Location = new System.Drawing.Point(344, 7);
            this.PbxClose.Name = "PbxClose";
            this.PbxClose.Size = new System.Drawing.Size(24, 24);
            this.PbxClose.TabIndex = 2;
            this.PbxClose.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(376, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblAnualInterestRate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CbxMonthlyDues);
            this.Controls.Add(this.TxtLoanAmount);
            this.Controls.Add(this.LblAmountofDues);
            this.Controls.Add(this.lblAmountLoan);
            this.Controls.Add(this.pnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.pnPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Label lblAmountLoan;
        private System.Windows.Forms.Label LblAmountofDues;
        private System.Windows.Forms.TextBox TxtLoanAmount;
        private System.Windows.Forms.ComboBox CbxMonthlyDues;
        private System.Windows.Forms.Label Lbltitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblAnualInterestRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox PbxIcon;
        private System.Windows.Forms.PictureBox PbxClose;
    }
}

