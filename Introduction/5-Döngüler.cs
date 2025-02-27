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
    public partial class _5_Döngüler : Form
    {
        public _5_Döngüler()
        {
            InitializeComponent();
        }

        private void _5_Döngüler_Load(object sender, EventArgs e)
        {
            //Döngüler
            //for, while, do while, foreach
            //program yazarken kodları tekrarlamamak için döngüleri kullanırız.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1 den 10 a kadar sayıları listeye ekler
            for (int i = 1; i <= 10; i++)
            {
                lstListe.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //istediğimiz gibi modifiye edebiliriz.
            for (int i = 1; i <= 5; i++)
            {
                lstListe.Items.Add($"{i}. eleman:");
            }
        }

        string[] kategori = { "Elektronik", "Moda", "Giyim", "Ev", "Gıda", "Müzik" };

        private void button3_Click(object sender, EventArgs e)
        {
            //listenin içindeki değerleri ekrana yazmaya yarar
            for (int i = 0; i < kategori.Length; i++)
            {
                lstListe.Items.Add(kategori[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayaç = 0;
            while (sayaç < 20)
            {
                lstListe.Items.Add(sayaç);
                sayaç++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //1 den 100 e kadar olan sayılardan 5 e bölünenlerin toplamını bul.
            int counter = 0;
            int toplam = 0;
            while (counter <= 100)
            {
                if (counter % 5 == 0)
                {
                    toplam += counter;
                }
                counter++;
            }
            lstListe.Items.Add(toplam);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Do While
            //bütün kodlar bir kere çalıştıktan sonra koşulu kontrol eder
            
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Foreach
            //dizilerin içinde dolaşarak her bir elemanını sırayla getirip döngünün içine sokar.
            foreach (var item in kategori)
            {
                lstListe.Items.Add(item);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //continue döngünün o satırdan sonra başa dönüp, döngünün devam etmesini sağlar.
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Break Döngüyü sonlandırır.
        }
    }
}