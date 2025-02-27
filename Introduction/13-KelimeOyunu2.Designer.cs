namespace Introduction
{
    partial class _13_KelimeOyunu2
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
            btnBaşla = new Button();
            flwKelime = new FlowLayoutPanel();
            flwAlfabe = new FlowLayoutPanel();
            lblHak = new Label();
            lblDogru = new Label();
            SuspendLayout();
            // 
            // btnBaşla
            // 
            btnBaşla.Location = new Point(12, 12);
            btnBaşla.Margin = new Padding(4, 2, 4, 2);
            btnBaşla.Name = "btnBaşla";
            btnBaşla.Size = new Size(257, 72);
            btnBaşla.TabIndex = 0;
            btnBaşla.Text = "Kelime Seç ve Başla";
            btnBaşla.UseVisualStyleBackColor = true;
            btnBaşla.Click += btnBaşla_Click;
            // 
            // flwKelime
            // 
            flwKelime.Location = new Point(12, 91);
            flwKelime.Margin = new Padding(4, 2, 4, 2);
            flwKelime.Name = "flwKelime";
            flwKelime.Size = new Size(878, 186);
            flwKelime.TabIndex = 1;
            // 
            // flwAlfabe
            // 
            flwAlfabe.Location = new Point(12, 282);
            flwAlfabe.Margin = new Padding(4, 2, 4, 2);
            flwAlfabe.Name = "flwAlfabe";
            flwAlfabe.Size = new Size(727, 384);
            flwAlfabe.TabIndex = 2;
            // 
            // lblHak
            // 
            lblHak.Font = new Font("Wide Latin", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHak.Location = new Point(275, 12);
            lblHak.Margin = new Padding(4, 0, 4, 0);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(214, 72);
            lblHak.TabIndex = 3;
            lblHak.Text = "Hak Sayısı";
            // 
            // lblDogru
            // 
            lblDogru.Font = new Font("Wide Latin", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDogru.Location = new Point(526, 9);
            lblDogru.Margin = new Padding(4, 0, 4, 0);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(214, 76);
            lblDogru.TabIndex = 3;
            lblDogru.Text = "Dogru Sayısı";
            // 
            // _13_KelimeOyunu2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 784);
            Controls.Add(lblDogru);
            Controls.Add(lblHak);
            Controls.Add(flwAlfabe);
            Controls.Add(flwKelime);
            Controls.Add(btnBaşla);
            Margin = new Padding(4, 2, 4, 2);
            Name = "_13_KelimeOyunu2";
            Text = "_13_KelimeOyunu2";
            Load += _13_KelimeOyunu2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBaşla;
        private FlowLayoutPanel flwKelime;
        private FlowLayoutPanel flwAlfabe;
        private Label lblHak;
        private Label lblDogru;
    }
}