namespace Introduction
{
    partial class _9_Sipariş_Formu
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
            label1 = new Label();
            label2 = new Label();
            btnSepeteEkle = new Button();
            lstUrunListesi = new ListBox();
            label3 = new Label();
            label4 = new Label();
            txtbirimFiyat = new TextBox();
            label5 = new Label();
            txtSepetToplamı = new TextBox();
            label6 = new Label();
            lstSepet = new ListBox();
            lblSepetToplami = new Label();
            nmrAdet = new NumericUpDown();
            grpFaturaTipi = new GroupBox();
            rbKurumsal = new RadioButton();
            rbBireysel = new RadioButton();
            cmbKategori = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            grpFaturaTipi.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 37);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori seçin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 109);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Ürün Listesi:";
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.Location = new Point(111, 448);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(268, 37);
            btnSepeteEkle.TabIndex = 2;
            btnSepeteEkle.Text = "Sepete Ekle";
            btnSepeteEkle.UseVisualStyleBackColor = true;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // lstUrunListesi
            // 
            lstUrunListesi.FormattingEnabled = true;
            lstUrunListesi.ItemHeight = 15;
            lstUrunListesi.Location = new Point(75, 145);
            lstUrunListesi.Name = "lstUrunListesi";
            lstUrunListesi.Size = new Size(343, 124);
            lstUrunListesi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 300);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Adet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 306);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 0;
            label4.Text = "Birim Fiyat:";
            // 
            // txtbirimFiyat
            // 
            txtbirimFiyat.Location = new Point(265, 339);
            txtbirimFiyat.Name = "txtbirimFiyat";
            txtbirimFiyat.Size = new Size(143, 23);
            txtbirimFiyat.TabIndex = 5;
            txtbirimFiyat.KeyDown += txtbirimFiyat_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 383);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 0;
            label5.Text = "Toplam Tutar:";
            // 
            // txtSepetToplamı
            // 
            txtSepetToplamı.Location = new Point(75, 419);
            txtSepetToplamı.Name = "txtSepetToplamı";
            txtSepetToplamı.Size = new Size(343, 23);
            txtSepetToplamı.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 37);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 0;
            label6.Text = "Sepet";
            // 
            // lstSepet
            // 
            lstSepet.FormattingEnabled = true;
            lstSepet.ItemHeight = 15;
            lstSepet.Location = new Point(465, 71);
            lstSepet.Name = "lstSepet";
            lstSepet.Size = new Size(355, 154);
            lstSepet.TabIndex = 4;
            // 
            // lblSepetToplami
            // 
            lblSepetToplami.AutoSize = true;
            lblSepetToplami.Location = new Point(465, 254);
            lblSepetToplami.Name = "lblSepetToplami";
            lblSepetToplami.Size = new Size(84, 15);
            lblSepetToplami.TabIndex = 0;
            lblSepetToplami.Text = "Sepet Toplamı:";
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(75, 340);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(120, 23);
            nmrAdet.TabIndex = 6;
            // 
            // grpFaturaTipi
            // 
            grpFaturaTipi.Controls.Add(rbKurumsal);
            grpFaturaTipi.Controls.Add(rbBireysel);
            grpFaturaTipi.Location = new Point(476, 339);
            grpFaturaTipi.Name = "grpFaturaTipi";
            grpFaturaTipi.Size = new Size(344, 146);
            grpFaturaTipi.TabIndex = 7;
            grpFaturaTipi.TabStop = false;
            grpFaturaTipi.Text = "Fatura Tipi";
            grpFaturaTipi.Enter += grpFaturaTipi_Enter;
            // 
            // rbKurumsal
            // 
            rbKurumsal.AutoSize = true;
            rbKurumsal.Location = new Point(27, 81);
            rbKurumsal.Name = "rbKurumsal";
            rbKurumsal.Size = new Size(111, 19);
            rbKurumsal.TabIndex = 0;
            rbKurumsal.TabStop = true;
            rbKurumsal.Text = "Kurumsal Fatura";
            rbKurumsal.UseVisualStyleBackColor = true;
            // 
            // rbBireysel
            // 
            rbBireysel.AutoSize = true;
            rbBireysel.Location = new Point(27, 43);
            rbBireysel.Name = "rbBireysel";
            rbBireysel.Size = new Size(101, 19);
            rbBireysel.TabIndex = 0;
            rbBireysel.TabStop = true;
            rbBireysel.Text = "Bireysel Fatura";
            rbBireysel.UseVisualStyleBackColor = true;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(74, 71);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(344, 23);
            cmbKategori.TabIndex = 8;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // _9_Sipariş_Formu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(883, 611);
            Controls.Add(cmbKategori);
            Controls.Add(grpFaturaTipi);
            Controls.Add(nmrAdet);
            Controls.Add(txtbirimFiyat);
            Controls.Add(lstSepet);
            Controls.Add(lstUrunListesi);
            Controls.Add(txtSepetToplamı);
            Controls.Add(btnSepeteEkle);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(lblSepetToplami);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "_9_Sipariş_Formu";
            Load += _9_Sipariş_Formu_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            grpFaturaTipi.ResumeLayout(false);
            grpFaturaTipi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSepeteEkle;
        private ListBox lstUrunListesi;
        private Label label3;
        private Label label4;
        private TextBox txtbirimFiyat;
        private Label label5;
        private TextBox txtSepetToplamı;
        private Label label6;
        private ListBox lstSepet;
        private Label lblSepetToplami;
        private NumericUpDown nmrAdet;
        private GroupBox grpFaturaTipi;
        private RadioButton rbKurumsal;
        private RadioButton rbBireysel;
        private ComboBox cmbKategori;
    }
}