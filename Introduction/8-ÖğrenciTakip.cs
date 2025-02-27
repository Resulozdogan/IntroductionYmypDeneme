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
    public partial class _8_ÖğrenciTakip : Form
    {
        public _8_ÖğrenciTakip()
        {
            InitializeComponent();
        }

        Dictionary<string, double> ogrenciListesi = new Dictionary<string, double>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region Dictionary Tanımlama
            //dictionary nedir:
            //Anahtar-değer (key-value) mantığı ile çalışan oldukça kullanışlı bir koleksiyon yapısısır.
            //Anahtar ve değerler farklı tiplerde olabilir.
            //Anahtarlar benzersizdir.

            #endregion



            
            lstListe.Items.Clear();
            try
            {
                string adSoyad = txtAdSoyad.Text;
                double vizeNotu = Convert.ToDouble(txtVize.Text);
                double finalNotu = Convert.ToDouble(txtFinal.Text);

                double ortalama = OrtalamaHesapla(vizeNotu, finalNotu);

                ogrenciListesi.Add(adSoyad, ortalama);
                ListeyiGüncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ListeyiGüncelle()
        {
            foreach (var item in ogrenciListesi)
            {
                lstListe.Items.Add($"{item.Key}-{item.Value}");
            }
        }

        private double OrtalamaHesapla(double vizeNotu, double finalNotu)
        {
            return (vizeNotu * 0.4) + (finalNotu * 0.6);
        }

        private void _8_ÖğrenciTakip_Load(object sender, EventArgs e)
        {

        }
    }
}
