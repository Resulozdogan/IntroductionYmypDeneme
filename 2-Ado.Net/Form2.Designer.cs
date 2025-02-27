namespace _2_Ado.Net
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
            cmbCategories = new ComboBox();
            lstProductList = new ListBox();
            dgwDetay = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblUrunAdedi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwDetay).BeginInit();
            SuspendLayout();
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(33, 59);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(344, 23);
            cmbCategories.TabIndex = 1;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // lstProductList
            // 
            lstProductList.FormattingEnabled = true;
            lstProductList.ItemHeight = 15;
            lstProductList.Location = new Point(33, 137);
            lstProductList.Name = "lstProductList";
            lstProductList.Size = new Size(241, 274);
            lstProductList.TabIndex = 2;
            lstProductList.SelectedIndexChanged += lstProductList_SelectedIndexChanged;
            // 
            // dgwDetay
            // 
            dgwDetay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwDetay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwDetay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDetay.Location = new Point(305, 137);
            dgwDetay.Name = "dgwDetay";
            dgwDetay.Size = new Size(578, 274);
            dgwDetay.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 41);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "Bir Ürün Seçin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 118);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 5;
            label2.Text = "Ürün Listesi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 119);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 6;
            label3.Text = "Sipariş Detayları:";
            // 
            // lblUrunAdedi
            // 
            lblUrunAdedi.AutoSize = true;
            lblUrunAdedi.Location = new Point(383, 62);
            lblUrunAdedi.Name = "lblUrunAdedi";
            lblUrunAdedi.Size = new Size(67, 15);
            lblUrunAdedi.TabIndex = 7;
            lblUrunAdedi.Text = "Ürün Adedi";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 546);
            Controls.Add(lblUrunAdedi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgwDetay);
            Controls.Add(lstProductList);
            Controls.Add(cmbCategories);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgwDetay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbCategories;
        private ListBox lstProductList;
        private DataGridView dgwDetay;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblUrunAdedi;
    }
}