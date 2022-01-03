using System;
using System.Windows.Forms;
using static System.Console;

namespace Manis_ExceptionHandlingDemoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void IntButton_Click(object sender, EventArgs e)
        {
            string temp = intBox.Text;

            if (checkInt(temp) == true)
                outputBox.Text = "Success! The entry is an integer! ";

            if (checkInt(temp) == false)
                outputBox.Text = "Oh no, the entry was not an integer. ";
        }
        public static bool checkInt(string input)
        {
            try
            {
                Convert.ToInt32(input);
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}