namespace ColorReduction
{
    partial class SmootherForm
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
            this.UploadButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.SmoothingStage1Box = new System.Windows.Forms.PictureBox();
            this.SmoothingStage2Box = new System.Windows.Forms.PictureBox();
            this.SmoothingStage3Box = new System.Windows.Forms.PictureBox();
            this.SmoothingStage4Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UploadedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothingStage1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothingStage2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothingStage3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothingStage4Box)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadedPictureBox
            // 
            this.UploadedPictureBox.Location = new System.Drawing.Point(10, 9);
            this.UploadedPictureBox.Name = "UploadedPictureBox";
            this.UploadedPictureBox.Size = new System.Drawing.Size(475, 361);
            this.UploadedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UploadedPictureBox.TabIndex = 0;
            this.UploadedPictureBox.TabStop = false;
            // 
            // UploadButton
            // 
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadButton.Location = new System.Drawing.Point(38, 376);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(191, 61);
            this.UploadButton.TabIndex = 3;
            this.UploadButton.Text = "Upload Image";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessButton.Location = new System.Drawing.Point(271, 376);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(191, 61);
            this.ProcessButton.TabIndex = 4;
            this.ProcessButton.Text = "Process Image";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // SmoothingStage1Box
            // 
            this.SmoothingStage1Box.Location = new System.Drawing.Point(491, 9);
            this.SmoothingStage1Box.Name = "SmoothingStage1Box";
            this.SmoothingStage1Box.Size = new System.Drawing.Size(475, 361);
            this.SmoothingStage1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmoothingStage1Box.TabIndex = 5;
            this.SmoothingStage1Box.TabStop = false;
            // 
            // SmoothingStage2Box
            // 
            this.SmoothingStage2Box.Location = new System.Drawing.Point(973, 9);
            this.SmoothingStage2Box.Name = "SmoothingStage2Box";
            this.SmoothingStage2Box.Size = new System.Drawing.Size(475, 361);
            this.SmoothingStage2Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmoothingStage2Box.TabIndex = 6;
            this.SmoothingStage2Box.TabStop = false;
            // 
            // SmoothingStage3Box
            // 
            this.SmoothingStage3Box.Location = new System.Drawing.Point(491, 376);
            this.SmoothingStage3Box.Name = "SmoothingStage3Box";
            this.SmoothingStage3Box.Size = new System.Drawing.Size(475, 361);
            this.SmoothingStage3Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmoothingStage3Box.TabIndex = 7;
            this.SmoothingStage3Box.TabStop = false;
            // 
            // SmoothingStage4Box
            // 
            this.SmoothingStage4Box.Location = new System.Drawing.Point(973, 376);
            this.SmoothingStage4Box.Name = "SmoothingStage4Box";
            this.SmoothingStage4Box.Size = new System.Drawing.Size(475, 361);
            this.SmoothingStage4Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmoothingStage4Box.TabIndex = 8;
            this.SmoothingStage4Box.TabStop = false;
            // 
            // SmootherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 815);
            this.Controls.Add(this.SmoothingStage4Box);
            this.Controls.Add(this.SmoothingStage3Box);
            this.Controls.Add(this.SmoothingStage2Box);
            this.Controls.Add(this.SmoothingStage1Box);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.UploadedPictureBox);
            this.Name = "SmootherForm";
            this.Text = "SmootherForm";
            ((System.ComponentModel.ISupportInitialize)(this.UploadedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothingStage1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothingStage2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothingStage3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmoothingStage4Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UploadedPictureBox;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.PictureBox SmoothingStage1Box;
        private System.Windows.Forms.PictureBox SmoothingStage2Box;
        private System.Windows.Forms.PictureBox SmoothingStage3Box;
        private System.Windows.Forms.PictureBox SmoothingStage4Box;
    }
}