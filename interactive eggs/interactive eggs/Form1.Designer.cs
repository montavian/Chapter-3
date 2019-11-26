namespace interactive_eggs
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
            this.txtEntry1 = new System.Windows.Forms.TextBox();
            this.txtEntry2 = new System.Windows.Forms.TextBox();
            this.txtEntry3 = new System.Windows.Forms.TextBox();
            this.txtEntry5 = new System.Windows.Forms.TextBox();
            this.txtEntry4 = new System.Windows.Forms.TextBox();
            this.btnCalculate_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntry1
            // 
            this.txtEntry1.Location = new System.Drawing.Point(114, 104);
            this.txtEntry1.Name = "txtEntry1";
            this.txtEntry1.Size = new System.Drawing.Size(100, 20);
            this.txtEntry1.TabIndex = 0;
            // 
            // txtEntry2
            // 
            this.txtEntry2.Location = new System.Drawing.Point(286, 104);
            this.txtEntry2.Name = "txtEntry2";
            this.txtEntry2.Size = new System.Drawing.Size(100, 20);
            this.txtEntry2.TabIndex = 1;
            // 
            // txtEntry3
            // 
            this.txtEntry3.Location = new System.Drawing.Point(476, 104);
            this.txtEntry3.Name = "txtEntry3";
            this.txtEntry3.Size = new System.Drawing.Size(100, 20);
            this.txtEntry3.TabIndex = 2;
            // 
            // txtEntry5
            // 
            this.txtEntry5.Location = new System.Drawing.Point(286, 186);
            this.txtEntry5.Name = "txtEntry5";
            this.txtEntry5.Size = new System.Drawing.Size(100, 20);
            this.txtEntry5.TabIndex = 3;
            // 
            // txtEntry4
            // 
            this.txtEntry4.Location = new System.Drawing.Point(114, 186);
            this.txtEntry4.Name = "txtEntry4";
            this.txtEntry4.Size = new System.Drawing.Size(100, 20);
            this.txtEntry4.TabIndex = 4;
            // 
            // btnCalculate_Click
            // 
            this.btnCalculate_Click.Location = new System.Drawing.Point(275, 278);
            this.btnCalculate_Click.Name = "btnCalculate_Click";
            this.btnCalculate_Click.Size = new System.Drawing.Size(111, 23);
            this.btnCalculate_Click.TabIndex = 5;
            this.btnCalculate_Click.Text = "Click to calculate";
            this.btnCalculate_Click.UseVisualStyleBackColor = true;
            this.btnCalculate_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter eggs porduced by each of five chickens";
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(275, 340);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(184, 23);
            this.lblResults.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate_Click);
            this.Controls.Add(this.txtEntry4);
            this.Controls.Add(this.txtEntry5);
            this.Controls.Add(this.txtEntry3);
            this.Controls.Add(this.txtEntry2);
            this.Controls.Add(this.txtEntry1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntry1;
        private System.Windows.Forms.TextBox txtEntry2;
        private System.Windows.Forms.TextBox txtEntry3;
        private System.Windows.Forms.TextBox txtEntry5;
        private System.Windows.Forms.TextBox txtEntry4;
        private System.Windows.Forms.Button btnCalculate_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResults;
    }
}

