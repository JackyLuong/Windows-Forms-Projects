
namespace ChickenOrEggDemo
{
    partial class ChickenOrEgg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChickenOrEgg));
            this.grbChoices = new System.Windows.Forms.GroupBox();
            this.picAnswer = new System.Windows.Forms.PictureBox();
            this.radEgg = new System.Windows.Forms.RadioButton();
            this.radChicken = new System.Windows.Forms.RadioButton();
            this.grbChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // grbChoices
            // 
            this.grbChoices.Controls.Add(this.picAnswer);
            this.grbChoices.Controls.Add(this.radEgg);
            this.grbChoices.Controls.Add(this.radChicken);
            this.grbChoices.Location = new System.Drawing.Point(318, 32);
            this.grbChoices.Name = "grbChoices";
            this.grbChoices.Size = new System.Drawing.Size(257, 138);
            this.grbChoices.TabIndex = 0;
            this.grbChoices.TabStop = false;
            this.grbChoices.Text = "What Was First?";
            // 
            // picAnswer
            // 
            this.picAnswer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAnswer.BackgroundImage")));
            this.picAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAnswer.Location = new System.Drawing.Point(167, 22);
            this.picAnswer.Name = "picAnswer";
            this.picAnswer.Size = new System.Drawing.Size(84, 94);
            this.picAnswer.TabIndex = 2;
            this.picAnswer.TabStop = false;
            // 
            // radEgg
            // 
            this.radEgg.AutoSize = true;
            this.radEgg.Location = new System.Drawing.Point(46, 85);
            this.radEgg.Name = "radEgg";
            this.radEgg.Size = new System.Drawing.Size(45, 19);
            this.radEgg.TabIndex = 1;
            this.radEgg.TabStop = true;
            this.radEgg.Text = "Egg";
            this.radEgg.UseVisualStyleBackColor = true;
            this.radEgg.CheckedChanged += new System.EventHandler(this.radEgg_CheckedChanged);
            // 
            // radChicken
            // 
            this.radChicken.AutoSize = true;
            this.radChicken.Location = new System.Drawing.Point(46, 36);
            this.radChicken.Name = "radChicken";
            this.radChicken.Size = new System.Drawing.Size(68, 19);
            this.radChicken.TabIndex = 0;
            this.radChicken.TabStop = true;
            this.radChicken.Text = "Chicken";
            this.radChicken.UseVisualStyleBackColor = true;
            this.radChicken.CheckedChanged += new System.EventHandler(this.radChicken_CheckedChanged);
            // 
            // ChickenOrEgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbChoices);
            this.Name = "ChickenOrEgg";
            this.Text = "ChickenOrEgg";
            this.grbChoices.ResumeLayout(false);
            this.grbChoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChoices;
        private System.Windows.Forms.RadioButton radEgg;
        private System.Windows.Forms.RadioButton radChicken;
        private System.Windows.Forms.PictureBox picAnswer;
    }
}

