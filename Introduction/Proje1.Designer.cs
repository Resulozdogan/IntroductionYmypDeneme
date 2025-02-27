namespace Introduction
{
    partial class Proje1
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
            flwKisiler = new FlowLayoutPanel();
            txtHisse = new TextBox();
            label2 = new Label();
            txtKisiSayisi = new TextBox();
            label1 = new Label();
            btnOlustur = new Button();
            btnHesapla = new Button();
            SuspendLayout();
            // 
            // flwKisiler
            // 
            flwKisiler.AutoScroll = true;
            flwKisiler.Location = new Point(16, 198);
            flwKisiler.Margin = new Padding(4, 5, 4, 5);
            flwKisiler.Name = "flwKisiler";
            flwKisiler.Size = new Size(332, 452);
            flwKisiler.TabIndex = 0;
            // 
            // txtHisse
            // 
            txtHisse.Location = new Point(17, 80);
            txtHisse.Margin = new Padding(4, 5, 4, 5);
            txtHisse.Name = "txtHisse";
            txtHisse.Size = new Size(243, 27);
            txtHisse.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(285, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 3;
            label2.Text = "Kişi Sayısı:";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtKisiSayisi
            // 
            txtKisiSayisi.Location = new Point(285, 80);
            txtKisiSayisi.Margin = new Padding(4, 5, 4, 5);
            txtKisiSayisi.Name = "txtKisiSayisi";
            txtKisiSayisi.Size = new Size(243, 27);
            txtKisiSayisi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(17, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 5;
            label1.Text = "Toplam Hisse Miktarı:";
            // 
            // btnOlustur
            // 
            btnOlustur.Location = new Point(401, 125);
            btnOlustur.Margin = new Padding(4, 5, 4, 5);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(128, 63);
            btnOlustur.TabIndex = 6;
            btnOlustur.Text = "Oluştur";
            btnOlustur.UseVisualStyleBackColor = true;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(524, 750);
            btnHesapla.Margin = new Padding(4, 5, 4, 5);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(100, 65);
            btnHesapla.TabIndex = 7;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Proje1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 988);
            Controls.Add(btnHesapla);
            Controls.Add(btnOlustur);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtKisiSayisi);
            Controls.Add(txtHisse);
            Controls.Add(flwKisiler);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Proje1";
            Text = "Proje1";
            Load += Proje1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flwKisiler;
        private TextBox txtHisse;
        private Label label2;
        private TextBox txtKisiSayisi;
        private Label label1;
        private Button btnOlustur;
        private Button btnHesapla;
    }
}