using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // -- In this example, the location, size, color of the window and text in TextEdit 
            // -- are automatically saved. You must have the code to control the process.
        }

        private void Form1_Shown(object sender, EventArgs e)
        {                  
            // -- this kod need if you want to control process

            //textBox1.Text = Properties.Settings.Default.mText;
            //Location = Properties.Settings.Default.mLocation;            
            //Size = Properties.Settings.Default.mSize;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // -- this kod need if you want to control process

            //Properties.Settings.Default.mLocation = this.Location;
            //Properties.Settings.Default.mText = textBox1.Text;
            //Properties.Settings.Default.mSize = this.Size;

            // -- this must be done
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = this.colorDialog1.Color;
        }
    }
}

