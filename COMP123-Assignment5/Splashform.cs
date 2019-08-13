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
    
    Description: This is the Splash Form class

    Assignment: Dollar Computers
 */

namespace COMP123_Assignment5
{
    public partial class Splashform : Form
    {
        public Splashform()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the handler for the tick event on the Splash Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;
            this.Hide();
            Program.Forms[FormName.START_FORM].Show();
            
        }
    }
}
