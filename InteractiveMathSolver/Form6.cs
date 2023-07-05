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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        private int[,] ParseMatrix(string input, int size)
        {
            int[,] matrix = new int[size, size];
            string[] rows = input.Split('\n');

            for (int i = 0; i < size; i++)
            {
                string[] values = rows[i].Split(' ');
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            return matrix;
        }

        private int MatrixDeterminant(int[,] matrix, int size)
        {
            if (size == 1)
            {
                return matrix[0, 0];
            }

            if (size == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }

            int result = 0;

            for (int i = 0; i < size; i++)
            {
                int[,] subMatrix = new int[size - 1, size - 1];
                for (int j = 1; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        if (k < i)
                        {
                            subMatrix[j - 1, k] = matrix[j, k];
                        }
                        else if (k > i)
                        {
                            subMatrix[j - 1, k - 1] = matrix[j, k];
                        }
                    }
                }

                result += (i % 2 == 0 ? 1 : -1) * matrix[0, i] * MatrixDeterminant(subMatrix, size - 1);
            }

            return result;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnFindDeterminant_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have a TextBox called txtMatrixInput with the matrix values
                string input = txtMatrixInput.Text;
                int size = int.Parse(txtMatrixSize.Text); // Assuming a TextBox called txtMatrixSize for the size of the matrix

                int[,] matrix = ParseMatrix(input, size);
                int determinant = MatrixDeterminant(matrix, size);

                // Display the result in a Label called lblDeterminantResult
                lblDeterminantResult.Text = $"Determinant: {determinant}";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter the value in correct order");
            }

        }
    }
}
