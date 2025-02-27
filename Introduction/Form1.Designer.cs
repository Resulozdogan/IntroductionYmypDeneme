namespace Introduction
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHesapla = new Button();
            txtFiyat = new TextBox();
            lblGöster = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(367, 91);
            btnHesapla.Margin = new Padding(3, 2, 3, 2);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(64, 18);
            btnHesapla.TabIndex = 0;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(148, 52);
            txtFiyat.Margin = new Padding(3, 2, 3, 2);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(283, 21);
            txtFiyat.TabIndex = 1;
            txtFiyat.TextChanged += txtFiyat_TextChanged;
            // 
            // lblGöster
            // 
            lblGöster.Location = new Point(148, 146);
            lblGöster.Name = "lblGöster";
            lblGöster.Size = new Size(283, 72);
            lblGöster.TabIndex = 2;
            lblGöster.Click += lblGöster_Click;
            // 
            // button1
            // 
            button1.Location = new Point(437, 179);
            button1.Name = "button1";
            button1.Size = new Size(198, 133);
            button1.TabIndex = 3;
            button1.Text = "Yeni Form açmayı deneme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 360);
            Controls.Add(button1);
            Controls.Add(lblGöster);
            Controls.Add(txtFiyat);
            Controls.Add(btnHesapla);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHesapla;
        private TextBox txtFiyat;
        private Label lblGöster;
        private Button button1;
    }
}
