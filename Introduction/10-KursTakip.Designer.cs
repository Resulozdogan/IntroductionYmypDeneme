namespace Introduction
{
    partial class _10_KursTakip
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
            txtTc = new TextBox();
            grpEgitimler = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            lstListe = new ListBox();
            btnkaydet = new Button();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            label1 = new Label();
            grpEgitimler.SuspendLayout();
            SuspendLayout();
            // 
            // txtTc
            // 
            txtTc.Location = new Point(118, 42);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(345, 23);
            txtTc.TabIndex = 1;
            // 
            // grpEgitimler
            // 
            grpEgitimler.Controls.Add(checkBox5);
            grpEgitimler.Controls.Add(checkBox4);
            grpEgitimler.Controls.Add(checkBox3);
            grpEgitimler.Controls.Add(checkBox2);
            grpEgitimler.Controls.Add(checkBox1);
            grpEgitimler.Location = new Point(501, 42);
            grpEgitimler.Name = "grpEgitimler";
            grpEgitimler.Size = new Size(200, 168);
            grpEgitimler.TabIndex = 2;
            grpEgitimler.TabStop = false;
            grpEgitimler.Text = "Eğitim Listesi";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 120);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(76, 19);
            checkBox5.TabIndex = 0;
            checkBox5.Text = ".Net Core";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 95);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(55, 19);
            checkBox4.TabIndex = 0;
            checkBox4.Text = "React";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 70);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(85, 19);
            checkBox3.TabIndex = 0;
            checkBox3.Text = "Yapay Zeka";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 45);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 19);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Phyton";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 20);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(41, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "C#";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(12, 235);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(689, 124);
            lstListe.TabIndex = 4;
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(373, 160);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(90, 34);
            btnkaydet.TabIndex = 5;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 100);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(118, 92);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(345, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 50);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 6;
            label1.Text = "T.C:";
            // 
            // _10_KursTakip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(763, 424);
            Controls.Add(label1);
            Controls.Add(btnkaydet);
            Controls.Add(lstListe);
            Controls.Add(grpEgitimler);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(txtTc);
            Name = "_10_KursTakip";
            Text = "_10_KursTakip";
            grpEgitimler.ResumeLayout(false);
            grpEgitimler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTc;
        private GroupBox grpEgitimler;
        private ListBox lstListe;
        private Button btnkaydet;
        private Label label2;
        private TextBox txtAdSoyad;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label1;
    }
}