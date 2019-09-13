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
        { //changes label to an intger in the range [0,15]
            Random r = new Random();
            int i = r.Next(15);
            label1.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        { //handles button click
            if (int.TryParse(label1.Text, out int randomInt))
            {
                if (verify_Binary(textBox1.Text))
                {
                    double convertedBinary = binary_decimal_Conversion(textBox1.Text);
                    if(randomInt == convertedBinary)
                    {
                        label1.Text = "Correct";
                    }
                    else
                    {
                        label1.Text = "Incorrect";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a binary number.");
                }
            }
            else
            {
                MessageBox.Show("Please click the label to produce a random integer.");
            }
        }

        private double binary_decimal_Conversion(string binaryString)
        { //converts the entered binary string to decimal
            int _base = 2;
            int i = binaryString.Length;
            double convertedBinary = 0;
            foreach (char c in binaryString)
            {
                int numberValue = (int)char.GetNumericValue(c);
                i--;
                double weight = Math.Pow(_base, i);
                convertedBinary += numberValue * weight;
            }
            return convertedBinary;
        }

        private bool verify_Binary(string binaryString)
        { //Verifies that every character entered is '1' or '0'
            if (binaryString == "")
            { //return false if the string is empty
                return false;
            }
            
            foreach (char c in binaryString)
            { //returns false if any character entered is not '0' or '1'
                if (c.CompareTo('0') != 0 && c.CompareTo('1') != 0) 
                {
                    return false;
                }
            }
            return true; //returns true if none of the conditional statements are met
        }
    }
}
