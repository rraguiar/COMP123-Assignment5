namespace COMP123_Assignment5
{
    partial class SelectForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.SelectOrderCancelButton = new System.Windows.Forms.Button();
            this.HardwarListInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(641, 489);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(115, 43);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButtonToProdInfoForm_Click);
            // 
            // SelectOrderCancelButton
            // 
            this.SelectOrderCancelButton.Location = new System.Drawing.Point(504, 489);
            this.SelectOrderCancelButton.Name = "SelectOrderCancelButton";
            this.SelectOrderCancelButton.Size = new System.Drawing.Size(115, 43);
            this.SelectOrderCancelButton.TabIndex = 1;
            this.SelectOrderCancelButton.Text = "Cancel";
            this.SelectOrderCancelButton.UseVisualStyleBackColor = true;
            this.SelectOrderCancelButton.Click += new System.EventHandler(this.SelectOrderCancelButton_Click);
            // 
            // HardwarListInfoLabel
            // 
            this.HardwarListInfoLabel.BackColor = System.Drawing.Color.White;
            this.HardwarListInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HardwarListInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardwarListInfoLabel.Location = new System.Drawing.Point(13, 13);
            this.HardwarListInfoLabel.Name = "HardwarListInfoLabel";
            this.HardwarListInfoLabel.Size = new System.Drawing.Size(228, 25);
            this.HardwarListInfoLabel.TabIndex = 2;
            this.HardwarListInfoLabel.Text = "Dollar Computer Hardware List";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.ControlBox = false;
            this.Controls.Add(this.HardwarListInfoLabel);
            this.Controls.Add(this.SelectOrderCancelButton);
            this.Controls.Add(this.NextButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button SelectOrderCancelButton;
        private System.Windows.Forms.Label HardwarListInfoLabel;
    }
}

