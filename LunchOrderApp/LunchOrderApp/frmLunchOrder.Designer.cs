
namespace LunchOrderApp
{
    partial class frmLunchOrder
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
            this.grbMainCourse = new System.Windows.Forms.GroupBox();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radHamburger = new System.Windows.Forms.RadioButton();
            this.grbAddOns = new System.Windows.Forms.GroupBox();
            this.cbItem3 = new System.Windows.Forms.CheckBox();
            this.cbItem2 = new System.Windows.Forms.CheckBox();
            this.cbItem1 = new System.Windows.Forms.CheckBox();
            this.grbOrder = new System.Windows.Forms.GroupBox();
            this.txtOTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbMainCourse.SuspendLayout();
            this.grbAddOns.SuspendLayout();
            this.grbOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMainCourse
            // 
            this.grbMainCourse.BackColor = System.Drawing.SystemColors.Control;
            this.grbMainCourse.Controls.Add(this.radSalad);
            this.grbMainCourse.Controls.Add(this.radPizza);
            this.grbMainCourse.Controls.Add(this.radHamburger);
            this.grbMainCourse.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.grbMainCourse.Location = new System.Drawing.Point(12, 12);
            this.grbMainCourse.Name = "grbMainCourse";
            this.grbMainCourse.Size = new System.Drawing.Size(217, 157);
            this.grbMainCourse.TabIndex = 0;
            this.grbMainCourse.TabStop = false;
            this.grbMainCourse.Text = "Main Course";
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radSalad.Location = new System.Drawing.Point(16, 94);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(64, 25);
            this.radSalad.TabIndex = 3;
            this.radSalad.TabStop = true;
            this.radSalad.Text = "Salad";
            this.radSalad.UseVisualStyleBackColor = true;
            this.radSalad.CheckedChanged += new System.EventHandler(this.radSalad_CheckedChanged);
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radPizza.Location = new System.Drawing.Point(16, 63);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(62, 25);
            this.radPizza.TabIndex = 2;
            this.radPizza.TabStop = true;
            this.radPizza.Text = "Pizza";
            this.radPizza.UseVisualStyleBackColor = true;
            this.radPizza.CheckedChanged += new System.EventHandler(this.radPizza_CheckedChanged);
            // 
            // radHamburger
            // 
            this.radHamburger.AutoSize = true;
            this.radHamburger.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radHamburger.Location = new System.Drawing.Point(16, 32);
            this.radHamburger.Name = "radHamburger";
            this.radHamburger.Size = new System.Drawing.Size(105, 25);
            this.radHamburger.TabIndex = 1;
            this.radHamburger.TabStop = true;
            this.radHamburger.Text = "Hamburger";
            this.radHamburger.UseVisualStyleBackColor = true;
            this.radHamburger.CheckedChanged += new System.EventHandler(this.radHamburger_CheckedChanged);
            // 
            // grbAddOns
            // 
            this.grbAddOns.BackColor = System.Drawing.SystemColors.Control;
            this.grbAddOns.Controls.Add(this.cbItem3);
            this.grbAddOns.Controls.Add(this.cbItem2);
            this.grbAddOns.Controls.Add(this.cbItem1);
            this.grbAddOns.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.grbAddOns.Location = new System.Drawing.Point(379, 12);
            this.grbAddOns.Name = "grbAddOns";
            this.grbAddOns.Size = new System.Drawing.Size(409, 157);
            this.grbAddOns.TabIndex = 4;
            this.grbAddOns.TabStop = false;
            this.grbAddOns.Text = "Add-On Items";
            // 
            // cbItem3
            // 
            this.cbItem3.AutoSize = true;
            this.cbItem3.Location = new System.Drawing.Point(15, 102);
            this.cbItem3.Name = "cbItem3";
            this.cbItem3.Size = new System.Drawing.Size(116, 29);
            this.cbItem3.TabIndex = 2;
            this.cbItem3.Text = "checkBox3";
            this.cbItem3.UseVisualStyleBackColor = true;
            // 
            // cbItem2
            // 
            this.cbItem2.AutoSize = true;
            this.cbItem2.Location = new System.Drawing.Point(15, 67);
            this.cbItem2.Name = "cbItem2";
            this.cbItem2.Size = new System.Drawing.Size(116, 29);
            this.cbItem2.TabIndex = 1;
            this.cbItem2.Text = "checkBox2";
            this.cbItem2.UseVisualStyleBackColor = true;
            // 
            // cbItem1
            // 
            this.cbItem1.AutoSize = true;
            this.cbItem1.Location = new System.Drawing.Point(15, 32);
            this.cbItem1.Name = "cbItem1";
            this.cbItem1.Size = new System.Drawing.Size(120, 29);
            this.cbItem1.TabIndex = 0;
            this.cbItem1.Text = "CheckBox1";
            this.cbItem1.UseVisualStyleBackColor = true;
            // 
            // grbOrder
            // 
            this.grbOrder.BackColor = System.Drawing.SystemColors.Control;
            this.grbOrder.Controls.Add(this.txtOTotal);
            this.grbOrder.Controls.Add(this.txtTax);
            this.grbOrder.Controls.Add(this.txtSubtotal);
            this.grbOrder.Controls.Add(this.label3);
            this.grbOrder.Controls.Add(this.label2);
            this.grbOrder.Controls.Add(this.label1);
            this.grbOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.grbOrder.Location = new System.Drawing.Point(12, 224);
            this.grbOrder.Name = "grbOrder";
            this.grbOrder.Size = new System.Drawing.Size(409, 192);
            this.grbOrder.TabIndex = 5;
            this.grbOrder.TabStop = false;
            this.grbOrder.Text = "Order Total";
            // 
            // txtOTotal
            // 
            this.txtOTotal.Location = new System.Drawing.Point(164, 136);
            this.txtOTotal.Name = "txtOTotal";
            this.txtOTotal.Size = new System.Drawing.Size(100, 33);
            this.txtOTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(164, 81);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 33);
            this.txtTax.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(164, 32);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 33);
            this.txtSubtotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax (5%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(671, 224);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(116, 37);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "&Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(672, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 37);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(671, 379);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 37);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grbOrder);
            this.Controls.Add(this.grbAddOns);
            this.Controls.Add(this.grbMainCourse);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.grbMainCourse.ResumeLayout(false);
            this.grbMainCourse.PerformLayout();
            this.grbAddOns.ResumeLayout(false);
            this.grbAddOns.PerformLayout();
            this.grbOrder.ResumeLayout(false);
            this.grbOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMainCourse;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.RadioButton radHamburger;
        private System.Windows.Forms.GroupBox grbAddOns;
        private System.Windows.Forms.CheckBox cbItem3;
        private System.Windows.Forms.CheckBox cbItem2;
        private System.Windows.Forms.CheckBox cbItem1;
        private System.Windows.Forms.GroupBox grbOrder;
        private System.Windows.Forms.TextBox txtOTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

