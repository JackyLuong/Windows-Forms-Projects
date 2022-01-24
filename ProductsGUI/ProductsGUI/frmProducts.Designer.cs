
namespace ProductsGUI
{
    partial class frmProducts
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
            this.lstProd = new System.Windows.Forms.ListBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProd
            // 
            this.lstProd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstProd.FormattingEnabled = true;
            this.lstProd.ItemHeight = 21;
            this.lstProd.Location = new System.Drawing.Point(291, 12);
            this.lstProd.Name = "lstProd";
            this.lstProd.Size = new System.Drawing.Size(172, 424);
            this.lstProd.TabIndex = 0;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProd.Location = new System.Drawing.Point(494, 12);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(113, 33);
            this.btnAddProd.TabIndex = 1;
            this.btnAddProd.Text = "Add Product";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Inventory";
            // 
            // txtInventory
            // 
            this.txtInventory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtInventory.Location = new System.Drawing.Point(494, 133);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(100, 23);
            this.txtInventory.TabIndex = 3;
            // 
            // txtProd
            // 
            this.txtProd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtProd.Location = new System.Drawing.Point(494, 79);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(100, 23);
            this.txtProd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Products";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.lstProd);
            this.Name = "frmProducts";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label2;
    }
}

