using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label9 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 0);
            label3.Margin = new Padding(9, 0, 9, 0);
            label3.Name = "label3";
            label3.Size = new Size(182, 100);
            label3.TabIndex = 3;
            label3.Text = "Find GCD of multiple numbers";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(9, 0);
            label9.Margin = new Padding(9, 0, 9, 0);
            label9.Name = "label9";
            label9.Size = new Size(182, 100);
            label9.TabIndex = 4;
            label9.Text = "Find LCM of multiple numbers";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 7);
            label1.Name = "label1";
            label1.Size = new Size(494, 46);
            label1.TabIndex = 0;
            label1.Text = "Interactive Math Solver";
            // 
            // button1
            // 
            button1.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(32, 66);
            button1.Name = "button1";
            button1.Size = new Size(442, 54);
            button1.TabIndex = 1;
            button1.Text = "Find GCD of multiple numbers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(32, 141);
            button2.Name = "button2";
            button2.Size = new Size(442, 54);
            button2.TabIndex = 2;
            button2.Text = "Find LCM of multiple numbers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(32, 293);
            button3.Name = "button3";
            button3.Size = new Size(442, 54);
            button3.TabIndex = 4;
            button3.Text = "Solve Quadratic equations with double coefficients";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(32, 218);
            button4.Name = "button4";
            button4.Size = new Size(442, 54);
            button4.TabIndex = 3;
            button4.Text = "Solve Linear equations with double coefficients";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(32, 442);
            button5.Name = "button5";
            button5.Size = new Size(442, 54);
            button5.TabIndex = 6;
            button5.Text = "Solve a system of linear equations of 2 or 3 unknowns using Cramer’s rule";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(32, 367);
            button6.Name = "button6";
            button6.Size = new Size(442, 54);
            button6.TabIndex = 5;
            button6.Text = "Find the determinant of any integer matrix up to 4x4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(29F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 544);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(9, 6, 9, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label9;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}