
namespace DeckShuffleApp
{
    partial class frmDeck
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
            this.lstDeck = new System.Windows.Forms.ListBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDeck
            // 
            this.lstDeck.FormattingEnabled = true;
            this.lstDeck.ItemHeight = 15;
            this.lstDeck.Location = new System.Drawing.Point(23, 13);
            this.lstDeck.Name = "lstDeck";
            this.lstDeck.Size = new System.Drawing.Size(120, 409);
            this.lstDeck.TabIndex = 0;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(180, 13);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // frmDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lstDeck);
            this.Name = "frmDeck";
            this.Text = "Deck Shuffle";
            this.Load += new System.EventHandler(this.frmDeck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDeck;
        private System.Windows.Forms.Button btnShuffle;
    }
}

