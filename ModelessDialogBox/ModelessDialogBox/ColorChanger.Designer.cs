namespace ModelessDialogBox
{
    partial class ColorChanger
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
            this.redButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(37, 44);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(45, 17);
            this.redButton.TabIndex = 0;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.CheckedChanged += new System.EventHandler(this.redButton_CheckedChanged);
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(37, 77);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(46, 17);
            this.blueButton.TabIndex = 1;
            this.blueButton.TabStop = true;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            this.blueButton.CheckedChanged += new System.EventHandler(this.blueButton_CheckedChanged);
            // 
            // greenButton
            // 
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(37, 110);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(54, 17);
            this.greenButton.TabIndex = 2;
            this.greenButton.TabStop = true;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            this.greenButton.CheckedChanged += new System.EventHandler(this.greenButton_CheckedChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(100, 200);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // ColorChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorChanger";
            this.Text = "ColorChanger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.Button confirmButton;
    }
}