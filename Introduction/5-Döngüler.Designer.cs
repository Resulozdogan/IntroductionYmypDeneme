namespace Introduction
{
    partial class _5_Döngüler
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            lstListe = new ListBox();
            button1 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(71, 80);
            button2.Name = "button2";
            button2.Size = new Size(276, 51);
            button2.TabIndex = 0;
            button2.Text = "For Döngüsü 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(71, 149);
            button3.Name = "button3";
            button3.Size = new Size(276, 51);
            button3.TabIndex = 0;
            button3.Text = "For Döngüsü 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(71, 206);
            button4.Name = "button4";
            button4.Size = new Size(276, 64);
            button4.TabIndex = 0;
            button4.Text = "While Döngüsü 1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(71, 291);
            button5.Name = "button5";
            button5.Size = new Size(276, 57);
            button5.TabIndex = 0;
            button5.Text = "While Döngüsü 2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(71, 364);
            button6.Name = "button6";
            button6.Size = new Size(276, 67);
            button6.TabIndex = 0;
            button6.Text = "Do While";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(397, 12);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(398, 559);
            lstListe.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(71, 12);
            button1.Name = "button1";
            button1.Size = new Size(276, 51);
            button1.TabIndex = 0;
            button1.Text = "For Döngüsü 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(71, 437);
            button7.Name = "button7";
            button7.Size = new Size(276, 66);
            button7.TabIndex = 2;
            button7.Text = "Foreach Döngüsü";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(71, 532);
            button8.Name = "button8";
            button8.Size = new Size(112, 40);
            button8.TabIndex = 3;
            button8.Text = "Continue";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(209, 532);
            button9.Name = "button9";
            button9.Size = new Size(138, 40);
            button9.TabIndex = 4;
            button9.Text = "Break";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // _5_Döngüler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 621);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(lstListe);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "_5_Döngüler";
            Text = "_5_Döngüler";
            Load += _5_Döngüler_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ListBox lstListe;
        private Button button1;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}