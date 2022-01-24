
namespace HelloWorld
{
    partial class frmHello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHello));
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.userNameTxtBox = new System.Windows.Forms.TextBox();
            this.greetButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.BackColor = System.Drawing.Color.Transparent;
            this.lblHelloWorld.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHelloWorld.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHelloWorld.Location = new System.Drawing.Point(330, 113);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(270, 49);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello World";
            this.lblHelloWorld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(330, 176);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(270, 64);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "What is your name?";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameTxtBox
            // 
            this.userNameTxtBox.Location = new System.Drawing.Point(330, 256);
            this.userNameTxtBox.Name = "userNameTxtBox";
            this.userNameTxtBox.Size = new System.Drawing.Size(270, 26);
            this.userNameTxtBox.TabIndex = 2;
            // 
            // greetButton
            // 
            this.greetButton.BackColor = System.Drawing.Color.DimGray;
            this.greetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.greetButton.Location = new System.Drawing.Point(368, 357);
            this.greetButton.Name = "greetButton";
            this.greetButton.Size = new System.Drawing.Size(85, 43);
            this.greetButton.TabIndex = 3;
            this.greetButton.Text = "&Greet Me";
            this.greetButton.UseVisualStyleBackColor = false;
            this.greetButton.Click += new System.EventHandler(this.greetButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DimGray;
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(473, 357);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 43);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DimGray;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.exitButton.Location = new System.Drawing.Point(830, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 43);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(330, 299);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(270, 26);
            this.txtNum.TabIndex = 6;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(216, 302);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(108, 19);
            this.lblNum.TabIndex = 7;
            this.lblNum.Text = "Write a number";
            // 
            // frmHello
            // 
            this.AcceptButton = this.greetButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(927, 551);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.greetButton);
            this.Controls.Add(this.userNameTxtBox);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblHelloWorld);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHello";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox userNameTxtBox;
        private System.Windows.Forms.Button greetButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
    }
}

