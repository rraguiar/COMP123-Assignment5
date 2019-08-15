namespace COMP123_Assignment5
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButtonToOrderForm = new System.Windows.Forms.Button();
            this.ProductInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.NextConfirmSelectionLabel = new System.Windows.Forms.Label();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ConditionInfoLabel = new System.Windows.Forms.Label();
            this.CostInfoLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelInfoLabel = new System.Windows.Forms.Label();
            this.ManufacturerInfoLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.OSInfoLabel = new System.Windows.Forms.Label();
            this.PlatformInfoLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebCamInfoLabel = new System.Windows.Forms.Label();
            this.CPUSpeedInfoLabel = new System.Windows.Forms.Label();
            this.CPUTypeInfoLabel = new System.Windows.Forms.Label();
            this.GPUTypeInfoLabel = new System.Windows.Forms.Label();
            this.CPUNumberInfoLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.CPUBrandInfoLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.HDDInfoLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.LCDSizeInfoLabel = new System.Windows.Forms.Label();
            this.MemoryInfoLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.ProductIdInfoLabel = new System.Windows.Forms.Label();
            this.ProductInfoFormToolStrip = new System.Windows.Forms.ToolStrip();
            this.ProductInfoFormOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProductInfoFormSaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ProductInfoMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.ProductInfoFormToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(781, 532);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 47);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // NextButtonToOrderForm
            // 
            this.NextButtonToOrderForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButtonToOrderForm.Location = new System.Drawing.Point(894, 532);
            this.NextButtonToOrderForm.Name = "NextButtonToOrderForm";
            this.NextButtonToOrderForm.Size = new System.Drawing.Size(96, 47);
            this.NextButtonToOrderForm.TabIndex = 3;
            this.NextButtonToOrderForm.Text = "Next";
            this.NextButtonToOrderForm.UseVisualStyleBackColor = true;
            this.NextButtonToOrderForm.Click += new System.EventHandler(this.NextButtonToOrderForm_Click);
            // 
            // ProductInfoMenuStrip
            // 
            this.ProductInfoMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ProductInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoMenuStrip.Name = "ProductInfoMenuStrip";
            this.ProductInfoMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.ProductInfoMenuStrip.Size = new System.Drawing.Size(1006, 33);
            this.ProductInfoMenuStrip.TabIndex = 4;
            this.ProductInfoMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.selectAnotherProductToolStripMenuItem.Text = "S&elect Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(513, 532);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(250, 47);
            this.SelectAnotherProductButton.TabIndex = 5;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = true;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // NextConfirmSelectionLabel
            // 
            this.NextConfirmSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextConfirmSelectionLabel.Location = new System.Drawing.Point(14, 545);
            this.NextConfirmSelectionLabel.Name = "NextConfirmSelectionLabel";
            this.NextConfirmSelectionLabel.Size = new System.Drawing.Size(449, 33);
            this.NextConfirmSelectionLabel.TabIndex = 6;
            this.NextConfirmSelectionLabel.Text = "*Select Next To Confirm Your Selection";
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdLabel.Location = new System.Drawing.Point(5, 76);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(135, 33);
            this.ProductIdLabel.TabIndex = 7;
            this.ProductIdLabel.Text = "Product ID";
            this.ProductIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(304, 75);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(123, 33);
            this.ConditionLabel.TabIndex = 8;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CostLabel
            // 
            this.CostLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(613, 76);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(69, 33);
            this.CostLabel.TabIndex = 9;
            this.CostLabel.Text = "Cost";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConditionInfoLabel
            // 
            this.ConditionInfoLabel.BackColor = System.Drawing.Color.White;
            this.ConditionInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConditionInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionInfoLabel.Location = new System.Drawing.Point(433, 74);
            this.ConditionInfoLabel.Name = "ConditionInfoLabel";
            this.ConditionInfoLabel.Size = new System.Drawing.Size(139, 33);
            this.ConditionInfoLabel.TabIndex = 11;
            this.ConditionInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CostInfoLabel
            // 
            this.CostInfoLabel.BackColor = System.Drawing.Color.White;
            this.CostInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostInfoLabel.Location = new System.Drawing.Point(688, 74);
            this.CostInfoLabel.Name = "CostInfoLabel";
            this.CostInfoLabel.Size = new System.Drawing.Size(139, 33);
            this.CostInfoLabel.TabIndex = 12;
            this.CostInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelInfoLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerInfoLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSInfoLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformInfoLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(12, 129);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(982, 144);
            this.ProductInfoGroupBox.TabIndex = 13;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelInfoLabel
            // 
            this.ModelInfoLabel.BackColor = System.Drawing.Color.White;
            this.ModelInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelInfoLabel.Location = new System.Drawing.Point(443, 95);
            this.ModelInfoLabel.Name = "ModelInfoLabel";
            this.ModelInfoLabel.Size = new System.Drawing.Size(508, 33);
            this.ModelInfoLabel.TabIndex = 21;
            this.ModelInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerInfoLabel
            // 
            this.ManufacturerInfoLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufacturerInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerInfoLabel.Location = new System.Drawing.Point(154, 95);
            this.ManufacturerInfoLabel.Name = "ManufacturerInfoLabel";
            this.ManufacturerInfoLabel.Size = new System.Drawing.Size(152, 33);
            this.ManufacturerInfoLabel.TabIndex = 20;
            this.ManufacturerInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 95);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(142, 33);
            this.ManufacturerLabel.TabIndex = 18;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(312, 96);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(123, 33);
            this.ModelLabel.TabIndex = 19;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSInfoLabel
            // 
            this.OSInfoLabel.BackColor = System.Drawing.Color.White;
            this.OSInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OSInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSInfoLabel.Location = new System.Drawing.Point(443, 38);
            this.OSInfoLabel.Name = "OSInfoLabel";
            this.OSInfoLabel.Size = new System.Drawing.Size(508, 33);
            this.OSInfoLabel.TabIndex = 17;
            this.OSInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlatformInfoLabel
            // 
            this.PlatformInfoLabel.BackColor = System.Drawing.Color.White;
            this.PlatformInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlatformInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformInfoLabel.Location = new System.Drawing.Point(154, 38);
            this.PlatformInfoLabel.Name = "PlatformInfoLabel";
            this.PlatformInfoLabel.Size = new System.Drawing.Size(152, 33);
            this.PlatformInfoLabel.TabIndex = 16;
            this.PlatformInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(13, 38);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(135, 33);
            this.PlatformLabel.TabIndex = 14;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSLabel
            // 
            this.OSLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(312, 39);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(123, 33);
            this.OSLabel.TabIndex = 15;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebCamInfoLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedInfoLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeInfoLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeInfoLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberInfoLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.WebCamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandInfoLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDInfoLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeInfoLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryInfoLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(12, 296);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(982, 211);
            this.TechSpecsGroupBox.TabIndex = 22;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebCamInfoLabel
            // 
            this.WebCamInfoLabel.BackColor = System.Drawing.Color.White;
            this.WebCamInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WebCamInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamInfoLabel.Location = new System.Drawing.Point(676, 153);
            this.WebCamInfoLabel.Name = "WebCamInfoLabel";
            this.WebCamInfoLabel.Size = new System.Drawing.Size(293, 33);
            this.WebCamInfoLabel.TabIndex = 21;
            this.WebCamInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUSpeedInfoLabel
            // 
            this.CPUSpeedInfoLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUSpeedInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedInfoLabel.Location = new System.Drawing.Point(423, 152);
            this.CPUSpeedInfoLabel.Name = "CPUSpeedInfoLabel";
            this.CPUSpeedInfoLabel.Size = new System.Drawing.Size(137, 33);
            this.CPUSpeedInfoLabel.TabIndex = 21;
            this.CPUSpeedInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeInfoLabel
            // 
            this.CPUTypeInfoLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUTypeInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeInfoLabel.Location = new System.Drawing.Point(134, 152);
            this.CPUTypeInfoLabel.Name = "CPUTypeInfoLabel";
            this.CPUTypeInfoLabel.Size = new System.Drawing.Size(152, 33);
            this.CPUTypeInfoLabel.TabIndex = 20;
            this.CPUTypeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUTypeInfoLabel
            // 
            this.GPUTypeInfoLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPUTypeInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeInfoLabel.Location = new System.Drawing.Point(676, 96);
            this.GPUTypeInfoLabel.Name = "GPUTypeInfoLabel";
            this.GPUTypeInfoLabel.Size = new System.Drawing.Size(293, 33);
            this.GPUTypeInfoLabel.TabIndex = 21;
            this.GPUTypeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUNumberInfoLabel
            // 
            this.CPUNumberInfoLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumberInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUNumberInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberInfoLabel.Location = new System.Drawing.Point(423, 95);
            this.CPUNumberInfoLabel.Name = "CPUNumberInfoLabel";
            this.CPUNumberInfoLabel.Size = new System.Drawing.Size(137, 33);
            this.CPUNumberInfoLabel.TabIndex = 21;
            this.CPUNumberInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(11, 152);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(117, 33);
            this.CPUTypeLabel.TabIndex = 18;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamLabel.Location = new System.Drawing.Point(545, 154);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(123, 33);
            this.WebCamLabel.TabIndex = 19;
            this.WebCamLabel.Text = "WebCam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandInfoLabel
            // 
            this.CPUBrandInfoLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUBrandInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandInfoLabel.Location = new System.Drawing.Point(134, 95);
            this.CPUBrandInfoLabel.Name = "CPUBrandInfoLabel";
            this.CPUBrandInfoLabel.Size = new System.Drawing.Size(152, 33);
            this.CPUBrandInfoLabel.TabIndex = 20;
            this.CPUBrandInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(292, 153);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(123, 33);
            this.CPUSpeedLabel.TabIndex = 19;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeLabel.Location = new System.Drawing.Point(545, 97);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(123, 33);
            this.GPUTypeLabel.TabIndex = 19;
            this.GPUTypeLabel.Text = "GPU type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(11, 95);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(117, 33);
            this.CPUBrandLabel.TabIndex = 18;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDInfoLabel
            // 
            this.HDDInfoLabel.BackColor = System.Drawing.Color.White;
            this.HDDInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HDDInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDInfoLabel.Location = new System.Drawing.Point(676, 39);
            this.HDDInfoLabel.Name = "HDDInfoLabel";
            this.HDDInfoLabel.Size = new System.Drawing.Size(293, 33);
            this.HDDInfoLabel.TabIndex = 17;
            this.HDDInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(292, 96);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(123, 33);
            this.CPUNumberLabel.TabIndex = 19;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeInfoLabel
            // 
            this.LCDSizeInfoLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LCDSizeInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeInfoLabel.Location = new System.Drawing.Point(423, 38);
            this.LCDSizeInfoLabel.Name = "LCDSizeInfoLabel";
            this.LCDSizeInfoLabel.Size = new System.Drawing.Size(137, 33);
            this.LCDSizeInfoLabel.TabIndex = 17;
            this.LCDSizeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryInfoLabel
            // 
            this.MemoryInfoLabel.BackColor = System.Drawing.Color.White;
            this.MemoryInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoryInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryInfoLabel.Location = new System.Drawing.Point(134, 38);
            this.MemoryInfoLabel.Name = "MemoryInfoLabel";
            this.MemoryInfoLabel.Size = new System.Drawing.Size(152, 33);
            this.MemoryInfoLabel.TabIndex = 16;
            this.MemoryInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.Location = new System.Drawing.Point(545, 40);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(123, 33);
            this.HDDLabel.TabIndex = 15;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(11, 38);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(117, 33);
            this.MemoryLabel.TabIndex = 14;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeLabel.Location = new System.Drawing.Point(292, 39);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(123, 33);
            this.LCDSizeLabel.TabIndex = 15;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductIdInfoLabel
            // 
            this.ProductIdInfoLabel.BackColor = System.Drawing.Color.White;
            this.ProductIdInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductIdInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdInfoLabel.Location = new System.Drawing.Point(146, 76);
            this.ProductIdInfoLabel.Name = "ProductIdInfoLabel";
            this.ProductIdInfoLabel.Size = new System.Drawing.Size(152, 33);
            this.ProductIdInfoLabel.TabIndex = 10;
            this.ProductIdInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductInfoFormToolStrip
            // 
            this.ProductInfoFormToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ProductInfoFormToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductInfoFormOpenToolStripButton,
            this.ProductInfoFormSaveToolStripButton});
            this.ProductInfoFormToolStrip.Location = new System.Drawing.Point(0, 33);
            this.ProductInfoFormToolStrip.Name = "ProductInfoFormToolStrip";
            this.ProductInfoFormToolStrip.Size = new System.Drawing.Size(1006, 31);
            this.ProductInfoFormToolStrip.TabIndex = 23;
            this.ProductInfoFormToolStrip.Text = "ProductInfoFormToolStrip";
            // 
            // ProductInfoFormOpenToolStripButton
            // 
            this.ProductInfoFormOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProductInfoFormOpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductInfoFormOpenToolStripButton.Image")));
            this.ProductInfoFormOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProductInfoFormOpenToolStripButton.Name = "ProductInfoFormOpenToolStripButton";
            this.ProductInfoFormOpenToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.ProductInfoFormOpenToolStripButton.Text = "&Open";
            this.ProductInfoFormOpenToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // ProductInfoFormSaveToolStripButton
            // 
            this.ProductInfoFormSaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ProductInfoFormSaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductInfoFormSaveToolStripButton.Image")));
            this.ProductInfoFormSaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProductInfoFormSaveToolStripButton.Name = "ProductInfoFormSaveToolStripButton";
            this.ProductInfoFormSaveToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.ProductInfoFormSaveToolStripButton.Text = "&Save";
            this.ProductInfoFormSaveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 595);
            this.ControlBox = false;
            this.Controls.Add(this.ProductInfoFormToolStrip);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CostInfoLabel);
            this.Controls.Add(this.ProductIdInfoLabel);
            this.Controls.Add(this.ConditionInfoLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIdLabel);
            this.Controls.Add(this.NextConfirmSelectionLabel);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Controls.Add(this.NextButtonToOrderForm);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProductInfoMenuStrip);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information Form";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.ProductInfoMenuStrip.ResumeLayout(false);
            this.ProductInfoMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.ProductInfoFormToolStrip.ResumeLayout(false);
            this.ProductInfoFormToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButtonToOrderForm;
        private System.Windows.Forms.MenuStrip ProductInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.Label NextConfirmSelectionLabel;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label ConditionInfoLabel;
        private System.Windows.Forms.Label CostInfoLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label OSInfoLabel;
        private System.Windows.Forms.Label PlatformInfoLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ModelInfoLabel;
        private System.Windows.Forms.Label ManufacturerInfoLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label CPUSpeedInfoLabel;
        private System.Windows.Forms.Label CPUTypeInfoLabel;
        private System.Windows.Forms.Label CPUNumberInfoLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandInfoLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label LCDSizeInfoLabel;
        private System.Windows.Forms.Label MemoryInfoLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label WebCamInfoLabel;
        private System.Windows.Forms.Label GPUTypeInfoLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDInfoLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label ProductIdInfoLabel;
        private System.Windows.Forms.ToolStrip ProductInfoFormToolStrip;
        private System.Windows.Forms.ToolStripButton ProductInfoFormOpenToolStripButton;
        private System.Windows.Forms.ToolStripButton ProductInfoFormSaveToolStripButton;
    }
}