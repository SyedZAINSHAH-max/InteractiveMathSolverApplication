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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Add a method to parse and solve a linear equation in the form ax + b = 0
        private double SolveLinearEquation(string equation)
        {
            string[] parts = equation.Split(new[] { 'x', '+', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double a = double.Parse(parts[0]);
            double b = double.Parse(parts[1]);

            return -b / a;
        }


        private void btnSolveLinear_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have a TextBox called txtLinearInput with the linear equation
                string equation = txtLinearInput.Text;
                double result = SolveLinearEquation(equation);

                // Display the result in a Label called lblLinearResult
                lblLinearResult.Text = $"x = {result}";
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the value in correct order");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
