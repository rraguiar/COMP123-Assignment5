﻿namespace COMP123_Assignment5
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutFormtableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.AboutFormOKButton = new System.Windows.Forms.Button();
            this.AboutFormtableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutFormtableLayoutPanel
            // 
            this.AboutFormtableLayoutPanel.ColumnCount = 2;
            this.AboutFormtableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.AboutFormtableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.AboutFormtableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.AboutFormtableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.AboutFormtableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.AboutFormtableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
            this.AboutFormtableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
            this.AboutFormtableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.AboutFormtableLayoutPanel.Controls.Add(this.AboutFormOKButton, 1, 5);
            this.AboutFormtableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutFormtableLayoutPanel.Location = new System.Drawing.Point(14, 14);
            this.AboutFormtableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AboutFormtableLayoutPanel.Name = "AboutFormtableLayoutPanel";
            this.AboutFormtableLayoutPanel.RowCount = 6;
            this.AboutFormtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.AboutFormtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.AboutFormtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.AboutFormtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.AboutFormtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.AboutFormtableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AboutFormtableLayoutPanel.Size = new System.Drawing.Size(624, 407);
            this.AboutFormtableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(4, 5);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.AboutFormtableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(197, 397);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(214, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 26);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(406, 26);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(214, 40);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 26);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(406, 26);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Location = new System.Drawing.Point(214, 80);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 26);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(406, 26);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCompanyName.Location = new System.Drawing.Point(214, 120);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 26);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(406, 26);
            this.labelCompanyName.TabIndex = 22;
            this.labelCompanyName.Text = "Company Name";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(214, 165);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(9, 5, 4, 5);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(406, 152);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // AboutFormOKButton
            // 
            this.AboutFormOKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutFormOKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AboutFormOKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutFormOKButton.Location = new System.Drawing.Point(496, 354);
            this.AboutFormOKButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AboutFormOKButton.Name = "AboutFormOKButton";
            this.AboutFormOKButton.Size = new System.Drawing.Size(124, 48);
            this.AboutFormOKButton.TabIndex = 24;
            this.AboutFormOKButton.Text = "&OK";
            // 
            // AboutForm
            // 
            this.AcceptButton = this.AboutFormOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 435);
            this.Controls.Add(this.AboutFormtableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.AboutFormtableLayoutPanel.ResumeLayout(false);
            this.AboutFormtableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AboutFormtableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button AboutFormOKButton;
    }
}
