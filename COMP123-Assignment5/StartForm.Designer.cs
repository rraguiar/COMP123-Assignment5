namespace COMP123_Assignment5
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.DollarComputersLabel = new System.Windows.Forms.Label();
            this.LoadSavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartFormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNewOrderButton.Location = new System.Drawing.Point(85, 198);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(207, 34);
            this.StartNewOrderButton.TabIndex = 0;
            this.StartNewOrderButton.Text = "Start a New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            this.StartNewOrderButton.Click += new System.EventHandler(this.StartNewOrderButton_Click);
            // 
            // DollarComputersLabel
            // 
            this.DollarComputersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarComputersLabel.Location = new System.Drawing.Point(-1, 9);
            this.DollarComputersLabel.Name = "DollarComputersLabel";
            this.DollarComputersLabel.Size = new System.Drawing.Size(382, 51);
            this.DollarComputersLabel.TabIndex = 1;
            this.DollarComputersLabel.Text = "Order Your Computer Today!";
            this.DollarComputersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadSavedOrderButton
            // 
            this.LoadSavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadSavedOrderButton.Location = new System.Drawing.Point(85, 238);
            this.LoadSavedOrderButton.Name = "LoadSavedOrderButton";
            this.LoadSavedOrderButton.Size = new System.Drawing.Size(207, 34);
            this.LoadSavedOrderButton.TabIndex = 2;
            this.LoadSavedOrderButton.Text = "Load Saved Order";
            this.LoadSavedOrderButton.UseVisualStyleBackColor = true;
            this.LoadSavedOrderButton.Click += new System.EventHandler(this.LoadSavedOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(85, 278);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(207, 34);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartFormPictureBox
            // 
            this.StartFormPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StartFormPictureBox.Image")));
            this.StartFormPictureBox.Location = new System.Drawing.Point(85, 56);
            this.StartFormPictureBox.Name = "StartFormPictureBox";
            this.StartFormPictureBox.Size = new System.Drawing.Size(207, 129);
            this.StartFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StartFormPictureBox.TabIndex = 4;
            this.StartFormPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(378, 324);
            this.ControlBox = false;
            this.Controls.Add(this.StartFormPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadSavedOrderButton);
            this.Controls.Add(this.DollarComputersLabel);
            this.Controls.Add(this.StartNewOrderButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.StartFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Label DollarComputersLabel;
        private System.Windows.Forms.Button LoadSavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox StartFormPictureBox;
    }
}