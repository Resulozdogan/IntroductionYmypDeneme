using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class Proje1 : Form
    {
        public Proje1()
        {
            InitializeComponent();
        }
        byte kisiSayisi = 0;
        Proje1 yeniForm;
        string ekok1;
        private void Proje1_Load(object sender, EventArgs e)
        {

        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            flwKisiler.Controls.Clear();
            KisileriOlustur(txtKisiSayisi.Text);
        }
        private void KisileriOlustur(string a)
        {
            if (Regex.IsMatch(a, "^-?\\d+$"))
            {
                kisiSayisi = Convert.ToByte(a);
                for (int i = 0; i < kisiSayisi; i++)
                {
                    GroupBox grp = new GroupBox();
                    grp.Name = "grp" + i;
                    grp.SuspendLayout();
                    grp.Size = new Size(230, 40);
                    flwKisiler.Controls.Add((GroupBox)grp);

                    Label lbl2 = new Label();
                    lbl2.Text = "Hisse Miktarı:";
                    lbl2.TextAlign = ContentAlignment.BottomRight;
                    lbl2.Font = new Font(lbl2.Font.FontFamily, 10);
                    lbl2.Location = new Point(0, 10);
                    grp.Controls.Add(lbl2);

                    TextBox txtLot = new TextBox();
                    txtLot.Name = "txt" + i;
                    txtLot.Tag = i;
                    txtLot.Width = 70;
                    txtLot.Location = new Point(100, 13);
                    grp.Controls.Add(txtLot);


                    RadioButton rdb = new RadioButton();
                    rdb.Name = "rdb" + i;
                    rdb.Text = "Ölü";
                    rdb.Tag = i;
                    rdb.TextAlign = ContentAlignment.MiddleLeft;
                    rdb.Location = new Point(180, 13);
                    rdb.AutoCheck = false;
                    rdb.Click += Rdb_Click;
                    grp.Controls.Add(rdb);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Sadece Rakamsal Değerler Giriniz.", "Hata", MessageBoxButtons.OK);
            }
        }
        private void Rdb_Click(object? sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if (rdb.Checked == false)
            {
                rdb.Checked = true;
            }
            else if (rdb.Checked == true)
            {
                rdb.Checked = false;
            }
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Topla();
            KontrolEt();


        }
        private void Topla()
        {
            int toplam = 0;
            foreach (var item in flwKisiler.Controls)
            {
                if (item is GroupBox)
                {
                    GroupBox grp = item as GroupBox;
                    foreach (var item1 in grp.Controls)
                    {
                        if (item1 is TextBox)
                        {
                            TextBox txt = item1 as TextBox;
                            toplam += Convert.ToInt32(txt.Text);
                        }
                    }
                }
            }
            txtHisse.Text = toplam.ToString();
        }
        private void KontrolEt()
        {
            foreach (var item in flwKisiler.Controls)
            {
                GroupBox grp = (GroupBox)item;
                ekok1 = null;
                foreach (var item1 in grp.Controls)
                {

                    if (item1 is TextBox)
                    {
                        TextBox txt = item1 as TextBox;
                        ekok1 = txt.Text;
                    }
                    if (item1 is RadioButton)
                    {
                        RadioButton rdb = item1 as RadioButton;
                        if (rdb.Checked)
                        {
                            yeniForm = new Proje1();
                            yeniForm.txtHisse.Text = ekok1;
                            yeniForm.label1.Text = "Mevcut Hisse Sayısı:";
                            yeniForm.btnHesapla.Click += YeniFormHesapla;
                            yeniForm.ShowDialog();
                        }
                    }
                }
            }
        }
        private void YeniFormHesapla(object? sender, EventArgs e)
        {
            int a = Convert.ToInt32(yeniForm.txtHisse.Text);
            int c = EbobHesapla(a, Convert.ToInt32(ekok1));
            int ekok = a / c;
            int x = Convert.ToInt32(txtHisse.Text);
            x *= ekok;
            txtHisse.Text = x.ToString();
            foreach (var item in flwKisiler.Controls)
            {
                GroupBox grp = item as GroupBox;
                foreach (var item1 in grp.Controls)
                {
                    if (item1 is TextBox)
                    {
                        TextBox txt2 = item1 as TextBox;
                        int y = Convert.ToInt32(txt2.Text);
                        y *= ekok;
                        txt2.Text = y.ToString();
                    }
                }
            }
            
        }
        private int EbobHesapla(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

    }
}
