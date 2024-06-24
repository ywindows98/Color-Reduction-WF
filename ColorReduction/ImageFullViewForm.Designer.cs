namespace ColorReduction
{
    partial class ImageFullViewForm
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
            this.FullPictureBox = new System.Windows.Forms.PictureBox();
            this.SavePointsButton = new System.Windows.Forms.Button();
            this.AmountPointsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FullPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FullPictureBox
            // 
            this.FullPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FullPictureBox.Name = "FullPictureBox";
            this.FullPictureBox.Size = new System.Drawing.Size(473, 358);
            this.FullPictureBox.TabIndex = 0;
            this.FullPictureBox.TabStop = false;
            this.FullPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FullPictureBox_MouseClick);
            // 
            // SavePointsButton
            // 
            this.SavePointsButton.Location = new System.Drawing.Point(257, 381);
            this.SavePointsButton.Name = "SavePointsButton";
            this.SavePointsButton.Size = new System.Drawing.Size(216, 49);
            this.SavePointsButton.TabIndex = 1;
            this.SavePointsButton.Text = "Save";
            this.SavePointsButton.UseVisualStyleBackColor = true;
            this.SavePointsButton.Click += new System.EventHandler(this.SavePointsButton_Click);
            // 
            // AmountPointsLabel
            // 
            this.AmountPointsLabel.AutoSize = true;
            this.AmountPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountPointsLabel.Location = new System.Drawing.Point(12, 391);
            this.AmountPointsLabel.Name = "AmountPointsLabel";
            this.AmountPointsLabel.Size = new System.Drawing.Size(228, 24);
            this.AmountPointsLabel.TabIndex = 8;
            this.AmountPointsLabel.Text = "You have chosen 0 points";
            // 
            // ImageFullViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 442);
            this.Controls.Add(this.AmountPointsLabel);
            this.Controls.Add(this.SavePointsButton);
            this.Controls.Add(this.FullPictureBox);
            this.Name = "ImageFullViewForm";
            this.Text = "ImageFullViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.FullPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FullPictureBox;
        private System.Windows.Forms.Button SavePointsButton;
        private System.Windows.Forms.Label AmountPointsLabel;
    }
}