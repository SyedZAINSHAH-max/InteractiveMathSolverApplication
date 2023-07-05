using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtA12 = new TextBox();
            txtA21 = new TextBox();
            btnSolve = new Button();
            label1 = new Label();
            button2 = new Button();
            txtA11 = new TextBox();
            lblResult = new Label();
            lblLcmResult = new Label();
            txtB2 = new TextBox();
            txtB1 = new TextBox();
            txtA22 = new TextBox();
            SuspendLayout();
            // 
            // txtA12
            // 
            txtA12.Location = new Point(42, 116);
            txtA12.Multiline = true;
            txtA12.Name = "txtA12";
            txtA12.PlaceholderText = "Enter Coeffiecient of 2";
            txtA12.Size = new Size(442, 39);
            txtA12.TabIndex = 35;
            // 
            // txtA21
            // 
            txtA21.Location = new Point(42, 161);
            txtA21.Multiline = true;
            txtA21.Name = "txtA21";
            txtA21.PlaceholderText = "Enter Coeffiecient of 3";
            txtA21.Size = new Size(442, 39);
            txtA21.TabIndex = 36;
            // 
            // btnSolve
            // 
            btnSolve.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSolve.Location = new Point(42, 353);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(442, 54);
            btnSolve.TabIndex = 31;
            btnSolve.Text = "Calculate";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(130, 14);
            label1.Name = "label1";
            label1.Size = new Size(322, 36);
            label1.TabIndex = 28;
            label1.Text = "Solve a system of linear equations of 2 or 3\r\n unknowns using Cramer’s rule";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(60, 14);
            button2.Name = "button2";
            button2.Size = new Size(52, 33);
            button2.TabIndex = 32;
            button2.Text = "\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtA11
            // 
            txtA11.Location = new Point(42, 71);
            txtA11.Multiline = true;
            txtA11.Name = "txtA11";
            txtA11.PlaceholderText = "Enter Coeffiecient of 1";
            txtA11.Size = new Size(442, 39);
            txtA11.TabIndex = 30;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(42, 431);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(2, 33);
            lblResult.TabIndex = 29;
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            lblResult.Click += lblGcdResult_Click;
            // 
            // lblLcmResult
            // 
            lblLcmResult.AutoSize = true;
            lblLcmResult.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLcmResult.Location = new Point(1, 329);
            lblLcmResult.Name = "lblLcmResult";
            lblLcmResult.Size = new Size(0, 22);
            lblLcmResult.TabIndex = 33;
            lblLcmResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtB2
            // 
            txtB2.Location = new Point(42, 296);
            txtB2.Multiline = true;
            txtB2.Name = "txtB2";
            txtB2.PlaceholderText = "Enter Coeffiecient of 6";
            txtB2.Size = new Size(442, 39);
            txtB2.TabIndex = 39;
            // 
            // txtB1
            // 
            txtB1.Location = new Point(42, 251);
            txtB1.Multiline = true;
            txtB1.Name = "txtB1";
            txtB1.PlaceholderText = "Enter Coeffiecient of 5";
            txtB1.Size = new Size(442, 39);
            txtB1.TabIndex = 38;
            // 
            // txtA22
            // 
            txtA22.Location = new Point(42, 206);
            txtA22.Multiline = true;
            txtA22.Name = "txtA22";
            txtA22.PlaceholderText = "Enter Coeffiecient of 4";
            txtA22.Size = new Size(442, 39);
            txtA22.TabIndex = 37;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 653);
            Controls.Add(txtB2);
            Controls.Add(txtB1);
            Controls.Add(txtA22);
            Controls.Add(txtA21);
            Controls.Add(txtA12);
            Controls.Add(lblLcmResult);
            Controls.Add(button2);
            Controls.Add(btnSolve);
            Controls.Add(txtA11);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA12;
        private TextBox txtA21;
        private Button btnSolve;
        private Label label1;
        private Button button2;
        private TextBox txtA11;
        private Label lblResult;
        private Label lblLcmResult;
        private TextBox txtB2;
        private TextBox txtB1;
        private TextBox txtA22;
    }
}