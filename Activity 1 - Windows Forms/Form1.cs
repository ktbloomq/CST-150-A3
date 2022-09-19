using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1___Windows_Forms
{
    public partial class Form1 : Form
    {
        // an integer field storing the number of times the clickCount label has been clicked
        int ClickCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void clickCount_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClickCounter++;
            clickCount.Text = "The lope has been clicked " + ClickCounter + " times!";
        }
    }
}
