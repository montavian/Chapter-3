﻿namespace FixedDebugThree2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.helloButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnteredName = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.goodbyeButton = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.Location = new System.Drawing.Point(42, 122);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(75, 23);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Hello";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a button to see a Hello greeting\r\nor a Goodbye greeting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your name: ";
            // 
            // txtEnteredName
            // 
            this.txtEnteredName.Location = new System.Drawing.Point(148, 28);
            this.txtEnteredName.Name = "txtEnteredName";
            this.txtEnteredName.Size = new System.Drawing.Size(93, 20);
            this.txtEnteredName.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(75, 183);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 5;
            // 
            // goodbyeButton
            // 
            this.goodbyeButton.Location = new System.Drawing.Point(188, 121);
            this.goodbyeButton.Name = "goodbyeButton";
            this.goodbyeButton.Size = new System.Drawing.Size(75, 23);
            this.goodbyeButton.TabIndex = 6;
            this.goodbyeButton.Text = "goodbye";
            this.goodbyeButton.UseVisualStyleBackColor = true;
            this.goodbyeButton.Click += new System.EventHandler(this.goodbyeButton_Click_1);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(90, 201);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 23);
            this.lblOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.goodbyeButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.txtEnteredName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helloButton);
            this.Name = "Form1";
            this.Text = "Two Greetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnteredName;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button goodbyeButton;
        private System.Windows.Forms.Label lblOutput;
    }
}

