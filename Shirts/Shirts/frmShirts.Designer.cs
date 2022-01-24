
namespace Shirts
{
    partial class frmShirts
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
            this.dgvShirts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSum2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSum3 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShirts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShirts
            // 
            this.dgvShirts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvShirts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShirts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvShirts.Location = new System.Drawing.Point(125, 12);
            this.dgvShirts.Name = "dgvShirts";
            this.dgvShirts.RowTemplate.Height = 25;
            this.dgvShirts.Size = new System.Drawing.Size(546, 169);
            this.dgvShirts.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Colour/Size";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "S";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "M";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "L";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "XL";
            this.Column5.Name = "Column5";
            // 
            // txtSum1
            // 
            this.txtSum1.Location = new System.Drawing.Point(376, 187);
            this.txtSum1.Name = "txtSum1";
            this.txtSum1.Size = new System.Drawing.Size(100, 23);
            this.txtSum1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Black Shirts Total Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "White Shirts Total Sold";
            // 
            // txtSum2
            // 
            this.txtSum2.Location = new System.Drawing.Point(376, 229);
            this.txtSum2.Name = "txtSum2";
            this.txtSum2.Size = new System.Drawing.Size(100, 23);
            this.txtSum2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Red Shirts Total Sold";
            // 
            // txtSum3
            // 
            this.txtSum3.Location = new System.Drawing.Point(376, 276);
            this.txtSum3.Name = "txtSum3";
            this.txtSum3.Size = new System.Drawing.Size(100, 23);
            this.txtSum3.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(390, 349);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(379, 320);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(97, 15);
            this.lblWinner.TabIndex = 9;
            this.lblWinner.Text = "Winning Product";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmShirts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSum3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSum2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSum1);
            this.Controls.Add(this.dgvShirts);
            this.Name = "frmShirts";
            this.Text = "Shirt Database";
            this.Load += new System.EventHandler(this.frmShirts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShirts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShirts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtSum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSum3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblWinner;
    }
}

