using COMP123_Assignment5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    CENTENNIAL COLLEGE
    COMP123 - Programming 2 - C# Windows Forms - IDE
   
    Assignment 5 - Summer 2019
    Author: Rafael Aguiar
    Student id: 301041266
    Date: Aug/13/2019
    
    Assignment: Dollar Computers

    Release Control:
    - August 13, 2019: U.I. forms first release
 */

namespace COMP123_Assignment5
{
    
    public static class Program
    {
        public static Dictionary<FormName, Form> Forms;
        public static bool LoadSavedOrder = false;
        public static Product product;
        public static SelectedComputer selectedComputer;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_FORM, new Splashform());
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.SELECT_FORM, new SelectProductForm());
            Forms.Add(FormName.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormName.ORDER_FORM, new OrderForm());
            Forms.Add(FormName.ABOUT_FORM, new AboutForm());

            product = new Product();

            selectedComputer = new SelectedComputer();

            Application.Run(Forms[FormName.SPLASH_FORM]);
        }
    }
}
