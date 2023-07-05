using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form4
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
            lblLcmResult = new Label();
            button2 = new Button();
            btnSolveLinear = new Button();
            txtLinearInput = new TextBox();
            lblGcdResult = new Label();
            label1 = new Label();
            lblLinearResult = new Label();
            SuspendLayout();
            // 
            // lblLcmResult
            // 
            lblLcmResult.AutoSize = true;
            lblLcmResult.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLcmResult.Location = new Point(-19, 337);
            lblLcmResult.Name = "lblLcmResult";
            lblLcmResult.Size = new Size(0, 22);
            lblLcmResult.TabIndex = 17;
            lblLcmResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(24, 20);
            button2.Name = "button2";
            button2.Size = new Size(52, 33);
            button2.TabIndex = 16;
            button2.Text = "\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnSolveLinear
            // 
            btnSolveLinear.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSolveLinear.Location = new Point(22, 155);
            btnSolveLinear.Name = "btnSolveLinear";
            btnSolveLinear.Size = new Size(442, 54);
            btnSolveLinear.TabIndex = 15;
            btnSolveLinear.Text = "Calculate";
            btnSolveLinear.UseVisualStyleBackColor = true;
            btnSolveLinear.Click += btnSolveLinear_Click;
            // 
            // txtLinearInput
            // 
            txtLinearInput.Location = new Point(22, 79);
            txtLinearInput.Multiline = true;
            txtLinearInput.Name = "txtLinearInput";
            txtLinearInput.PlaceholderText = "Add Linaear Equation in the form of ax + b = 0";
            txtLinearInput.Size = new Size(442, 39);
            txtLinearInput.TabIndex = 14;
            // 
            // lblGcdResult
            // 
            lblGcdResult.AutoSize = true;
            lblGcdResult.BorderStyle = BorderStyle.FixedSingle;
            lblGcdResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGcdResult.Location = new Point(-41, 460);
            lblGcdResult.Name = "lblGcdResult";
            lblGcdResult.Size = new Size(2, 33);
            lblGcdResult.TabIndex = 13;
            lblGcdResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 29);
            label1.Name = "label1";
            label1.Size = new Size(349, 19);
            label1.TabIndex = 12;
            label1.Text = "Solve Linear Equations With Double Coefficients";
            // 
            // lblLinearResult
            // 
            lblLinearResult.AutoSize = true;
            lblLinearResult.BorderStyle = BorderStyle.FixedSingle;
            lblLinearResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblLinearResult.Location = new Point(24, 262);
            lblLinearResult.Name = "lblLinearResult";
            lblLinearResult.Size = new Size(2, 33);
            lblLinearResult.TabIndex = 18;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 631);
            Controls.Add(lblLinearResult);
            Controls.Add(lblLcmResult);
            Controls.Add(button2);
            Controls.Add(btnSolveLinear);
            Controls.Add(txtLinearInput);
            Controls.Add(lblGcdResult);
            Controls.Add(label1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLcmResult;
        private Button button2;
        private Button btnSolveLinear;
        private TextBox txtLinearInput;
        private Label lblGcdResult;
        private Label label1;
        private Label lblLinearResult;
    }
}