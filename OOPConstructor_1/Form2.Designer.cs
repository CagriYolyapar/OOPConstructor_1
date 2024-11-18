namespace OOPConstructor_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TrbRed = new System.Windows.Forms.TrackBar();
            this.TrbGreen = new System.Windows.Forms.TrackBar();
            this.TrbBlue = new System.Windows.Forms.TrackBar();
            this.BtnForm3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // TrbRed
            // 
            this.TrbRed.Location = new System.Drawing.Point(49, 55);
            this.TrbRed.Maximum = 255;
            this.TrbRed.Name = "TrbRed";
            this.TrbRed.Size = new System.Drawing.Size(573, 56);
            this.TrbRed.TabIndex = 1;
            // 
            // TrbGreen
            // 
            this.TrbGreen.Location = new System.Drawing.Point(49, 168);
            this.TrbGreen.Maximum = 255;
            this.TrbGreen.Name = "TrbGreen";
            this.TrbGreen.Size = new System.Drawing.Size(573, 56);
            this.TrbGreen.TabIndex = 1;
            // 
            // TrbBlue
            // 
            this.TrbBlue.Location = new System.Drawing.Point(49, 290);
            this.TrbBlue.Maximum = 255;
            this.TrbBlue.Name = "TrbBlue";
            this.TrbBlue.Size = new System.Drawing.Size(573, 56);
            this.TrbBlue.TabIndex = 1;
            // 
            // BtnForm3
            // 
            this.BtnForm3.Location = new System.Drawing.Point(676, 398);
            this.BtnForm3.Name = "BtnForm3";
            this.BtnForm3.Size = new System.Drawing.Size(91, 40);
            this.BtnForm3.TabIndex = 2;
            this.BtnForm3.Text = "Form3";
            this.BtnForm3.UseVisualStyleBackColor = true;
            this.BtnForm3.Click += new System.EventHandler(this.BtnForm3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnForm3);
            this.Controls.Add(this.TrbBlue);
            this.Controls.Add(this.TrbGreen);
            this.Controls.Add(this.TrbRed);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.TrbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar TrbRed;
        private System.Windows.Forms.TrackBar TrbGreen;
        private System.Windows.Forms.TrackBar TrbBlue;
        private System.Windows.Forms.Button BtnForm3;
    }
}