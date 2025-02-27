namespace Introduction
{
    partial class _8_ÖğrenciTakip
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
            btnKaydet = new Button();
            txtAdSoyad = new TextBox();
            label1 = new Label();
            lstListe = new ListBox();
            txtVize = new TextBox();
            label2 = new Label();
            txtFinal = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(342, 363);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(143, 46);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Not Ortalaması Hesapla";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(66, 62);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(419, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 35);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Ad Soyad:";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(67, 181);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(419, 154);
            lstListe.TabIndex = 3;
            // 
            // txtVize
            // 
            txtVize.Location = new Point(66, 133);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(164, 23);
            txtVize.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 106);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Vize Notu:";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(268, 133);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(217, 23);
            txtFinal.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 106);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "Final Notu:";
            // 
            // _8_ÖğrenciTakip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(516, 450);
            Controls.Add(lstListe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFinal);
            Controls.Add(txtVize);
            Controls.Add(txtAdSoyad);
            Controls.Add(btnKaydet);
            Name = "_8_ÖğrenciTakip";
            Text = "_8_ÖğrenciTakip";
            Load += _8_ÖğrenciTakip_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private TextBox txtAdSoyad;
        private Label label1;
        private ListBox lstListe;
        private TextBox txtVize;
        private Label label2;
        private TextBox txtFinal;
        private Label label3;
    }
}