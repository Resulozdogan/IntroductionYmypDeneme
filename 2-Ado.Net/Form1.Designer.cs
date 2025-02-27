namespace _2_Ado.Net
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
            btnUrunler = new Button();
            button2 = new Button();
            button3 = new Button();
            lstListe = new ListBox();
            txtPrdName = new TextBox();
            btnGuncelle = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnUrunler
            // 
            btnUrunler.Location = new Point(12, 12);
            btnUrunler.Name = "btnUrunler";
            btnUrunler.Size = new Size(128, 73);
            btnUrunler.TabIndex = 0;
            btnUrunler.Text = "Ürünleri Getir";
            btnUrunler.UseVisualStyleBackColor = true;
            btnUrunler.Click += btnUrunler_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 100);
            button2.Name = "button2";
            button2.Size = new Size(128, 73);
            button2.TabIndex = 0;
            button2.Text = "Kategori Getir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 365);
            button3.Name = "button3";
            button3.Size = new Size(128, 73);
            button3.TabIndex = 0;
            button3.Text = "Ürün Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(183, 12);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(387, 304);
            lstListe.TabIndex = 1;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // txtPrdName
            // 
            txtPrdName.Location = new Point(12, 331);
            txtPrdName.Name = "txtPrdName";
            txtPrdName.Size = new Size(317, 23);
            txtPrdName.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(146, 365);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(118, 73);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // button1
            // 
            button1.Location = new Point(270, 365);
            button1.Name = "button1";
            button1.Size = new Size(75, 73);
            button1.TabIndex = 4;
            button1.Text = "Kategori Sil";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnGuncelle);
            Controls.Add(txtPrdName);
            Controls.Add(lstListe);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnUrunler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUrunler;
        private Button button2;
        private Button button3;
        private ListBox lstListe;
        private TextBox txtPrdName;
        private Button btnGuncelle;
        private Button button1;
    }
}
