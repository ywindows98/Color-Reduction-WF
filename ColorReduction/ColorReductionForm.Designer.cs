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
            this.ProcessedPictureBox1 = new System.Windows.Forms.PictureBox();
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            this.ProcessedPictureBox2 = new System.Windows.Forms.PictureBox();
            this.ProcessedPictureBox3 = new System.Windows.Forms.PictureBox();
            this.ProcessedPictureBox4 = new System.Windows.Forms.PictureBox();
            this.NumberOfSamplesTB1 = new System.Windows.Forms.TextBox();
            this.NumberOfSamplesTB2 = new System.Windows.Forms.TextBox();
            this.NumberOfSamplesTB3 = new System.Windows.Forms.TextBox();
            this.NumberOfSamplesTB4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RandomSeedTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UploadedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadButton.Location = new System.Drawing.Point(12, 435);
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
            this.ProcessButton.Location = new System.Drawing.Point(12, 524);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(191, 61);
            this.ProcessButton.TabIndex = 1;
            this.ProcessButton.Text = "Process Image";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // UploadedPictureBox
            // 
            this.UploadedPictureBox.Location = new System.Drawing.Point(12, 41);
            this.UploadedPictureBox.Name = "UploadedPictureBox";
            this.UploadedPictureBox.Size = new System.Drawing.Size(520, 355);
            this.UploadedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UploadedPictureBox.TabIndex = 2;
            this.UploadedPictureBox.TabStop = false;
            // 
            // ProcessedPictureBox1
            // 
            this.ProcessedPictureBox1.Location = new System.Drawing.Point(568, 41);
            this.ProcessedPictureBox1.Name = "ProcessedPictureBox1";
            this.ProcessedPictureBox1.Size = new System.Drawing.Size(520, 355);
            this.ProcessedPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProcessedPictureBox1.TabIndex = 3;
            this.ProcessedPictureBox1.TabStop = false;
            this.ProcessedPictureBox1.Click += new System.EventHandler(this.ProcessedPictureBox_Click);
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(240, 417);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.Size = new System.Drawing.Size(292, 191);
            this.ConsoleTextBox.TabIndex = 4;
            this.ConsoleTextBox.Text = "";
            // 
            // ProcessedPictureBox2
            // 
            this.ProcessedPictureBox2.Location = new System.Drawing.Point(1098, 41);
            this.ProcessedPictureBox2.Name = "ProcessedPictureBox2";
            this.ProcessedPictureBox2.Size = new System.Drawing.Size(520, 355);
            this.ProcessedPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProcessedPictureBox2.TabIndex = 5;
            this.ProcessedPictureBox2.TabStop = false;
            // 
            // ProcessedPictureBox3
            // 
            this.ProcessedPictureBox3.Location = new System.Drawing.Point(568, 402);
            this.ProcessedPictureBox3.Name = "ProcessedPictureBox3";
            this.ProcessedPictureBox3.Size = new System.Drawing.Size(520, 355);
            this.ProcessedPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProcessedPictureBox3.TabIndex = 6;
            this.ProcessedPictureBox3.TabStop = false;
            // 
            // ProcessedPictureBox4
            // 
            this.ProcessedPictureBox4.Location = new System.Drawing.Point(1098, 402);
            this.ProcessedPictureBox4.Name = "ProcessedPictureBox4";
            this.ProcessedPictureBox4.Size = new System.Drawing.Size(520, 355);
            this.ProcessedPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProcessedPictureBox4.TabIndex = 7;
            this.ProcessedPictureBox4.TabStop = false;
            // 
            // NumberOfSamplesTB1
            // 
            this.NumberOfSamplesTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfSamplesTB1.Location = new System.Drawing.Point(399, 670);
            this.NumberOfSamplesTB1.Name = "NumberOfSamplesTB1";
            this.NumberOfSamplesTB1.Size = new System.Drawing.Size(44, 26);
            this.NumberOfSamplesTB1.TabIndex = 8;
            this.NumberOfSamplesTB1.Text = "16";
            // 
            // NumberOfSamplesTB2
            // 
            this.NumberOfSamplesTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfSamplesTB2.Location = new System.Drawing.Point(460, 670);
            this.NumberOfSamplesTB2.Name = "NumberOfSamplesTB2";
            this.NumberOfSamplesTB2.Size = new System.Drawing.Size(44, 26);
            this.NumberOfSamplesTB2.TabIndex = 9;
            this.NumberOfSamplesTB2.Text = "32";
            // 
            // NumberOfSamplesTB3
            // 
            this.NumberOfSamplesTB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfSamplesTB3.Location = new System.Drawing.Point(399, 709);
            this.NumberOfSamplesTB3.Name = "NumberOfSamplesTB3";
            this.NumberOfSamplesTB3.Size = new System.Drawing.Size(44, 26);
            this.NumberOfSamplesTB3.TabIndex = 10;
            this.NumberOfSamplesTB3.Text = "48";
            // 
            // NumberOfSamplesTB4
            // 
            this.NumberOfSamplesTB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfSamplesTB4.Location = new System.Drawing.Point(460, 709);
            this.NumberOfSamplesTB4.Name = "NumberOfSamplesTB4";
            this.NumberOfSamplesTB4.Size = new System.Drawing.Size(44, 26);
            this.NumberOfSamplesTB4.TabIndex = 11;
            this.NumberOfSamplesTB4.Text = "64";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(353, 647);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Number of random points";
            // 
            // RandomSeedTB
            // 
            this.RandomSeedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomSeedTB.Location = new System.Drawing.Point(264, 686);
            this.RandomSeedTB.Name = "RandomSeedTB";
            this.RandomSeedTB.Size = new System.Drawing.Size(87, 29);
            this.RandomSeedTB.TabIndex = 13;
            this.RandomSeedTB.Text = "120";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Random seed:";
            // 
            // ColorReductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 819);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RandomSeedTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfSamplesTB4);
            this.Controls.Add(this.NumberOfSamplesTB3);
            this.Controls.Add(this.NumberOfSamplesTB2);
            this.Controls.Add(this.NumberOfSamplesTB1);
            this.Controls.Add(this.ProcessedPictureBox4);
            this.Controls.Add(this.ProcessedPictureBox3);
            this.Controls.Add(this.ProcessedPictureBox2);
            this.Controls.Add(this.ConsoleTextBox);
            this.Controls.Add(this.ProcessedPictureBox1);
            this.Controls.Add(this.UploadedPictureBox);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.UploadButton);
            this.Name = "ColorReductionForm";
            this.Text = "ColorReductionForm";
            ((System.ComponentModel.ISupportInitialize)(this.UploadedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessedPictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.PictureBox UploadedPictureBox;
        private System.Windows.Forms.PictureBox ProcessedPictureBox1;
        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.PictureBox ProcessedPictureBox2;
        private System.Windows.Forms.PictureBox ProcessedPictureBox3;
        private System.Windows.Forms.PictureBox ProcessedPictureBox4;
        private System.Windows.Forms.TextBox NumberOfSamplesTB1;
        private System.Windows.Forms.TextBox NumberOfSamplesTB2;
        private System.Windows.Forms.TextBox NumberOfSamplesTB3;
        private System.Windows.Forms.TextBox NumberOfSamplesTB4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RandomSeedTB;
        private System.Windows.Forms.Label label2;
    }
}