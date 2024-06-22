namespace ColorReduction
{
    partial class ColorReductionForm
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
            this.UploadButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.UploadedPictureBox = new System.Windows.Forms.PictureBox();
            this.ProcessedPictureBox = new System.Windows.Forms.PictureBox();
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UploadedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadButton.Location = new System.Drawing.Point(178, 484);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(191, 61);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Upload Image";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcessButton.Location = new System.Drawing.Point(778, 484);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(191, 61);
            this.ProcessButton.TabIndex = 1;
            this.ProcessButton.Text = "Process Image";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // UploadedPictureBox
            // 
            this.UploadedPictureBox.Location = new System.Drawing.Point(34, 81);
            this.UploadedPictureBox.Name = "UploadedPictureBox";
            this.UploadedPictureBox.Size = new System.Drawing.Size(520, 355);
            this.UploadedPictureBox.TabIndex = 2;
            this.UploadedPictureBox.TabStop = false;
            // 
            // ProcessedPictureBox
            // 
            this.ProcessedPictureBox.Location = new System.Drawing.Point(595, 81);
            this.ProcessedPictureBox.Name = "ProcessedPictureBox";
            this.ProcessedPictureBox.Size = new System.Drawing.Size(520, 355);
            this.ProcessedPictureBox.TabIndex = 3;
            this.ProcessedPictureBox.TabStop = false;
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(418, 507);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.Size = new System.Drawing.Size(292, 191);
            this.ConsoleTextBox.TabIndex = 4;
            this.ConsoleTextBox.Text = "";
            // 
            // ColorReductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 727);
            this.Controls.Add(this.ConsoleTextBox);
            this.Controls.Add(this.ProcessedPictureBox);
            this.Controls.Add(this.UploadedPictureBox);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.UploadButton);
            this.Name = "ColorReductionForm";
            this.Text = "ColorReductionForm";
            ((System.ComponentModel.ISupportInitialize)(this.UploadedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.PictureBox UploadedPictureBox;
        private System.Windows.Forms.PictureBox ProcessedPictureBox;
        private System.Windows.Forms.RichTextBox ConsoleTextBox;
    }
}