namespace _7_BankProject
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
            groupBox1 = new GroupBox();
            btnHesapAç = new Button();
            cmbHesapTürü = new ComboBox();
            txtAySonuBakiye = new TextBox();
            label5 = new Label();
            txtİlkBakiye = new TextBox();
            label4 = new Label();
            txtAdSoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtHesapNo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAysonu = new Button();
            btnİşlemYap = new Button();
            cmbİşlemTürü = new ComboBox();
            txtİşlemNotu = new TextBox();
            label7 = new Label();
            txtTutar = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            lblHesapHareketleri = new Label();
            lblSonBakiye = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHesapAç);
            groupBox1.Controls.Add(cmbHesapTürü);
            groupBox1.Controls.Add(txtAySonuBakiye);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtİlkBakiye);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHesapNo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesap açma işlemleri";
            // 
            // btnHesapAç
            // 
            btnHesapAç.Location = new Point(226, 178);
            btnHesapAç.Name = "btnHesapAç";
            btnHesapAç.Size = new Size(75, 23);
            btnHesapAç.TabIndex = 3;
            btnHesapAç.Text = "Hesap Aç";
            btnHesapAç.UseVisualStyleBackColor = true;
            // 
            // cmbHesapTürü
            // 
            cmbHesapTürü.FormattingEnabled = true;
            cmbHesapTürü.Location = new Point(100, 62);
            cmbHesapTürü.Name = "cmbHesapTürü";
            cmbHesapTürü.Size = new Size(201, 23);
            cmbHesapTürü.TabIndex = 2;
            // 
            // txtAySonuBakiye
            // 
            txtAySonuBakiye.Location = new Point(100, 149);
            txtAySonuBakiye.Name = "txtAySonuBakiye";
            txtAySonuBakiye.Size = new Size(201, 23);
            txtAySonuBakiye.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 152);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 0;
            label5.Text = "Aysonu Bakiye";
            // 
            // txtİlkBakiye
            // 
            txtİlkBakiye.Location = new Point(100, 120);
            txtİlkBakiye.Name = "txtİlkBakiye";
            txtİlkBakiye.Size = new Size(201, 23);
            txtİlkBakiye.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 123);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 0;
            label4.Text = "İlk bakiye";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(100, 91);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(201, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 94);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 0;
            label3.Text = "Ad soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 65);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "Hesap Türü";
            // 
            // txtHesapNo
            // 
            txtHesapNo.Location = new Point(100, 33);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.Size = new Size(201, 23);
            txtHesapNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Hesap NO:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAysonu);
            groupBox2.Controls.Add(btnİşlemYap);
            groupBox2.Controls.Add(cmbİşlemTürü);
            groupBox2.Controls.Add(txtİşlemNotu);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTutar);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(12, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 230);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nakit İşlemleri";
            // 
            // btnAysonu
            // 
            btnAysonu.Location = new Point(118, 178);
            btnAysonu.Name = "btnAysonu";
            btnAysonu.Size = new Size(75, 23);
            btnAysonu.TabIndex = 3;
            btnAysonu.Text = "Ay Sonu";
            btnAysonu.UseVisualStyleBackColor = true;
            // 
            // btnİşlemYap
            // 
            btnİşlemYap.Location = new Point(226, 178);
            btnİşlemYap.Name = "btnİşlemYap";
            btnİşlemYap.Size = new Size(75, 23);
            btnİşlemYap.TabIndex = 3;
            btnİşlemYap.Text = "İşlem Yap";
            btnİşlemYap.UseVisualStyleBackColor = true;
            // 
            // cmbİşlemTürü
            // 
            cmbİşlemTürü.FormattingEnabled = true;
            cmbİşlemTürü.Location = new Point(100, 62);
            cmbİşlemTürü.Name = "cmbİşlemTürü";
            cmbİşlemTürü.Size = new Size(201, 23);
            cmbİşlemTürü.TabIndex = 2;
            // 
            // txtİşlemNotu
            // 
            txtİşlemNotu.Location = new Point(100, 120);
            txtİşlemNotu.Name = "txtİşlemNotu";
            txtİşlemNotu.Size = new Size(201, 23);
            txtİşlemNotu.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 123);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 0;
            label7.Text = "İşlem Notu";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(100, 91);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(201, 23);
            txtTutar.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 65);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 0;
            label9.Text = "İşlem Türü";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 94);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 0;
            label8.Text = "Tutar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblHesapHareketleri);
            groupBox3.Location = new Point(371, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(324, 429);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hesap Hareketleri";
            // 
            // lblHesapHareketleri
            // 
            lblHesapHareketleri.Location = new Point(17, 32);
            lblHesapHareketleri.Name = "lblHesapHareketleri";
            lblHesapHareketleri.Size = new Size(284, 380);
            lblHesapHareketleri.TabIndex = 0;
            // 
            // lblSonBakiye
            // 
            lblSonBakiye.Location = new Point(371, 475);
            lblSonBakiye.Name = "lblSonBakiye";
            lblSonBakiye.Size = new Size(324, 47);
            lblSonBakiye.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(603, 509);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 593);
            Controls.Add(button1);
            Controls.Add(lblSonBakiye);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnHesapAç;
        private ComboBox cmbHesapTürü;
        private TextBox txtAySonuBakiye;
        private Label label5;
        private TextBox txtİlkBakiye;
        private Label label4;
        private TextBox txtAdSoyad;
        private Label label3;
        private Label label2;
        private TextBox txtHesapNo;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnİşlemYap;
        private ComboBox cmbİşlemTürü;
        private TextBox txtİşlemNotu;
        private Label label7;
        private TextBox txtTutar;
        private Label label8;
        private Label label9;
        private Button btnAysonu;
        private GroupBox groupBox3;
        private Label lblHesapHareketleri;
        private Label lblSonBakiye;
        private Button button1;
    }
}
