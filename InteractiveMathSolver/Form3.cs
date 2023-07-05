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
    public partial class Form3 : Form
    {
        public Form3()
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


        private int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }



        private void btnLcm_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have a TextBox called txtLcmInput with the numbers separated by commas
                string[] input = txtLcmInput.Text.Split(',');
                int lcm = int.Parse(input[0]);

                for (int i = 1; i < input.Length; i++)
                {
                    int number = int.Parse(input[i]);
                    lcm = LCM(lcm, number);
                }

                // Display the result in a Label called lblLcmResult
                lblLcmResult.Text = $"LCM: {lcm}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter the value in correct order");
            }


        }
    }
}
