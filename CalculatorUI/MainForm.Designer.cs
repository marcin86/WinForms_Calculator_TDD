﻿
using CalculatorLogic;
using Unity;

namespace CalculatorUI
{
    partial class MainForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnEqualSign = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 149);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(113, 188);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(35, 35);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnEqualSign
            // 
            this.btnEqualSign.Location = new System.Drawing.Point(113, 227);
            this.btnEqualSign.Margin = new System.Windows.Forms.Padding(2);
            this.btnEqualSign.Name = "btnEqualSign";
            this.btnEqualSign.Size = new System.Drawing.Size(35, 35);
            this.btnEqualSign.TabIndex = 2;
            this.btnEqualSign.Text = "=";
            this.btnEqualSign.UseVisualStyleBackColor = true;
            this.btnEqualSign.Click += new System.EventHandler(this.btnEqualSign_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 208);
            this.btn_1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(22, 24);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(39, 208);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(22, 24);
            this.btn_2.TabIndex = 4;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(67, 208);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(22, 24);
            this.btn_3.TabIndex = 5;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 179);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(22, 24);
            this.btn_4.TabIndex = 6;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(39, 179);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(22, 24);
            this.btn_5.TabIndex = 7;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(39, 149);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(22, 24);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(67, 149);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(22, 24);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(67, 178);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(22, 24);
            this.btn_6.TabIndex = 10;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 149);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(22, 24);
            this.btn_7.TabIndex = 11;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(67, 238);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(22, 24);
            this.btn_0.TabIndex = 12;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(176, 131);
            this.txtDisplay.TabIndex = 13;
            // 
            // btnComma
            // 
            this.btnComma.Location = new System.Drawing.Point(39, 238);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(22, 24);
            this.btnComma.TabIndex = 14;
            this.btnComma.Text = ".";
            this.btnComma.UseVisualStyleBackColor = true;
            this.btnComma.Click += new System.EventHandler(this.numericButton_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(153, 149);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(35, 35);
            this.btnMultiply.TabIndex = 15;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(153, 188);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(35, 35);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 273);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btnEqualSign);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnEqualSign;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
    }
}

