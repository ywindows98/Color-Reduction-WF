namespace ColorReduction
{
    partial class SpecificPointsReductionForm
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
            this.UploadedPictureBox = new System.Windows.Forms.PictureBox();
            this.ProcessedPictureBox = new System.Windows.Forms.PictureBox();
            this.UploadButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.ResetPointsButton = new System.Windows.Forms.Button();
            this.AmountPointsLabel = new System.Windows.Forms.Label();
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UploadedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadedPictureBox
            // 
            this.UploadedPictureBox.Location = new System.Drawing.Point(25, 52);
            this.UploadedPictureBox.Name = "UploadedPictureBox";
            this.UploadedPictureBox.Size = new System.Drawing.Size(637, 437);
            this.UploadedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UploadedPictureBox.TabIndex = 0;
            this.UploadedPictureBox.TabStop = false;
            this.UploadedPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UploadedPictureBox_MouseClick);
            // 
            // ProcessedPictureBox
            // 
            this.ProcessedPictureBox.Location = new System.Drawing.Point(693, 52);
            this.ProcessedPictureBox.Name = "ProcessedPictureBox";
            this.ProcessedPictureBox.Size = new System.Drawing.Size(637, 437);
            this.ProcessedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProcessedPictureBox.TabIndex = 1;
            this.ProcessedPictureBox.TabStop = false;
            // 
            // UploadButton
            // 
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadButton.Location = new System.Drawing.Point(441, 517);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(191, 61);
            this.UploadButton.TabIndex = 2;
            this.UploadButton.Text = "Upload Image";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessButton.Location = new System.Drawing.Point(729, 517);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(191, 61);
            this.ProcessButton.TabIndex = 3;
            this.ProcessButton.Text = "Process Image";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // ResetPointsButton
            // 
            this.ResetPointsButton.BackColor = System.Drawing.Color.IndianRed;
            this.ResetPointsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetPointsButton.Location = new System.Drawing.Point(477, 584);
            this.ResetPointsButton.Name = "ResetPointsButton";
            this.ResetPointsButton.Size = new System.Drawing.Size(155, 50);
            this.ResetPointsButton.TabIndex = 4;
            this.ResetPointsButton.Text = "Reset chosen points";
            this.ResetPointsButton.UseVisualStyleBackColor = false;
            // 
            // AmountPointsLabel
            // 
            this.AmountPointsLabel.AutoSize = true;
            this.AmountPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountPointsLabel.Location = new System.Drawing.Point(25, 554);
            this.AmountPointsLabel.Name = "AmountPointsLabel";
            this.AmountPointsLabel.Size = new System.Drawing.Size(228, 24);
            this.AmountPointsLabel.TabIndex = 7;
            this.AmountPointsLabel.Text = "You have chosen 0 points";
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(945, 504);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.Size = new System.Drawing.Size(292, 191);
            this.ConsoleTextBox.TabIndex = 8;
            this.ConsoleTextBox.Text = "";
            // 
            // SpecificPointsReductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 822);
            this.Controls.Add(this.ConsoleTextBox);
            this.Controls.Add(this.AmountPointsLabel);
            this.Controls.Add(this.ResetPointsButton);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.ProcessedPictureBox);
            this.Controls.Add(this.UploadedPictureBox);
            this.Name = "SpecificPointsReductionForm";
            this.Text = "SpecificPointsReductionForm";
            ((System.ComponentModel.ISupportInitialize)(this.UploadedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UploadedPictureBox;
        private System.Windows.Forms.PictureBox ProcessedPictureBox;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Button ResetPointsButton;
        private System.Windows.Forms.Label AmountPointsLabel;
        private System.Windows.Forms.RichTextBox ConsoleTextBox;
    }
}