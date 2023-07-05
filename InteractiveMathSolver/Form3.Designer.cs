using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form3
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
            button2 = new Button();
            btnLcm = new Button();
            txtLcmInput = new TextBox();
            lblGcdResult = new Label();
            label1 = new Label();
            lblLcmResult = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(14, 41);
            button2.Name = "button2";
            button2.Size = new Size(52, 33);
            button2.TabIndex = 10;
            button2.Text = "\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnLcm
            // 
            btnLcm.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLcm.Location = new Point(12, 176);
            btnLcm.Name = "btnLcm";
            btnLcm.Size = new Size(442, 54);
            btnLcm.TabIndex = 9;
            btnLcm.Text = "Calculate";
            btnLcm.UseVisualStyleBackColor = true;
            btnLcm.Click += btnLcm_Click;
            // 
            // txtLcmInput
            // 
            txtLcmInput.Location = new Point(12, 100);
            txtLcmInput.Multiline = true;
            txtLcmInput.Name = "txtLcmInput";
            txtLcmInput.PlaceholderText = "Enter Numbers Seperated by Comma";
            txtLcmInput.Size = new Size(442, 39);
            txtLcmInput.TabIndex = 8;
            // 
            // lblGcdResult
            // 
            lblGcdResult.AutoSize = true;
            lblGcdResult.BorderStyle = BorderStyle.FixedSingle;
            lblGcdResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGcdResult.Location = new Point(-8, 403);
            lblGcdResult.Name = "lblGcdResult";
            lblGcdResult.Size = new Size(2, 33);
            lblGcdResult.TabIndex = 7;
            lblGcdResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 41);
            label1.Name = "label1";
            label1.Size = new Size(387, 33);
            label1.TabIndex = 6;
            label1.Text = "Find LCM of multiple numbers";
            // 
            // lblLcmResult
            // 
            lblLcmResult.AutoSize = true;
            lblLcmResult.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLcmResult.Location = new Point(14, 280);
            lblLcmResult.Name = "lblLcmResult";
            lblLcmResult.Size = new Size(0, 22);
            lblLcmResult.TabIndex = 11;
            lblLcmResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 621);
            Controls.Add(lblLcmResult);
            Controls.Add(button2);
            Controls.Add(btnLcm);
            Controls.Add(txtLcmInput);
            Controls.Add(lblGcdResult);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button btnLcm;
        private TextBox txtLcmInput;
        private Label lblGcdResult;
        private Label label1;
        private Label lblLcmResult;
    }
}