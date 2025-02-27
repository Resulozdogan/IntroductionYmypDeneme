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
    public partial class _6_Random_Sayı_Üretme : Form
    {
        public _6_Random_Sayı_Üretme()
        {
            InitializeComponent();
        }

        private void _6_Random_Sayı_Üretme_Load(object sender, EventArgs e)
        {
            //6 tane random sayı üret, hepsi farklı olsun.

            //lstListe.Items.Clear();
            //Random rnd = new Random();
            //int randomSayı = rnd.Next(6, 50);
            //lstListe.Items.Add(randomSayı);

            //dizi.contains(a) ,'a' dizide olup olmamasına göre true ya da false döner.
            //int[] sayılar = new int[] { 1, 2, 3, 4, 5 };
            //sayılar.Contains(5);


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int a = 0;
            lstListe.Items.Clear();
            int[] liste = new int[6];
            Random rnd = new Random();
            while (a <= 5)
            {
                int randomSayi = rnd.Next(1, 10);
                if (liste.Contains(randomSayi))
                {
                    continue;
                }
                else
                {
                    liste[a] = randomSayi;
                    lstListe.Items.Add(randomSayi);
                    a++;
                }
            }


        }
    }
}
