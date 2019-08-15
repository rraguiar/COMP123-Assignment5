namespace COMP123_Assignment5
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.FinishButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.OrderFormSystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.ConditionInfoLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ModelInfoLabel = new System.Windows.Forms.Label();
            this.ManufacturerInfoLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformInfoLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SystemComponentsLineShape = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.CPUSpeedInfoLabel = new System.Windows.Forms.Label();
            this.CPUTypeInfoLabel = new System.Windows.Forms.Label();
            this.CPUNumberInfoLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandInfoLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.LCDSizeInfoLabel = new System.Windows.Forms.Label();
            this.MemoryInfoLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.ComputerPictureBox = new System.Windows.Forms.PictureBox();
            this.OrderFormYourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.SalesTaxInfoLabel = new System.Windows.Forms.Label();
            this.TotalInfoLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalexTaxLabel = new System.Windows.Forms.Label();
            this.PriceInfoLabel = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.YourPriceLineShape = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.WebCamInfoLabel = new System.Windows.Forms.Label();
            this.GPUTypeInfoLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDInfoLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.OSInfoLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.OrderMenuStrip.SuspendLayout();
            this.OrderFormSystemComponentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).BeginInit();
            this.OrderFormYourPriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(899, 538);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(95, 45);
            this.FinishButton.TabIndex = 5;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(782, 538);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 45);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(660, 538);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(95, 45);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Size = new System.Drawing.Size(1006, 33);
            this.OrderMenuStrip.TabIndex = 7;
            this.OrderMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.FileToolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // FileToolStripSeparator
            // 
            this.FileToolStripSeparator.Name = "FileToolStripSeparator";
            this.FileToolStripSeparator.Size = new System.Drawing.Size(249, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backBToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backBToolStripMenuItem
            // 
            this.backBToolStripMenuItem.Name = "backBToolStripMenuItem";
            this.backBToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.backBToolStripMenuItem.Text = "&Back";
            this.backBToolStripMenuItem.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // OrderFormSystemComponentsGroupBox
            // 
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.WebCamLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.OSInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.GPUTypeInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.WebCamInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.HDDInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.CPUSpeedInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.CPUNumberInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.MemoryInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.CPUBrandInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.CPUTypeInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.LCDSizeInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.ModelInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.ConditionInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.ManufacturerInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.PlatformInfoLabel);
            this.OrderFormSystemComponentsGroupBox.Controls.Add(this.shapeContainer1);
            this.OrderFormSystemComponentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormSystemComponentsGroupBox.ForeColor = System.Drawing.Color.Black;
            this.OrderFormSystemComponentsGroupBox.Location = new System.Drawing.Point(12, 50);
            this.OrderFormSystemComponentsGroupBox.Name = "OrderFormSystemComponentsGroupBox";
            this.OrderFormSystemComponentsGroupBox.Size = new System.Drawing.Size(528, 516);
            this.OrderFormSystemComponentsGroupBox.TabIndex = 8;
            this.OrderFormSystemComponentsGroupBox.TabStop = false;
            this.OrderFormSystemComponentsGroupBox.Text = "System Components";
            // 
            // ConditionInfoLabel
            // 
            this.ConditionInfoLabel.BackColor = System.Drawing.Color.White;
            this.ConditionInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConditionInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionInfoLabel.Location = new System.Drawing.Point(124, 28);
            this.ConditionInfoLabel.Name = "ConditionInfoLabel";
            this.ConditionInfoLabel.Size = new System.Drawing.Size(139, 33);
            this.ConditionInfoLabel.TabIndex = 23;
            this.ConditionInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConditionLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(-24, 28);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(142, 33);
            this.ConditionLabel.TabIndex = 22;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelInfoLabel
            // 
            this.ModelInfoLabel.BackColor = System.Drawing.Color.White;
            this.ModelInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelInfoLabel.Location = new System.Drawing.Point(359, 70);
            this.ModelInfoLabel.Name = "ModelInfoLabel";
            this.ModelInfoLabel.Size = new System.Drawing.Size(152, 33);
            this.ModelInfoLabel.TabIndex = 29;
            this.ModelInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerInfoLabel
            // 
            this.ManufacturerInfoLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufacturerInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerInfoLabel.Location = new System.Drawing.Point(124, 70);
            this.ManufacturerInfoLabel.Name = "ManufacturerInfoLabel";
            this.ManufacturerInfoLabel.Size = new System.Drawing.Size(139, 33);
            this.ManufacturerInfoLabel.TabIndex = 28;
            this.ManufacturerInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.BackColor = System.Drawing.Color.Transparent;
            this.ManufacturerLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(-24, 70);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(142, 33);
            this.ManufacturerLabel.TabIndex = 26;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelLabel
            // 
            this.ModelLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModelLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(269, 70);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(84, 33);
            this.ModelLabel.TabIndex = 27;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlatformInfoLabel
            // 
            this.PlatformInfoLabel.BackColor = System.Drawing.Color.White;
            this.PlatformInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlatformInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformInfoLabel.Location = new System.Drawing.Point(359, 28);
            this.PlatformInfoLabel.Name = "PlatformInfoLabel";
            this.PlatformInfoLabel.Size = new System.Drawing.Size(152, 33);
            this.PlatformInfoLabel.TabIndex = 25;
            this.PlatformInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlatformLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformLabel.Location = new System.Drawing.Point(242, 28);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(111, 33);
            this.PlatformLabel.TabIndex = 24;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 28);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.SystemComponentsLineShape});
            this.shapeContainer1.Size = new System.Drawing.Size(522, 485);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // SystemComponentsLineShape
            // 
            this.SystemComponentsLineShape.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.SystemComponentsLineShape.BorderWidth = 2;
            this.SystemComponentsLineShape.Name = "SystemComponentsLineShape";
            this.SystemComponentsLineShape.X1 = 2;
            this.SystemComponentsLineShape.X2 = 520;
            this.SystemComponentsLineShape.Y1 = 92;
            this.SystemComponentsLineShape.Y2 = 92;
            // 
            // CPUSpeedInfoLabel
            // 
            this.CPUSpeedInfoLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUSpeedInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedInfoLabel.Location = new System.Drawing.Point(124, 322);
            this.CPUSpeedInfoLabel.Name = "CPUSpeedInfoLabel";
            this.CPUSpeedInfoLabel.Size = new System.Drawing.Size(387, 33);
            this.CPUSpeedInfoLabel.TabIndex = 32;
            this.CPUSpeedInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeInfoLabel
            // 
            this.CPUTypeInfoLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUTypeInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeInfoLabel.Location = new System.Drawing.Point(124, 248);
            this.CPUTypeInfoLabel.Name = "CPUTypeInfoLabel";
            this.CPUTypeInfoLabel.Size = new System.Drawing.Size(387, 33);
            this.CPUTypeInfoLabel.TabIndex = 30;
            this.CPUTypeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUNumberInfoLabel
            // 
            this.CPUNumberInfoLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumberInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUNumberInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberInfoLabel.Location = new System.Drawing.Point(124, 285);
            this.CPUNumberInfoLabel.Name = "CPUNumberInfoLabel";
            this.CPUNumberInfoLabel.Size = new System.Drawing.Size(387, 33);
            this.CPUNumberInfoLabel.TabIndex = 33;
            this.CPUNumberInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUTypeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(1, 248);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(117, 33);
            this.CPUTypeLabel.TabIndex = 26;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandInfoLabel
            // 
            this.CPUBrandInfoLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUBrandInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandInfoLabel.Location = new System.Drawing.Point(124, 211);
            this.CPUBrandInfoLabel.Name = "CPUBrandInfoLabel";
            this.CPUBrandInfoLabel.Size = new System.Drawing.Size(387, 33);
            this.CPUBrandInfoLabel.TabIndex = 31;
            this.CPUBrandInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(0, 322);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(118, 33);
            this.CPUSpeedLabel.TabIndex = 28;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUBrandLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(-6, 211);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(124, 33);
            this.CPUBrandLabel.TabIndex = 27;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUNumberLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(-5, 285);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(123, 33);
            this.CPUNumberLabel.TabIndex = 29;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeInfoLabel
            // 
            this.LCDSizeInfoLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LCDSizeInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeInfoLabel.Location = new System.Drawing.Point(124, 137);
            this.LCDSizeInfoLabel.Name = "LCDSizeInfoLabel";
            this.LCDSizeInfoLabel.Size = new System.Drawing.Size(387, 33);
            this.LCDSizeInfoLabel.TabIndex = 25;
            this.LCDSizeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryInfoLabel
            // 
            this.MemoryInfoLabel.BackColor = System.Drawing.Color.White;
            this.MemoryInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoryInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryInfoLabel.Location = new System.Drawing.Point(124, 174);
            this.MemoryInfoLabel.Name = "MemoryInfoLabel";
            this.MemoryInfoLabel.Size = new System.Drawing.Size(387, 33);
            this.MemoryInfoLabel.TabIndex = 24;
            this.MemoryInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.MemoryLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemoryLabel.Location = new System.Drawing.Point(1, 174);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(117, 33);
            this.MemoryLabel.TabIndex = 22;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LCDSizeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDSizeLabel.Location = new System.Drawing.Point(-5, 137);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(123, 33);
            this.LCDSizeLabel.TabIndex = 23;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComputerPictureBox
            // 
            this.ComputerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ComputerPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ComputerPictureBox.BackgroundImage")));
            this.ComputerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ComputerPictureBox.Location = new System.Drawing.Point(546, 72);
            this.ComputerPictureBox.Name = "ComputerPictureBox";
            this.ComputerPictureBox.Size = new System.Drawing.Size(274, 181);
            this.ComputerPictureBox.TabIndex = 9;
            this.ComputerPictureBox.TabStop = false;
            // 
            // OrderFormYourPriceGroupBox
            // 
            this.OrderFormYourPriceGroupBox.Controls.Add(this.SalesTaxInfoLabel);
            this.OrderFormYourPriceGroupBox.Controls.Add(this.TotalInfoLabel);
            this.OrderFormYourPriceGroupBox.Controls.Add(this.PriceLabel);
            this.OrderFormYourPriceGroupBox.Controls.Add(this.TotalLabel);
            this.OrderFormYourPriceGroupBox.Controls.Add(this.SalexTaxLabel);
            this.OrderFormYourPriceGroupBox.Controls.Add(this.PriceInfoLabel);
            this.OrderFormYourPriceGroupBox.Controls.Add(this.shapeContainer2);
            this.OrderFormYourPriceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderFormYourPriceGroupBox.ForeColor = System.Drawing.Color.Black;
            this.OrderFormYourPriceGroupBox.Location = new System.Drawing.Point(546, 271);
            this.OrderFormYourPriceGroupBox.Name = "OrderFormYourPriceGroupBox";
            this.OrderFormYourPriceGroupBox.Size = new System.Drawing.Size(448, 239);
            this.OrderFormYourPriceGroupBox.TabIndex = 34;
            this.OrderFormYourPriceGroupBox.TabStop = false;
            this.OrderFormYourPriceGroupBox.Text = "Your Price";
            // 
            // SalesTaxInfoLabel
            // 
            this.SalesTaxInfoLabel.BackColor = System.Drawing.Color.White;
            this.SalesTaxInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesTaxInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxInfoLabel.Location = new System.Drawing.Point(247, 101);
            this.SalesTaxInfoLabel.Name = "SalesTaxInfoLabel";
            this.SalesTaxInfoLabel.Size = new System.Drawing.Size(184, 33);
            this.SalesTaxInfoLabel.TabIndex = 23;
            this.SalesTaxInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalInfoLabel
            // 
            this.TotalInfoLabel.BackColor = System.Drawing.Color.White;
            this.TotalInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInfoLabel.Location = new System.Drawing.Point(247, 179);
            this.TotalInfoLabel.Name = "TotalInfoLabel";
            this.TotalInfoLabel.Size = new System.Drawing.Size(184, 33);
            this.TotalInfoLabel.TabIndex = 28;
            this.TotalInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceLabel
            // 
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(-24, 52);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(142, 33);
            this.PriceLabel.TabIndex = 22;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalLabel
            // 
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(-24, 179);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(142, 33);
            this.TotalLabel.TabIndex = 26;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalexTaxLabel
            // 
            this.SalexTaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.SalexTaxLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalexTaxLabel.Location = new System.Drawing.Point(7, 101);
            this.SalexTaxLabel.Name = "SalexTaxLabel";
            this.SalexTaxLabel.Size = new System.Drawing.Size(111, 33);
            this.SalexTaxLabel.TabIndex = 24;
            this.SalexTaxLabel.Text = "Sales Tax (13%)";
            this.SalexTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceInfoLabel
            // 
            this.PriceInfoLabel.BackColor = System.Drawing.Color.White;
            this.PriceInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceInfoLabel.Location = new System.Drawing.Point(247, 52);
            this.PriceInfoLabel.Name = "PriceInfoLabel";
            this.PriceInfoLabel.Size = new System.Drawing.Size(184, 33);
            this.PriceInfoLabel.TabIndex = 25;
            this.PriceInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 28);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.YourPriceLineShape});
            this.shapeContainer2.Size = new System.Drawing.Size(442, 208);
            this.shapeContainer2.TabIndex = 30;
            this.shapeContainer2.TabStop = false;
            // 
            // YourPriceLineShape
            // 
            this.YourPriceLineShape.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.YourPriceLineShape.BorderWidth = 2;
            this.YourPriceLineShape.Name = "YourPriceLineShape";
            this.YourPriceLineShape.X1 = 3;
            this.YourPriceLineShape.X2 = 431;
            this.YourPriceLineShape.Y1 = 128;
            this.YourPriceLineShape.Y2 = 128;
            // 
            // WebCamInfoLabel
            // 
            this.WebCamInfoLabel.BackColor = System.Drawing.Color.White;
            this.WebCamInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WebCamInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamInfoLabel.Location = new System.Drawing.Point(124, 396);
            this.WebCamInfoLabel.Name = "WebCamInfoLabel";
            this.WebCamInfoLabel.Size = new System.Drawing.Size(387, 33);
            this.WebCamInfoLabel.TabIndex = 41;
            this.WebCamInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUTypeInfoLabel
            // 
            this.GPUTypeInfoLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPUTypeInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeInfoLabel.Location = new System.Drawing.Point(124, 432);
            this.GPUTypeInfoLabel.Name = "GPUTypeInfoLabel";
            this.GPUTypeInfoLabel.Size = new System.Drawing.Size(387, 33);
            this.GPUTypeInfoLabel.TabIndex = 42;
            this.GPUTypeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.BackColor = System.Drawing.Color.Transparent;
            this.WebCamLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebCamLabel.Location = new System.Drawing.Point(-5, 396);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(123, 33);
            this.WebCamLabel.TabIndex = 39;
            this.WebCamLabel.Text = "WebCam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.GPUTypeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUTypeLabel.Location = new System.Drawing.Point(-5, 432);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(123, 33);
            this.GPUTypeLabel.TabIndex = 40;
            this.GPUTypeLabel.Text = "GPU type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDInfoLabel
            // 
            this.HDDInfoLabel.BackColor = System.Drawing.Color.White;
            this.HDDInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HDDInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDInfoLabel.Location = new System.Drawing.Point(124, 359);
            this.HDDInfoLabel.Name = "HDDInfoLabel";
            this.HDDInfoLabel.Size = new System.Drawing.Size(387, 33);
            this.HDDInfoLabel.TabIndex = 37;
            this.HDDInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDLabel
            // 
            this.HDDLabel.BackColor = System.Drawing.Color.Transparent;
            this.HDDLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDDLabel.Location = new System.Drawing.Point(-5, 359);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(123, 33);
            this.HDDLabel.TabIndex = 35;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSInfoLabel
            // 
            this.OSInfoLabel.BackColor = System.Drawing.Color.White;
            this.OSInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OSInfoLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSInfoLabel.Location = new System.Drawing.Point(124, 469);
            this.OSInfoLabel.Name = "OSInfoLabel";
            this.OSInfoLabel.Size = new System.Drawing.Size(387, 33);
            this.OSInfoLabel.TabIndex = 38;
            this.OSInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OSLabel
            // 
            this.OSLabel.BackColor = System.Drawing.Color.Transparent;
            this.OSLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(-5, 469);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(123, 33);
            this.OSLabel.TabIndex = 36;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 595);
            this.ControlBox = false;
            this.Controls.Add(this.OrderFormYourPriceGroupBox);
            this.Controls.Add(this.ComputerPictureBox);
            this.Controls.Add(this.OrderFormSystemComponentsGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OrderMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.OrderMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.OrderFormSystemComponentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).EndInit();
            this.OrderFormYourPriceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backBToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private System.Windows.Forms.GroupBox OrderFormSystemComponentsGroupBox;
        private System.Windows.Forms.Label ModelInfoLabel;
        private System.Windows.Forms.Label ConditionInfoLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerInfoLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label PlatformInfoLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape SystemComponentsLineShape;
        private System.Windows.Forms.Label CPUSpeedInfoLabel;
        private System.Windows.Forms.Label CPUTypeInfoLabel;
        private System.Windows.Forms.Label CPUNumberInfoLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandInfoLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label MemoryInfoLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDSizeInfoLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.GroupBox OrderFormYourPriceGroupBox;
        private System.Windows.Forms.Label SalesTaxInfoLabel;
        private System.Windows.Forms.Label TotalInfoLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalexTaxLabel;
        private System.Windows.Forms.Label PriceInfoLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape YourPriceLineShape;
        private System.Windows.Forms.PictureBox ComputerPictureBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label OSInfoLabel;
        private System.Windows.Forms.Label GPUTypeInfoLabel;
        private System.Windows.Forms.Label WebCamInfoLabel;
        private System.Windows.Forms.Label HDDInfoLabel;
        private System.Windows.Forms.Label HDDLabel;
    }
}