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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void lblGcdResult_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                int a11 = int.Parse(txtA11.Text);
                int a12 = int.Parse(txtA12.Text);
                int a21 = int.Parse(txtA21.Text);
                int a22 = int.Parse(txtA22.Text);
                int b1 = int.Parse(txtB1.Text);
                int b2 = int.Parse(txtB2.Text);

                double[] results = SolveLinearEquations(a11, a12, a21, a22, b1, b2);
                if (results.Length == 2)
                {
                    lblResult.Text = $"x = {results[0]}, y = {results[1]}";
                }
                else if (results.Length == 3)
                {
                    lblResult.Text = $"x = {results[0]}, y = {results[1]}, z = {results[2]}";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input. Please enter integer coefficients only.");

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("You have devided a number with 0.\nThe system has no unique solution.");
                lblResult.Text = "The system has no unique solution.";
            }
        }

        private double[] SolveLinearEquations(int a11, int a12, int a21, int a22, int b1, int b2)
        {
            int detA = a11 * a22 - a12 * a21;
            if (detA == 0)
            {
                throw new DivideByZeroException();
            }
            else if (detA != 0 && a12 == 0 && a21 == 0)
            {
                double x = (double)b1 / a11;
                double y = (double)b2 / a22;
                return new double[] { x, y };
            }
            else
            {
                int detX1 = b1 * a22 - b2 * a12;
                int detX2 = a11 * b2 - a21 * b1;
                int detA1 = a11 * a22 - a12 * a21;
                int detA2 = a11 * a22 - a12 * a21;
                double x = (double)detX1 / detA1;
                double y = (double)detX2 / detA2;
                //
                {
                    return new double[] { x, y };
                }
            }
        }

    }
}
