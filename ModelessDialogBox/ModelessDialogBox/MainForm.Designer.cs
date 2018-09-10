namespace ModelessDialogBox
{
    partial class MainForm
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
            this.openModalBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openModalBoxButton
            // 
            this.openModalBoxButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openModalBoxButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openModalBoxButton.Location = new System.Drawing.Point(350, 225);
            this.openModalBoxButton.Name = "openModalBoxButton";
            this.openModalBoxButton.Size = new System.Drawing.Size(125, 25);
            this.openModalBoxButton.TabIndex = 0;
            this.openModalBoxButton.Text = "Change Color!";
            this.openModalBoxButton.UseVisualStyleBackColor = false;
            this.openModalBoxButton.Click += new System.EventHandler(this.openModalBoxButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.openModalBoxButton);
            this.Name = "MainForm";
            this.Text = "Change Colors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openModalBoxButton;
    }
}

