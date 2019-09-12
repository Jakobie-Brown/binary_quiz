using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(16);
            label1.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verify_Binary(textBox1.Text))
            {
                label1.Text = "True";
            }
            else
            {
                label1.Text = "False";
            }
        }

        private int binary_decimal_Conversion(int uInput)
        {
            return 0;
        }

        private bool verify_Binary(string binaryString)
        {
            string characters = binaryString;
            foreach (char c in characters)
            {
                Console.WriteLine(c);
                if (c.CompareTo('0') != 0 || c.CompareTo('1') != 0) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
