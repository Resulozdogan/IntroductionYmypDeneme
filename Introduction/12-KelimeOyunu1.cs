using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class _12_KelimeOyunu1 : Form
    {
        public _12_KelimeOyunu1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "OK";
            btn.Name = "btnMerhaba";
            btn.Size = new Size(100, 50);
            btn.Location = new Point(100, 100);

            this.Controls.Add(btn);
        }

        string kelime;
        private void btnKelime_Click(object sender, EventArgs e)
        {
            grpButonlar.Controls.Clear();
            kelime = txtKelime.Text;

            for (int i = 0; i < kelime.Length; i++)
            {
                Button btn1 = new Button();
                btn1.Text = "--";
                btn1.Name = $"btn{i}";
                btn1.Tag = i;
                btn1.Size = new Size(50, 50);
                btn1.Location = new Point(30 + (50 * i), 30);
                btn1.Click += Btn1_Click;
                grpButonlar.Controls.Add(btn1);
            }
        }

        private void Btn1_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            byte a = Convert.ToByte(btn.Tag);
            btn.Text = kelime[a].ToString();

        }

        private void _12_KelimeOyunu1_Load(object sender, EventArgs e)
        {

        }
    }
}
