using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    CENTENNIAL COLLEGE
    COMP123 - Programming 2 - C# Windows Forms - IDE
   
    Assignment 5 - Summer 2019
    Author: Rafael Aguiar
    Student id: 301041266
    Date: Aug/13/2019
    
    Description: This is the Order Form class

    Assignment: Dollar Computers
 */

namespace COMP123_Assignment5
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method handles the backButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This method handles the finishButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for shopping with Dollar Computers!\n\nYour order will be processed in 7-10 business days.");
            Application.Exit();
        }

        /// <summary>
        /// This method handles the print function event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        /// <summary>
        /// This method handles the exit event from toolStripMenu and cancelButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method handles the Tool Strip Menu About event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }

        /// <summary>
        /// This method fill up the form with the computer´s data on the load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            //load content from the selectedComputer class to the form labels
            ConditionInfoLabel.Text = Program.selectedComputer.Condition;
            PriceInfoLabel.Text = "$" + Program.selectedComputer.Price;
            PlatformInfoLabel.Text = Program.selectedComputer.Platform;
            OSInfoLabel.Text = Program.selectedComputer.OS;
            ManufacturerInfoLabel.Text = Program.selectedComputer.Manufacturer;
            ModelInfoLabel.Text = Program.selectedComputer.Model;
            MemoryInfoLabel.Text = Program.selectedComputer.RAMSize;
            LCDSizeInfoLabel.Text = Program.selectedComputer.ScreenSize;
            HDDInfoLabel.Text = Program.selectedComputer.HDDSize;
            CPUBrandInfoLabel.Text = Program.selectedComputer.CPUBrand;
            CPUNumberInfoLabel.Text = Program.selectedComputer.CPUNumber;
            GPUTypeInfoLabel.Text = Program.selectedComputer.GPUType;
            CPUTypeInfoLabel.Text = Program.selectedComputer.CPUType;
            CPUSpeedInfoLabel.Text = Program.selectedComputer.CPUSpeed;
            WebCamInfoLabel.Text = Program.selectedComputer.Webcam;
            double price = double.Parse(Program.selectedComputer.Price);
            double tax = (price * 13) / 100;
            tax = Math.Round(tax, 2);
            double total = price + tax;
            SalesTaxInfoLabel.Text = "$" + tax.ToString();
            TotalInfoLabel.Text = "$" + total.ToString();
        }
    }
}
