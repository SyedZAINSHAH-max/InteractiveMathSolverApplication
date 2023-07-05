using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form5
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
            lblResult = new Label();
            lblLcmResult = new Label();
            button2 = new Button();
            btnSolveQuadratic = new Button();
            txtA = new TextBox();
            lblGcdResult = new Label();
            label1 = new Label();
            txtB = new TextBox();
            txtC = new TextBox();
            SuspendLayout();
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(19, 389);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(2, 33);
            lblResult.TabIndex = 25;
            // 
            // lblLcmResult
            // 
            lblLcmResult.AutoSize = true;
            lblLcmResult.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLcmResult.Location = new Point(-22, 334);
            lblLcmResult.Name = "lblLcmResult";
            lblLcmResult.Size = new Size(0, 22);
            lblLcmResult.TabIndex = 24;
            lblLcmResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(37, 19);
            button2.Name = "button2";
            button2.Size = new Size(52, 33);
            button2.TabIndex = 23;
            button2.Text = "\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSolveQuadratic
            // 
            btnSolveQuadratic.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSolveQuadratic.Location = new Point(19, 245);
            btnSolveQuadratic.Name = "btnSolveQuadratic";
            btnSolveQuadratic.Size = new Size(442, 54);
            btnSolveQuadratic.TabIndex = 22;
            btnSolveQuadratic.Text = "Calculate";
            btnSolveQuadratic.UseVisualStyleBackColor = true;
            btnSolveQuadratic.Click += btnSolveQuadratic_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(19, 76);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.PlaceholderText = "Enter Coeffiecient of a";
            txtA.Size = new Size(442, 39);
            txtA.TabIndex = 21;
            // 
            // lblGcdResult
            // 
            lblGcdResult.AutoSize = true;
            lblGcdResult.BorderStyle = BorderStyle.FixedSingle;
            lblGcdResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGcdResult.Location = new Point(-44, 457);
            lblGcdResult.Name = "lblGcdResult";
            lblGcdResult.Size = new Size(2, 33);
            lblGcdResult.TabIndex = 20;
            lblGcdResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(132, 26);
            label1.Name = "label1";
            label1.Size = new Size(283, 19);
            label1.TabIndex = 19;
            label1.Text = "Solve Quadratic Equations Coefficients";
            // 
            // txtB
            // 
            txtB.Location = new Point(19, 121);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.PlaceholderText = "Enter Coeffiecient of b";
            txtB.Size = new Size(442, 39);
            txtB.TabIndex = 26;
            // 
            // txtC
            // 
            txtC.Location = new Point(19, 166);
            txtC.Multiline = true;
            txtC.Name = "txtC";
            txtC.PlaceholderText = "Enter Coeffiecient of c";
            txtC.Size = new Size(442, 39);
            txtC.TabIndex = 27;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 644);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(lblResult);
            Controls.Add(lblLcmResult);
            Controls.Add(button2);
            Controls.Add(btnSolveQuadratic);
            Controls.Add(txtA);
            Controls.Add(lblGcdResult);
            Controls.Add(label1);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResult;
        private Label lblLcmResult;
        private Button button2;
        private Button btnSolveQuadratic;
        private TextBox txtA;
        private Label lblGcdResult;
        private Label label1;
        private TextBox txtB;
        private TextBox txtC;
    }
}