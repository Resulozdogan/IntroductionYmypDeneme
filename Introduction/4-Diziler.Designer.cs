namespace Introduction
{
    partial class _4_Diziler
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
            txtName = new TextBox();
            txtSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(405, 202);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(87, 37);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(61, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(431, 23);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(61, 148);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(431, 23);
            txtSurname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 40);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 3;
            label1.Text = "Ad:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 118);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Soyad:";
            label2.Click += label1_Click;
            // 
            // _4_Diziler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(btnKaydet);
            Name = "_4_Diziler";
            Text = "_4_Diziler";
            Load += _4_Diziler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private TextBox txtName;
        private TextBox txtSurname;
        private Label label1;
        private Label label2;
    }
}