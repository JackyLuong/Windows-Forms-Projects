
namespace tShirtsArray
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
            this.dataGridViewShirts = new System.Windows.Forms.DataGridView();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRow1 = new System.Windows.Forms.TextBox();
            this.textBoxRow2 = new System.Windows.Forms.TextBox();
            this.textBoxRow3 = new System.Windows.Forms.TextBox();
            this.textBoxMaximum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShirts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShirts
            // 
            this.dataGridViewShirts.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewShirts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShirts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S,
            this.M,
            this.L,
            this.XL});
            this.dataGridViewShirts.Location = new System.Drawing.Point(72, 12);
            this.dataGridViewShirts.Name = "dataGridViewShirts";
            this.dataGridViewShirts.RowTemplate.Height = 25;
            this.dataGridViewShirts.Size = new System.Drawing.Size(444, 141);
            this.dataGridViewShirts.TabIndex = 0;
            // 
            // S
            // 
            this.S.HeaderText = "S";
            this.S.Name = "S";
            // 
            // M
            // 
            this.M.HeaderText = "M";
            this.M.Name = "M";
            // 
            // L
            // 
            this.L.HeaderText = "L";
            this.L.Name = "L";
            // 
            // XL
            // 
            this.XL.HeaderText = "XL";
            this.XL.Name = "XL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sum of Black Shirts (Row 1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sum of White Shirts (Row 2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sum of Red Shirts (Row 3)";
            // 
            // textBoxRow1
            // 
            this.textBoxRow1.Location = new System.Drawing.Point(319, 239);
            this.textBoxRow1.Name = "textBoxRow1";
            this.textBoxRow1.Size = new System.Drawing.Size(223, 29);
            this.textBoxRow1.TabIndex = 5;
            // 
            // textBoxRow2
            // 
            this.textBoxRow2.Location = new System.Drawing.Point(319, 295);
            this.textBoxRow2.Name = "textBoxRow2";
            this.textBoxRow2.Size = new System.Drawing.Size(223, 29);
            this.textBoxRow2.TabIndex = 6;
            // 
            // textBoxRow3
            // 
            this.textBoxRow3.Location = new System.Drawing.Point(319, 352);
            this.textBoxRow3.Name = "textBoxRow3";
            this.textBoxRow3.Size = new System.Drawing.Size(223, 29);
            this.textBoxRow3.TabIndex = 7;
            // 
            // textBoxMaximum
            // 
            this.textBoxMaximum.Location = new System.Drawing.Point(50, 419);
            this.textBoxMaximum.Name = "textBoxMaximum";
            this.textBoxMaximum.Size = new System.Drawing.Size(492, 29);
            this.textBoxMaximum.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Location = new System.Drawing.Point(171, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate Statistics";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(577, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMaximum);
            this.Controls.Add(this.textBoxRow3);
            this.Controls.Add(this.textBoxRow2);
            this.Controls.Add(this.textBoxRow1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewShirts);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T-Shirts Sold";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShirts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShirts;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn M;
        private System.Windows.Forms.DataGridViewTextBoxColumn L;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRow1;
        private System.Windows.Forms.TextBox textBoxRow2;
        private System.Windows.Forms.TextBox textBoxRow3;
        private System.Windows.Forms.TextBox textBoxMaximum;
        private System.Windows.Forms.Button button1;
    }
}

