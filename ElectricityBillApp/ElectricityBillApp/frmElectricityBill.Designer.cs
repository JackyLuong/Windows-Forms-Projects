
namespace ElectricityBillApp
{
    partial class frmElectricityBill
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
            this.cboCustAcc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.txtKWh = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCustAcc
            // 
            this.cboCustAcc.FormattingEnabled = true;
            this.cboCustAcc.Location = new System.Drawing.Point(263, 264);
            this.cboCustAcc.Name = "cboCustAcc";
            this.cboCustAcc.Size = new System.Drawing.Size(146, 23);
            this.cboCustAcc.TabIndex = 0;
            this.cboCustAcc.SelectedIndexChanged += new System.EventHandler(this.cboCustAcc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Account";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtBill);
            this.groupBox1.Controls.Add(this.txtKWh);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(507, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 634);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Electricity Bill Details";
            // 
            // txtBill
            // 
            this.txtBill.Location = new System.Drawing.Point(135, 279);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(140, 31);
            this.txtBill.TabIndex = 7;
            // 
            // txtKWh
            // 
            this.txtKWh.Location = new System.Drawing.Point(135, 189);
            this.txtKWh.Name = "txtKWh";
            this.txtKWh.ReadOnly = true;
            this.txtKWh.Size = new System.Drawing.Size(140, 31);
            this.txtKWh.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(135, 85);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(140, 31);
            this.txtLName.TabIndex = 5;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(135, 43);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(140, 31);
            this.txtFName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bill Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "kWh Used:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddCust.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCust.Location = new System.Drawing.Point(45, 352);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(184, 40);
            this.btnAddCust.TabIndex = 3;
            this.btnAddCust.Text = "&Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStats.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStats.Location = new System.Drawing.Point(45, 422);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(184, 40);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "&Statistics";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(1071, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmElectricityBill
            // 
            this.AcceptButton = this.btnAddCust;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1190, 658);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCustAcc);
            this.Name = "frmElectricityBill";
            this.Text = "Electricity Bill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.TextBox txtKWh;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnExit;
    }
}

