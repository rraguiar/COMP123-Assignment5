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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
