using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form6
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
            txtMatrixSize = new TextBox();
            lblDeterminantResult = new Label();
            lblLcmResult = new Label();
            button2 = new Button();
            btnFindDeterminant = new Button();
            txtMatrixInput = new TextBox();
            lblGcdResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtMatrixSize
            // 
            txtMatrixSize.Location = new Point(12, 154);
            txtMatrixSize.Multiline = true;
            txtMatrixSize.Name = "txtMatrixSize";
            txtMatrixSize.PlaceholderText = "Enter the Size of Matrix";
            txtMatrixSize.Size = new Size(442, 39);
            txtMatrixSize.TabIndex = 35;
            // 
            // lblDeterminantResult
            // 
            lblDeterminantResult.AutoSize = true;
            lblDeterminantResult.BorderStyle = BorderStyle.FixedSingle;
            lblDeterminantResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeterminantResult.Location = new Point(12, 298);
            lblDeterminantResult.Name = "lblDeterminantResult";
            lblDeterminantResult.Size = new Size(2, 33);
            lblDeterminantResult.TabIndex = 34;
            // 
            // lblLcmResult
            // 
            lblLcmResult.AutoSize = true;
            lblLcmResult.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLcmResult.Location = new Point(-29, 367);
            lblLcmResult.Name = "lblLcmResult";
            lblLcmResult.Size = new Size(0, 22);
            lblLcmResult.TabIndex = 33;
            lblLcmResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 52);
            button2.Name = "button2";
            button2.Size = new Size(52, 33);
            button2.TabIndex = 32;
            button2.Text = "\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnFindDeterminant
            // 
            btnFindDeterminant.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFindDeterminant.Location = new Point(12, 214);
            btnFindDeterminant.Name = "btnFindDeterminant";
            btnFindDeterminant.Size = new Size(442, 54);
            btnFindDeterminant.TabIndex = 31;
            btnFindDeterminant.Text = "Calculate";
            btnFindDeterminant.UseVisualStyleBackColor = true;
            btnFindDeterminant.Click += btnFindDeterminant_Click;
            // 
            // txtMatrixInput
            // 
            txtMatrixInput.Location = new Point(12, 109);
            txtMatrixInput.Multiline = true;
            txtMatrixInput.Name = "txtMatrixInput";
            txtMatrixInput.PlaceholderText = "Enter the Matrix Value";
            txtMatrixInput.Size = new Size(442, 39);
            txtMatrixInput.TabIndex = 30;
            // 
            // lblGcdResult
            // 
            lblGcdResult.AutoSize = true;
            lblGcdResult.BorderStyle = BorderStyle.FixedSingle;
            lblGcdResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGcdResult.Location = new Point(-51, 490);
            lblGcdResult.Name = "lblGcdResult";
            lblGcdResult.Size = new Size(2, 33);
            lblGcdResult.TabIndex = 29;
            lblGcdResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(70, 61);
            label1.Name = "label1";
            label1.Size = new Size(392, 19);
            label1.TabIndex = 28;
            label1.Text = "Find the Determinant of Any Integer Matrix Up To 4x4";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 582);
            Controls.Add(txtMatrixSize);
            Controls.Add(lblDeterminantResult);
            Controls.Add(lblLcmResult);
            Controls.Add(button2);
            Controls.Add(btnFindDeterminant);
            Controls.Add(txtMatrixInput);
            Controls.Add(lblGcdResult);
            Controls.Add(label1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatrixSize;
        private Label lblDeterminantResult;
        private Label lblLcmResult;
        private Button button2;
        private Button btnFindDeterminant;
        private TextBox txtMatrixInput;
        private Label lblGcdResult;
        private Label label1;
    }
}