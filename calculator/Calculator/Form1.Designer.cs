namespace Calculator
{
    partial class Form1
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
            this.btn_result = new System.Windows.Forms.Button();
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.lbl_Numresults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(122, 266);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(86, 45);
            this.btn_result.TabIndex = 2;
            this.btn_result.Text = "Click Me To Get Results";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.button3_Click);
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(314, 100);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(100, 20);
            this.FirstNumber.TabIndex = 4;
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(314, 171);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(100, 20);
            this.SecondNumber.TabIndex = 5;
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(119, 100);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(89, 13);
            this.num1.TabIndex = 6;
            this.num1.Text = "Enter first number";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(119, 174);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(108, 13);
            this.num2.TabIndex = 7;
            this.num2.Text = "Enter second number";
            // 
            // lbl_Numresults
            // 
            this.lbl_Numresults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Numresults.Location = new System.Drawing.Point(314, 281);
            this.lbl_Numresults.Name = "lbl_Numresults";
            this.lbl_Numresults.Size = new System.Drawing.Size(100, 23);
            this.lbl_Numresults.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(586, 403);
            this.Controls.Add(this.lbl_Numresults);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Controls.Add(this.btn_result);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label lbl_Numresults;
    }
}

