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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private (double, double) SolveQuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                throw new ArgumentException("Equation has no real roots.");
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return (root1, root2);
            }
        }


        private void btnSolveQuadratic_Click(object sender, EventArgs e)
        {
            try
            { 
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);

            
                (double x1, double x2) = SolveQuadraticEquation(a, b, c);
                lblResult.Text = $"x1 = {x1}, x2 = {x2}";
            }
            catch (ArgumentException ex)
            {
                lblResult.Text = ex.Message;
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the value in correct order");
            }
        }
    }
}
