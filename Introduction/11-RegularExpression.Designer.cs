namespace Introduction
{
    partial class _11_RegularExpression
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
            txtDeger = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtDeger
            // 
            txtDeger.Location = new Point(12, 48);
            txtDeger.Name = "txtDeger";
            txtDeger.Size = new Size(358, 23);
            txtDeger.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 102);
            button1.Name = "button1";
            button1.Size = new Size(358, 60);
            button1.TabIndex = 1;
            button1.Text = "kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 177);
            button2.Name = "button2";
            button2.Size = new Size(358, 56);
            button2.TabIndex = 2;
            button2.Text = "Harf Test";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 248);
            button3.Name = "button3";
            button3.Size = new Size(358, 68);
            button3.TabIndex = 3;
            button3.Text = "Email Kontrol";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // _11_RegularExpression
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDeger);
            Name = "_11_RegularExpression";
            Text = "_11_RegularExpression";
            Load += _11_RegularExpression_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDeger;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}