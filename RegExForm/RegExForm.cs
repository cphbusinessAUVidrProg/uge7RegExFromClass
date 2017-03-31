using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Sofus
{
    public partial class RegExTester : Form
    {
        public RegExTester()
        {
            InitializeComponent();
        }
        
        // This method is called when we type in the test text window
        // You can see this in line 52 of the RegExForm.Designer.cs file
        // (You need to open that part of the source code by the small "+" in line 23) 
        private void testText_TextChanged(object sender, EventArgs e)
        {
            string ptn = regExText.Text;
            bool ok = Regex.Match(testText.Text, ptn).Success;
            if ( ok)
            {
                testText.BackColor = Color.Green;
            } else
            {
                testText.BackColor = Color.Red;
            }

        }

        private void buttonON_Click(object sender, EventArgs e)
        {   // Add the testText_TextChanged method as observer on the regExText textbox
            regExText.TextChanged += this.testText_TextChanged; // += adds event handler
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {   // remove the testText_TextChanged method as observer on the regExText textbox
            regExText.TextChanged -= this.testText_TextChanged; // -= removes it
        }
    }
}
