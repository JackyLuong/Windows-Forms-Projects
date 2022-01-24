
namespace Temperatures
{
    partial class frmTemperatures
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
            this.lstTemp = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbNewTemp = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumOfTemp = new System.Windows.Forms.TextBox();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.txtLowest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHighest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetCollection = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbNewTemp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTemp
            // 
            this.lstTemp.FormattingEnabled = true;
            this.lstTemp.ItemHeight = 21;
            this.lstTemp.Location = new System.Drawing.Point(763, 115);
            this.lstTemp.Name = "lstTemp";
            this.lstTemp.Size = new System.Drawing.Size(120, 445);
            this.lstTemp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Collected Temperatures";
            // 
            // grbNewTemp
            // 
            this.grbNewTemp.Controls.Add(this.btnClear);
            this.grbNewTemp.Controls.Add(this.btnAdd);
            this.grbNewTemp.Controls.Add(this.txtTemp);
            this.grbNewTemp.Location = new System.Drawing.Point(318, 72);
            this.grbNewTemp.Name = "grbNewTemp";
            this.grbNewTemp.Size = new System.Drawing.Size(286, 148);
            this.grbNewTemp.TabIndex = 2;
            this.grbNewTemp.TabStop = false;
            this.grbNewTemp.Text = "Add Temperatures";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(88, 88);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(7, 43);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(156, 29);
            this.txtTemp.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number Of Temperatures:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Average:";
            // 
            // txtNumOfTemp
            // 
            this.txtNumOfTemp.Location = new System.Drawing.Point(514, 259);
            this.txtNumOfTemp.Name = "txtNumOfTemp";
            this.txtNumOfTemp.Size = new System.Drawing.Size(90, 29);
            this.txtNumOfTemp.TabIndex = 3;
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(514, 298);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(90, 29);
            this.txtAvg.TabIndex = 5;
            // 
            // txtLowest
            // 
            this.txtLowest.Location = new System.Drawing.Point(514, 333);
            this.txtLowest.Name = "txtLowest";
            this.txtLowest.Size = new System.Drawing.Size(90, 29);
            this.txtLowest.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lowest: ";
            // 
            // txtHighest
            // 
            this.txtHighest.Location = new System.Drawing.Point(514, 368);
            this.txtHighest.Name = "txtHighest";
            this.txtHighest.Size = new System.Drawing.Size(90, 29);
            this.txtHighest.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Highest";
            // 
            // btnResetCollection
            // 
            this.btnResetCollection.Location = new System.Drawing.Point(738, 566);
            this.btnResetCollection.Name = "btnResetCollection";
            this.btnResetCollection.Size = new System.Drawing.Size(169, 38);
            this.btnResetCollection.TabIndex = 3;
            this.btnResetCollection.Text = "&Rest Collection";
            this.btnResetCollection.UseVisualStyleBackColor = true;
            this.btnResetCollection.Click += new System.EventHandler(this.btnResetCollection_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(942, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmTemperatures
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResetCollection);
            this.Controls.Add(this.txtHighest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLowest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.txtNumOfTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbNewTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTemp);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTemperatures";
            this.Text = "Monthly Temperatures";
            this.Load += new System.EventHandler(this.frmTemperatures_Load);
            this.grbNewTemp.ResumeLayout(false);
            this.grbNewTemp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbNewTemp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumOfTemp;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.TextBox txtLowest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHighest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResetCollection;
        private System.Windows.Forms.Button btnExit;
    }
}

