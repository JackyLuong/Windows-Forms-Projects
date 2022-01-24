
namespace BankAccountDemo
{
    partial class frmBankAccount
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
            this.lblSelectAcc = new System.Windows.Forms.Label();
            this.lblBalTitle = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.cobAcc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDepo = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectAcc
            // 
            this.lblSelectAcc.AutoSize = true;
            this.lblSelectAcc.Location = new System.Drawing.Point(197, 76);
            this.lblSelectAcc.Name = "lblSelectAcc";
            this.lblSelectAcc.Size = new System.Drawing.Size(86, 15);
            this.lblSelectAcc.TabIndex = 0;
            this.lblSelectAcc.Text = "Select Account";
            // 
            // lblBalTitle
            // 
            this.lblBalTitle.AutoSize = true;
            this.lblBalTitle.Location = new System.Drawing.Point(381, 76);
            this.lblBalTitle.Name = "lblBalTitle";
            this.lblBalTitle.Size = new System.Drawing.Size(96, 15);
            this.lblBalTitle.TabIndex = 1;
            this.lblBalTitle.Text = "Account Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(377, 94);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 23);
            this.txtBalance.TabIndex = 2;
            // 
            // cobAcc
            // 
            this.cobAcc.FormattingEnabled = true;
            this.cobAcc.Location = new System.Drawing.Point(197, 93);
            this.cobAcc.Name = "cobAcc";
            this.cobAcc.Size = new System.Drawing.Size(121, 23);
            this.cobAcc.TabIndex = 3;
            this.cobAcc.SelectedIndexChanged += new System.EventHandler(this.cobAcc_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWithdraw);
            this.groupBox1.Controls.Add(this.btnDepo);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(197, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deposit/Withdraw";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(165, 75);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDepo
            // 
            this.btnDepo.Location = new System.Drawing.Point(30, 75);
            this.btnDepo.Name = "btnDepo";
            this.btnDepo.Size = new System.Drawing.Size(75, 23);
            this.btnDepo.TabIndex = 2;
            this.btnDepo.Text = "Deposit";
            this.btnDepo.UseVisualStyleBackColor = true;
            this.btnDepo.Click += new System.EventHandler(this.btnDepo_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(140, 28);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 23);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Tag = "Amount";
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money Amount";
            // 
            // frmBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cobAcc);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalTitle);
            this.Controls.Add(this.lblSelectAcc);
            this.Name = "frmBankAccount";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBankAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectAcc;
        private System.Windows.Forms.Label lblBalTitle;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.ComboBox cobAcc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDepo;
    }
}

