using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }


        private void btnGcd_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have a TextBox called txtGcdInput with the numbers separated by commas
                string[] input = txtGcdInput.Text.Split(',');
                int gcd = int.Parse(input[0]);

                for (int i = 1; i < input.Length; i++)
                {
                    int number = int.Parse(input[i]);
                    gcd = GCD(gcd, number);
                }

                // Display the result in a Label called lblGcdResult
                lblGcdResult.Text = $"GCD: {gcd}";

            }
            catch (Exception)
            {
                MessageBox.Show("Enter the value in correct order");
            }
        }

        private void lblGcdResult_Click(object sender, EventArgs e)
        {

        }

        private void txtGcdInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
