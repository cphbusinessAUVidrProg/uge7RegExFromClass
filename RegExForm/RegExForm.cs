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
        {
            regExText.TextChanged += this.testText_TextChanged;
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            regExText.TextChanged -= this.testText_TextChanged;
        }
    }
}
