namespace Introduction
{
    partial class Form2
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
            btnVe = new Button();
            btnVeya = new Button();
            btnHesapla = new Button();
            txtTutar = new TextBox();
            label1 = new Label();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // btnVe
            // 
            btnVe.Location = new Point(82, 34);
            btnVe.Name = "btnVe";
            btnVe.Size = new Size(100, 61);
            btnVe.TabIndex = 0;
            btnVe.Text = "ve";
            btnVe.UseVisualStyleBackColor = true;
            btnVe.Click += btnVe_Click;
            // 
            // btnVeya
            // 
            btnVeya.Location = new Point(230, 34);
            btnVeya.Name = "btnVeya";
            btnVeya.Size = new Size(100, 61);
            btnVeya.TabIndex = 1;
            btnVeya.Text = "veya";
            btnVeya.UseVisualStyleBackColor = true;
            btnVeya.Click += btnVeya_Click;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(532, 312);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(75, 23);
            btnHesapla.TabIndex = 2;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(304, 246);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(303, 23);
            txtTutar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 206);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Müşteri Satış Tutarı:";
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(304, 360);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(303, 66);
            lblMesaj.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMesaj);
            Controls.Add(label1);
            Controls.Add(txtTutar);
            Controls.Add(btnHesapla);
            Controls.Add(btnVeya);
            Controls.Add(btnVe);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVe;
        private Button btnVeya;
        private Button btnHesapla;
        private TextBox txtTutar;
        private Label label1;
        private Label lblMesaj;
    }
}