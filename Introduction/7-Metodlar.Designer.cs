﻿namespace Introduction
{
    partial class _7_Metodlar
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button10 = new Button();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 12);
            button1.Name = "button1";
            button1.Size = new Size(253, 42);
            button1.TabIndex = 0;
            button1.Text = "Temel Metod Mantığı";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(49, 60);
            button2.Name = "button2";
            button2.Size = new Size(253, 42);
            button2.TabIndex = 0;
            button2.Text = "Geriye değer dönmeyen parametresiz metod";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(49, 108);
            button3.Name = "button3";
            button3.Size = new Size(253, 42);
            button3.TabIndex = 0;
            button3.Text = "Geriye değer dönmeyen parametreli metod";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(49, 156);
            button4.Name = "button4";
            button4.Size = new Size(253, 42);
            button4.TabIndex = 0;
            button4.Text = "Renk Değiştir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(49, 204);
            button5.Name = "button5";
            button5.Size = new Size(253, 42);
            button5.TabIndex = 0;
            button5.Text = "Geriye değer dönen parametresiz metod";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(49, 252);
            button6.Name = "button6";
            button6.Size = new Size(253, 42);
            button6.TabIndex = 0;
            button6.Text = "Geriye değer dönen parametreli metod";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Location = new Point(49, 300);
            button8.Name = "button8";
            button8.Size = new Size(253, 42);
            button8.TabIndex = 0;
            button8.Text = "Sayı Toplama";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(457, 22);
            button9.Name = "button9";
            button9.Size = new Size(75, 52);
            button9.TabIndex = 2;
            button9.Text = "out";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.Location = new Point(348, 22);
            button7.Name = "button7";
            button7.Size = new Size(75, 52);
            button7.TabIndex = 3;
            button7.Text = "Ref";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button10
            // 
            button10.Location = new Point(382, 108);
            button10.Name = "button10";
            button10.Size = new Size(113, 81);
            button10.TabIndex = 4;
            button10.Text = "Cümle Birleştir";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(318, 204);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(214, 138);
            lblMesaj.TabIndex = 5;
            // 
            // _7_Metodlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 460);
            Controls.Add(lblMesaj);
            Controls.Add(button10);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "_7_Metodlar";
            Text = "_7_Metodlar";
            Load += _7_Metodlar_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button7;
        private Button button10;
        private Label lblMesaj;
    }
}