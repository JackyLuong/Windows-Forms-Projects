
namespace PayRollGUI
{
    partial class frmEmployees
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
            this.lstEmp = new System.Windows.Forms.ListBox();
            this.grbNewEmp = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.radPermanent = new System.Windows.Forms.RadioButton();
            this.radRegular = new System.Windows.Forms.RadioButton();
            this.txtRRSP = new System.Windows.Forms.TextBox();
            this.lblRRSP = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumOfEmp = new System.Windows.Forms.Label();
            this.lblTotalPayRoll = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnResetList = new System.Windows.Forms.Button();
            this.grbNewEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEmp
            // 
            this.lstEmp.FormattingEnabled = true;
            this.lstEmp.ItemHeight = 25;
            this.lstEmp.Location = new System.Drawing.Point(766, 49);
            this.lstEmp.Name = "lstEmp";
            this.lstEmp.Size = new System.Drawing.Size(470, 454);
            this.lstEmp.TabIndex = 0;
            // 
            // grbNewEmp
            // 
            this.grbNewEmp.Controls.Add(this.btnReset);
            this.grbNewEmp.Controls.Add(this.btnAddEmp);
            this.grbNewEmp.Controls.Add(this.radPermanent);
            this.grbNewEmp.Controls.Add(this.radRegular);
            this.grbNewEmp.Controls.Add(this.txtRRSP);
            this.grbNewEmp.Controls.Add(this.lblRRSP);
            this.grbNewEmp.Controls.Add(this.txtRate);
            this.grbNewEmp.Controls.Add(this.label3);
            this.grbNewEmp.Controls.Add(this.txtHours);
            this.grbNewEmp.Controls.Add(this.label2);
            this.grbNewEmp.Controls.Add(this.txtName);
            this.grbNewEmp.Controls.Add(this.label1);
            this.grbNewEmp.Location = new System.Drawing.Point(13, 49);
            this.grbNewEmp.Name = "grbNewEmp";
            this.grbNewEmp.Size = new System.Drawing.Size(498, 497);
            this.grbNewEmp.TabIndex = 1;
            this.grbNewEmp.TabStop = false;
            this.grbNewEmp.Text = "New Employees";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(144, 366);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 41);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(23, 366);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(94, 41);
            this.btnAddEmp.TabIndex = 10;
            this.btnAddEmp.Text = "&Add";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // radPermanent
            // 
            this.radPermanent.AutoSize = true;
            this.radPermanent.Location = new System.Drawing.Point(198, 41);
            this.radPermanent.Name = "radPermanent";
            this.radPermanent.Size = new System.Drawing.Size(121, 29);
            this.radPermanent.TabIndex = 9;
            this.radPermanent.TabStop = true;
            this.radPermanent.Text = "Permanent";
            this.radPermanent.UseVisualStyleBackColor = true;
            this.radPermanent.CheckedChanged += new System.EventHandler(this.radPermanent_CheckedChanged);
            // 
            // radRegular
            // 
            this.radRegular.AutoSize = true;
            this.radRegular.Location = new System.Drawing.Point(23, 41);
            this.radRegular.Name = "radRegular";
            this.radRegular.Size = new System.Drawing.Size(94, 29);
            this.radRegular.TabIndex = 8;
            this.radRegular.TabStop = true;
            this.radRegular.Text = "Regular";
            this.radRegular.UseVisualStyleBackColor = true;
            this.radRegular.CheckedChanged += new System.EventHandler(this.radRegular_CheckedChanged);
            // 
            // txtRRSP
            // 
            this.txtRRSP.Location = new System.Drawing.Point(146, 305);
            this.txtRRSP.Name = "txtRRSP";
            this.txtRRSP.Size = new System.Drawing.Size(107, 33);
            this.txtRRSP.TabIndex = 7;
            this.txtRRSP.Tag = "RRSP %";
            // 
            // lblRRSP
            // 
            this.lblRRSP.AutoSize = true;
            this.lblRRSP.Location = new System.Drawing.Point(23, 305);
            this.lblRRSP.Name = "lblRRSP";
            this.lblRRSP.Size = new System.Drawing.Size(80, 25);
            this.lblRRSP.TabIndex = 6;
            this.lblRRSP.Text = "RRSP %:";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(144, 231);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(107, 33);
            this.txtRate.TabIndex = 5;
            this.txtRate.Tag = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pay Rate:";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(144, 158);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(122, 33);
            this.txtHours.TabIndex = 3;
            this.txtHours.Tag = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hours: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 33);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(766, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Number Of Employees:";
            // 
            // lblNumOfEmp
            // 
            this.lblNumOfEmp.AutoSize = true;
            this.lblNumOfEmp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblNumOfEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumOfEmp.Location = new System.Drawing.Point(977, 521);
            this.lblNumOfEmp.Name = "lblNumOfEmp";
            this.lblNumOfEmp.Size = new System.Drawing.Size(24, 27);
            this.lblNumOfEmp.TabIndex = 14;
            this.lblNumOfEmp.Text = "0";
            // 
            // lblTotalPayRoll
            // 
            this.lblTotalPayRoll.AutoSize = true;
            this.lblTotalPayRoll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTotalPayRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPayRoll.Location = new System.Drawing.Point(977, 565);
            this.lblTotalPayRoll.Name = "lblTotalPayRoll";
            this.lblTotalPayRoll.Size = new System.Drawing.Size(24, 27);
            this.lblTotalPayRoll.TabIndex = 15;
            this.lblTotalPayRoll.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(766, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Total Payroll Amount:";
            // 
            // btnResetList
            // 
            this.btnResetList.Location = new System.Drawing.Point(766, 602);
            this.btnResetList.Name = "btnResetList";
            this.btnResetList.Size = new System.Drawing.Size(108, 32);
            this.btnResetList.TabIndex = 12;
            this.btnResetList.Text = "Reset &List";
            this.btnResetList.UseVisualStyleBackColor = true;
            this.btnResetList.Click += new System.EventHandler(this.btnResetList_Click);
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 750);
            this.Controls.Add(this.btnResetList);
            this.Controls.Add(this.lblTotalPayRoll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNumOfEmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grbNewEmp);
            this.Controls.Add(this.lstEmp);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmEmployees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.grbNewEmp.ResumeLayout(false);
            this.grbNewEmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmp;
        private System.Windows.Forms.GroupBox grbNewEmp;
        private System.Windows.Forms.TextBox txtRRSP;
        private System.Windows.Forms.Label lblRRSP;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.RadioButton radPermanent;
        private System.Windows.Forms.RadioButton radRegular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumOfEmp;
        private System.Windows.Forms.Label lblTotalPayRoll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnResetList;
    }
}

