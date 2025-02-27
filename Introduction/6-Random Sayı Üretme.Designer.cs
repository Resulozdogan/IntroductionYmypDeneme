namespace Introduction
{
    partial class _6_Random_Sayı_Üretme
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
            lstListe = new ListBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(12, 23);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(497, 259);
            lstListe.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(92, 319);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(309, 75);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Sayı Oluştur";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // _6_Random_Sayı_Üretme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 457);
            Controls.Add(btnKaydet);
            Controls.Add(lstListe);
            Name = "_6_Random_Sayı_Üretme";
            Text = "_6_Random_Sayı_Üretme";
            Load += _6_Random_Sayı_Üretme_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstListe;
        private Button btnKaydet;
    }
}