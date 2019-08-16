using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    
    Description: This is the Start Form class

    Assignment: Dollar Computers
 */

namespace COMP123_Assignment5
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method handle the StartNewOrderClick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This method handle the ExitButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This method handle the loadSavedOrderButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSavedOrderButton_Click(object sender, EventArgs e)
        {
            Program.LoadSavedOrder = true;
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
    }
}