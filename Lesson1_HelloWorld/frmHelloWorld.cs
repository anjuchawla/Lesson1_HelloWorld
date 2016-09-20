using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Name: Anju Chawla
 * Date: Septemeber 20, 2016
 * Purpose: Create a windows form with labels and buttons. 
 * Display the message in different languages
 * 
 * */
namespace Lesson1_HelloWorld
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            //display message in the label in English
            lblMessage.Text = "Hello World";
            //lblMessage.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            //display message in the label in Spanish
            lblMessage.Text = "Halo Mundo";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear the contents of the message label
            lblMessage.Text = String.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
           // Application.Exit();
            this.Close();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //previews the form
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print(); 
        }
    }
}
