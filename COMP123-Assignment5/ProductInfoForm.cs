using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    
    Description: This is the Product Info Form class

    Assignment: Dollar Computers
 */

namespace COMP123_Assignment5
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButtonToOrderForm_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ORDER_FORM].Show();
            this.Hide();
        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
                loadSavedFile();
        }

        private void loadSavedFile()
        {
            //here I will load the content of the file.
            MessageBox.Show("clicked on load saved order button");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create stream to write on the file
            using (StreamWriter outputString = new StreamWriter(
                File.Open("Product.txt", FileMode.Create)))
            {
                //write content from the class to the file
                outputString.WriteLine(Program.selectedComputer.ProductID);
                outputString.WriteLine(Program.selectedComputer.Price);
                outputString.WriteLine(Program.selectedComputer.Manufacturer);
                outputString.WriteLine(Program.selectedComputer.Model);
                outputString.WriteLine(Program.selectedComputer.RAMType);
                outputString.WriteLine(Program.selectedComputer.RAMSize);
                outputString.WriteLine(Program.selectedComputer.DisplayType);
                outputString.WriteLine(Program.selectedComputer.ScreenSize);
                outputString.WriteLine(Program.selectedComputer.Resolution);
                outputString.WriteLine(Program.selectedComputer.CPUClass);
                outputString.WriteLine(Program.selectedComputer.CPUBrand);
                outputString.WriteLine(Program.selectedComputer.CPUType);
                outputString.WriteLine(Program.selectedComputer.CPUSpeed);
                outputString.WriteLine(Program.selectedComputer.CPUNumber);
                outputString.WriteLine(Program.selectedComputer.Condition);
                outputString.WriteLine(Program.selectedComputer.OS);
                outputString.WriteLine(Program.selectedComputer.Platform);
                outputString.WriteLine(Program.selectedComputer.HDDSize);
                outputString.WriteLine(Program.selectedComputer.HDDSpeed);
                outputString.WriteLine(Program.selectedComputer.GPUType);
                outputString.WriteLine(Program.selectedComputer.OpticalDrive);
                outputString.WriteLine(Program.selectedComputer.AudioType);
                outputString.WriteLine(Program.selectedComputer.LAN);
                outputString.WriteLine(Program.selectedComputer.WIFI);
                outputString.WriteLine(Program.selectedComputer.Width);
                outputString.WriteLine(Program.selectedComputer.Heigth);
                outputString.WriteLine(Program.selectedComputer.Depth);
                outputString.WriteLine(Program.selectedComputer.Weight);
                outputString.WriteLine(Program.selectedComputer.MouseType);
                outputString.WriteLine(Program.selectedComputer.Power);
                outputString.Write(Program.selectedComputer.Webcam);

                //cleanup
                outputString.Close();
                outputString.Dispose();
            }

        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            if (Program.LoadSavedOrder == true)
            {
                Program.LoadSavedOrder = false;
                loadSavedFile();
            }
            else
            {
                //load content from the selectedComputer class to the form labels
                ProductIdInfoLabel.Text = Program.selectedComputer.ProductID;
                ConditionInfoLabel.Text = Program.selectedComputer.Condition;
                CostInfoLabel.Text = Program.selectedComputer.Price;
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
            }
        }
    }
}