using COMP123_Assignment5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
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
    
    Description: This is the Select Form class

    Assignment: Dollar Computers
 */

namespace COMP123_Assignment5
{
    public partial class SelectProductForm : Form
    {
        public SelectProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method handle the click event on the cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectOrderCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method handle the next button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonToProdInfoForm_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This method handle the Load event of the selectForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectProductForm_Load(object sender, EventArgs e)
        {
            //disable next button
            SelectFormNextButton.Enabled = false;

            //bind database data to the productDataGridView
            using (var db = new DollarComputersContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
            ProductDataGridView.UpdateCellValue(0, 0);
        }

        /// <summary>
        /// This method handle the cellClick event on the dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //references to the DataGridView elements
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var cells = rows[rowIndex].Cells;

            //adjust price with only 2 decimal places
            string userSelectionString = string.Empty;
            string price = cells[(int)SelectedComputerField.PRICE].Value.ToString();
            string priceAdjusted = string.Empty;
            int stringSize = (price.Length)-2;
            for (int i=0; i<stringSize; i++)
            {
                priceAdjusted += price[i];
            }

            //load the selected product´s string to the label
            userSelectionString += cells[(int)SelectedComputerField.PRODUCT_ID].Value.ToString() 
                + " " + cells[(int)SelectedComputerField.MANUFACTURER].Value.ToString() 
                + " " + cells[(int)SelectedComputerField.MODEL].Value.ToString() 
                + " $" + priceAdjusted;

            UserSelectionTextBox.Text = userSelectionString;

            //load content into SelectedComputer class to later save on file
            Program.selectedComputer.ProductID = cells[(int)SelectedComputerField.PRODUCT_ID].Value.ToString();
            Program.selectedComputer.Price = cells[(int)SelectedComputerField.PRICE].Value.ToString();
            Program.selectedComputer.Manufacturer = cells[(int)SelectedComputerField.MANUFACTURER].Value.ToString();
            Program.selectedComputer.Model = cells[(int)SelectedComputerField.MODEL].Value.ToString();
            Program.selectedComputer.RAMType = cells[(int)SelectedComputerField.RAM_TYPE].Value.ToString();
            Program.selectedComputer.RAMSize = cells[(int)SelectedComputerField.RAM_SIZE].Value.ToString();
            Program.selectedComputer.DisplayType = cells[(int)SelectedComputerField.DISPLAY_TYPE].Value.ToString();
            Program.selectedComputer.ScreenSize = cells[(int)SelectedComputerField.SCREEN_SIZE].Value.ToString();
            Program.selectedComputer.Resolution = cells[(int)SelectedComputerField.RESOLUTION].Value.ToString();
            Program.selectedComputer.CPUClass = cells[(int)SelectedComputerField.CPU_CLASS].Value.ToString();
            Program.selectedComputer.CPUBrand = cells[(int)SelectedComputerField.CPU_BRAND].Value.ToString();
            Program.selectedComputer.CPUType = cells[(int)SelectedComputerField.CPU_TYPE].Value.ToString();
            Program.selectedComputer.CPUSpeed = cells[(int)SelectedComputerField.CPU_SPEED].Value.ToString();
            Program.selectedComputer.CPUNumber = cells[(int)SelectedComputerField.CPU_NUMBER].Value.ToString();
            Program.selectedComputer.Condition = cells[(int)SelectedComputerField.CONDITION].Value.ToString();
            Program.selectedComputer.OS = cells[(int)SelectedComputerField.OS].Value.ToString();
            Program.selectedComputer.Platform = cells[(int)SelectedComputerField.PLATFORM].Value.ToString();
            Program.selectedComputer.HDDSize = cells[(int)SelectedComputerField.HDD_SIZE].Value.ToString();
            Program.selectedComputer.HDDSpeed = cells[(int)SelectedComputerField.HDD_SPEED].Value.ToString();
            Program.selectedComputer.GPUType = cells[(int)SelectedComputerField.GPU_TYPE].Value.ToString();
            Program.selectedComputer.OpticalDrive = cells[(int)SelectedComputerField.OPTICAL_DRIVE].Value.ToString();
            Program.selectedComputer.AudioType = cells[(int)SelectedComputerField.AUDIO_TYPE].Value.ToString();
            Program.selectedComputer.LAN = cells[(int)SelectedComputerField.LAN].Value.ToString();
            Program.selectedComputer.WIFI = cells[(int)SelectedComputerField.WIFI].Value.ToString();
            Program.selectedComputer.Width = cells[(int)SelectedComputerField.WIDTH].Value.ToString();
            Program.selectedComputer.Heigth = cells[(int)SelectedComputerField.HEIGTH].Value.ToString();
            Program.selectedComputer.Depth = cells[(int)SelectedComputerField.DEPTH].Value.ToString();
            Program.selectedComputer.Weight = cells[(int)SelectedComputerField.WEIGHT].Value.ToString();
            Program.selectedComputer.MouseType = cells[(int)SelectedComputerField.MOUSE_TYPE].Value.ToString();
            Program.selectedComputer.Power = cells[(int)SelectedComputerField.POWER].Value.ToString();
            Program.selectedComputer.Webcam = cells[(int)SelectedComputerField.WEB_CAM].Value.ToString();

            //enable next button after selection
            SelectFormNextButton.Enabled = true;

           //load all selected row to outputString for later use - files load/save?
            //var columnCount = ProductDataGridView.ColumnCount;

            //rows[rowIndex].Selected = true;

            //string outputString = string.Empty;
            //for (int index=0; index< columnCount; index++)
            //{
            //    outputString += cells[index].Value.ToString() + " ";
            //}
        }
    }
}
