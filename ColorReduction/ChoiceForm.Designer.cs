namespace ColorReduction
{
    partial class ChoiceForm
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
            this.RandomReduceButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SmootherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RandomReduceButton
            // 
            this.RandomReduceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomReduceButton.Location = new System.Drawing.Point(133, 235);
            this.RandomReduceButton.Name = "RandomReduceButton";
            this.RandomReduceButton.Size = new System.Drawing.Size(307, 132);
            this.RandomReduceButton.TabIndex = 0;
            this.RandomReduceButton.Text = "Reduce with random points";
            this.RandomReduceButton.UseVisualStyleBackColor = true;
            this.RandomReduceButton.Click += new System.EventHandler(this.RandomReduceButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(511, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 132);
            this.button2.TabIndex = 1;
            this.button2.Text = "Choose specific points";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SmootherButton
            // 
            this.SmootherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SmootherButton.Location = new System.Drawing.Point(560, 373);
            this.SmootherButton.Name = "SmootherButton";
            this.SmootherButton.Size = new System.Drawing.Size(214, 69);
            this.SmootherButton.TabIndex = 2;
            this.SmootherButton.Text = "Smooth the edges";
            this.SmootherButton.UseVisualStyleBackColor = true;
            this.SmootherButton.Click += new System.EventHandler(this.SmootherButton_Click);
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 615);
            this.Controls.Add(this.SmootherButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RandomReduceButton);
            this.Name = "ChoiceForm";
            this.Text = "ChoiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RandomReduceButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SmootherButton;
    }
}