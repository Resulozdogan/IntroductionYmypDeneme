namespace _4_OOPTemelPrensipler2
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
            cmbKategoriler = new ComboBox();
            lstSepet = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtUrunAdı = new TextBox();
            nmrAdet = new NumericUpDown();
            btnSepeteEkle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            SuspendLayout();
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(20, 76);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(332, 23);
            cmbKategoriler.TabIndex = 0;
            cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
            // 
            // lstSepet
            // 
            lstSepet.FormattingEnabled = true;
            lstSepet.ItemHeight = 15;
            lstSepet.Location = new Point(390, 75);
            lstSepet.Name = "lstSepet";
            lstSepet.Size = new Size(257, 334);
            lstSepet.TabIndex = 1;
            lstSepet.SelectedIndexChanged += lstSepet_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 58);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 2;
            label1.Text = "Lütfen Bir Kategori Seçiniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 123);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Ürün Adı:";
            // 
            // txtUrunAdı
            // 
            txtUrunAdı.Location = new Point(20, 141);
            txtUrunAdı.Name = "txtUrunAdı";
            txtUrunAdı.Size = new Size(332, 23);
            txtUrunAdı.TabIndex = 3;
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(232, 198);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(120, 23);
            nmrAdet.TabIndex = 4;
            // 
            // btnSepeteEkle
            // 
            btnSepeteEkle.Location = new Point(196, 239);
            btnSepeteEkle.Name = "btnSepeteEkle";
            btnSepeteEkle.Size = new Size(75, 43);
            btnSepeteEkle.TabIndex = 5;
            btnSepeteEkle.Text = "Sepet Ekle";
            btnSepeteEkle.UseVisualStyleBackColor = true;
            btnSepeteEkle.Click += btnSepeteEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(277, 239);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 43);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 454);
            Controls.Add(btnSil);
            Controls.Add(btnSepeteEkle);
            Controls.Add(nmrAdet);
            Controls.Add(txtUrunAdı);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstSepet);
            Controls.Add(cmbKategoriler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKategoriler;
        private ListBox lstSepet;
        private Label label1;
        private Label label2;
        private TextBox txtUrunAdı;
        private NumericUpDown nmrAdet;
        private Button btnSepeteEkle;
        private Button btnSil;
    }
}
