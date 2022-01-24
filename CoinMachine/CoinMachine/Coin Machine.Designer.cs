
namespace CoinMachine
{
    partial class Form1
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCents = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToonies = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoonies = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuarters = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNickels = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(355, 76);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 23);
            this.txtUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "userAmount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "cents";
            // 
            // txtCents
            // 
            this.txtCents.Location = new System.Drawing.Point(355, 128);
            this.txtCents.Name = "txtCents";
            this.txtCents.Size = new System.Drawing.Size(100, 23);
            this.txtCents.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toonies";
            // 
            // txtToonies
            // 
            this.txtToonies.Location = new System.Drawing.Point(355, 179);
            this.txtToonies.Name = "txtToonies";
            this.txtToonies.Size = new System.Drawing.Size(100, 23);
            this.txtToonies.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "loonies";
            // 
            // txtLoonies
            // 
            this.txtLoonies.Location = new System.Drawing.Point(355, 226);
            this.txtLoonies.Name = "txtLoonies";
            this.txtLoonies.Size = new System.Drawing.Size(100, 23);
            this.txtLoonies.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "quarters";
            // 
            // txtQuarters
            // 
            this.txtQuarters.Location = new System.Drawing.Point(355, 269);
            this.txtQuarters.Name = "txtQuarters";
            this.txtQuarters.Size = new System.Drawing.Size(100, 23);
            this.txtQuarters.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "dimes";
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(355, 310);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.Size = new System.Drawing.Size(100, 23);
            this.txtDimes.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "nickel";
            // 
            // txtNickels
            // 
            this.txtNickels.Location = new System.Drawing.Point(355, 348);
            this.txtNickels.Name = "txtNickels";
            this.txtNickels.Size = new System.Drawing.Size(100, 23);
            this.txtNickels.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(589, 75);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNickels);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuarters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoonies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToonies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToonies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoonies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuarters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNickels;
        private System.Windows.Forms.Button btnCalc;
    }
}

