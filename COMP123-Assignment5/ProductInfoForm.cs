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

        /// <summary>
        /// This method handles the click event on the CancelButton and 
        /// exitToolStripMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method handles the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonToOrderForm_Click(object sender, EventArgs e)
        {
            goToNextForm();
        }

        /// <summary>
        /// This method perform cleanup and move to the next form
        /// </summary>
        private void goToNextForm()
        {
            LoadContentFromSelectedComputerClass();
            Program.Forms[FormName.ORDER_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This method handles the click event on the SelectAnotherProductButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            //clean the class content for new selection
            cleanSelectedProductClassContent();

            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This method cleans the SelectedProduct class before new selection is made
        /// </summary>
        private void cleanSelectedProductClassContent()
        {
            Program.selectedComputer.ProductID = string.Empty;
            Program.selectedComputer.Price = string.Empty;
            Program.selectedComputer.Manufacturer = string.Empty;
            Program.selectedComputer.Model = string.Empty;
            Program.selectedComputer.RAMType = string.Empty;
            Program.selectedComputer.RAMSize = string.Empty;
            Program.selectedComputer.DisplayType = string.Empty;
            Program.selectedComputer.ScreenSize = string.Empty;
            Program.selectedComputer.Resolution = string.Empty;
            Program.selectedComputer.CPUClass = string.Empty;
            Program.selectedComputer.CPUBrand = string.Empty;
            Program.selectedComputer.CPUType = string.Empty;
            Program.selectedComputer.CPUSpeed = string.Empty;
            Program.selectedComputer.CPUNumber = string.Empty;
            Program.selectedComputer.Condition = string.Empty;
            Program.selectedComputer.OS = string.Empty;
            Program.selectedComputer.Platform = string.Empty;
            Program.selectedComputer.HDDSize = string.Empty;
            Program.selectedComputer.HDDSpeed = string.Empty;
            Program.selectedComputer.GPUType = string.Empty;
            Program.selectedComputer.OpticalDrive = string.Empty;
            Program.selectedComputer.AudioType = string.Empty;
            Program.selectedComputer.LAN = string.Empty;
            Program.selectedComputer.WIFI = string.Empty;
            Program.selectedComputer.Width = string.Empty;
            Program.selectedComputer.Heigth = string.Empty;
            Program.selectedComputer.Depth = string.Empty;
            Program.selectedComputer.Weight = string.Empty;
            Program.selectedComputer.MouseType = string.Empty;
            Program.selectedComputer.Power = string.Empty;
            Program.selectedComputer.Webcam = string.Empty;
        }

        /// <summary>
        /// This method handle the click event on the openToolStripMenu and 
        /// openToolStripButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
                loadSavedFile();
        }

        /// <summary>
        /// This method handles the "load from file" action from openToolStripMenu, 
        /// openToolStripButton and LoadSavedOrder button from the StartForm.
        /// </summary>
        private void loadSavedFile()
        {
            //configure the file dialog
            productOpenFileDialog.FileName = "Product.txt";
            productOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            productOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the file dialog
            var result = productOpenFileDialog.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                //here I will load the content from the file into the SelectedProduct object.
                using (StreamReader inputString = new StreamReader(
                File.Open(productOpenFileDialog.FileName, FileMode.Open)))
                {
                    Program.selectedComputer.ProductID = inputString.ReadLine();
                    Program.selectedComputer.Price = inputString.ReadLine();
                    Program.selectedComputer.Manufacturer = inputString.ReadLine();
                    Program.selectedComputer.Model = inputString.ReadLine();
                    Program.selectedComputer.RAMType = inputString.ReadLine();
                    Program.selectedComputer.RAMSize = inputString.ReadLine();
                    Program.selectedComputer.DisplayType = inputString.ReadLine();
                    Program.selectedComputer.ScreenSize = inputString.ReadLine();
                    Program.selectedComputer.Resolution = inputString.ReadLine();
                    Program.selectedComputer.CPUClass = inputString.ReadLine();
                    Program.selectedComputer.CPUBrand = inputString.ReadLine();
                    Program.selectedComputer.CPUType = inputString.ReadLine();
                    Program.selectedComputer.CPUSpeed = inputString.ReadLine();
                    Program.selectedComputer.CPUNumber = inputString.ReadLine();
                    Program.selectedComputer.Condition = inputString.ReadLine();
                    Program.selectedComputer.OS = inputString.ReadLine();
                    Program.selectedComputer.Platform = inputString.ReadLine();
                    Program.selectedComputer.HDDSize = inputString.ReadLine();
                    Program.selectedComputer.HDDSpeed = inputString.ReadLine();
                    Program.selectedComputer.GPUType = inputString.ReadLine();
                    Program.selectedComputer.OpticalDrive = inputString.ReadLine();
                    Program.selectedComputer.AudioType = inputString.ReadLine();
                    Program.selectedComputer.LAN = inputString.ReadLine();
                    Program.selectedComputer.WIFI = inputString.ReadLine();
                    Program.selectedComputer.Width = inputString.ReadLine();
                    Program.selectedComputer.Heigth = inputString.ReadLine();
                    Program.selectedComputer.Depth = inputString.ReadLine();
                    Program.selectedComputer.Weight = inputString.ReadLine();
                    Program.selectedComputer.MouseType = inputString.ReadLine();
                    Program.selectedComputer.Power = inputString.ReadLine();
                    Program.selectedComputer.Webcam = inputString.ReadLine();

                    //cleanup
                    inputString.Close();
                    inputString.Dispose();

                    //give feedback to the user that file was loaded
                    MessageBox.Show("Loaded File", "Load File", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                goToNextForm();
            }
        }

        /// <summary>
        /// This method handle the click event on saveToolStripMenu and 
        /// saveToolStripButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        /// <summary>
        /// This method handles the "save to file" action from the 
        /// saveToolStripMenu and saveToolStripButton methods.
        /// </summary>
        private void SaveToFile()
        {
            //configure the file dialog
            productSaveFileDialog.FileName = "Product.txt";
            productSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            productSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            //open the file dialog
            var result = productSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                //create stream to write on the file
                using (StreamWriter outputString = new StreamWriter(
                    File.Open(productSaveFileDialog.FileName, FileMode.OpenOrCreate)))
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
                    outputString.WriteLine(Program.selectedComputer.Webcam);

                    //cleanup
                    outputString.Close();
                    outputString.Dispose();

                    //give feedback to the user that file was saved
                    MessageBox.Show("File Saved", "Save File", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }            
        }

        /// <summary>
        /// This method handles the activate event on the ProductInfoForm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            //disable Next button until a computer was selected and fulfilled on this form
            NextButtonToOrderForm.Enabled = false;

            //Check if the LoadSavedOrder button was selected from the StartForm
            if (Program.LoadSavedOrder == true)
            {
                Program.LoadSavedOrder = false;
                loadSavedFile();
            }
            CheckClassContentAndLoadIfNotEmpty();
        }

        /// <summary>
        /// This method verify if class has already info or not, and load the data in case not
        /// </summary>
        private void CheckClassContentAndLoadIfNotEmpty()
        {
            if (Program.selectedComputer.Price != null || Program.selectedComputer.Price == string.Empty)
            {
                LoadContentFromSelectedComputerClass();
            }
        }

        /// <summary>
        /// This method load the content from the SelectedComputerClass
        /// and fulfill it into the Form label fields.
        /// </summary>
        private void LoadContentFromSelectedComputerClass()
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

            NextButtonToOrderForm.Enabled = true;
        }
    }
}