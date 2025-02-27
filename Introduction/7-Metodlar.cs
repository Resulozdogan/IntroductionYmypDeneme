namespace Introduction
{
    public partial class _7_Metodlar : Form
    {
        public _7_Metodlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //void metodlar geriye değer donmez. İşlemi yapar.
            //Mor küpler metoddur.
            //MessageBox.Show("Yeni bir deneme","Metodlar",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //.show bir metoddur. Mor küp
            /*
             Metodlar:
            Program içerisinde aynı işi yapan satırları belirli bir düzende bir araya getirdiğimiz yapılardır.
            Gerektiğinde cağrılarak kullanılır. Kod tekrarı yapmamızın önüne geçer.

            Metod Türleri:

            1- Geriye değer dönen metodlar:
                parametre alanlar
                parametre almayanlar

            2-Geriye değer dönmeyen metodlar:
                parametre alanlar
                parametre almayanlar
             
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Geriye değer dönmeyen parametresiz metod
            MesajVer();
        }

        private void MesajVer()
        {
            MessageBox.Show("Deneme");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Geriye değer dönmeyen parametreli metod
            MesajGönder("Yeni Bir metod");
        }
        /*metodOverload bu şekilde yapılıyor. isimleri aynı olabilir içine aldığı değerlerin değişikliği bu overload a
sebep oluyor. başlık aynı olabilir ama parantez içi farklı olmak zorunda.
*/
        private void MesajGönder(string mesaj)
        {
            MessageBox.Show(mesaj);
        }
        private void MesajGönder(string a, string b)
        {
            MessageBox.Show(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RenkDegistir();
        }

        private void RenkDegistir()
        {
            this.BackColor = Color.Coral;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //geriye değer dönen, parametresiz metod
            int randomSayi = RandomSayiOlustur();
        }

        private int RandomSayiOlustur()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0, 50);
            return sayi;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //geriye değer dönen parametreli metod
            int a = RandomSayiOlustur(5, 15);
        }

        private int RandomSayiOlustur(int a, int b)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(a, b);
            return sayi;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //iki sayıyı toplayan bir method yapalım:

            int toplamSonuc = SayilariTopla(56, 80);
            int sonuc = SayilariTopla(3, 4, 5);
        }

        private int SayilariTopla(int a, int b)
        {
            return a + b;
        }

        private int SayilariTopla(int a, int b, int c)
        {
            return a + b + c;
        }
        //tek satırlık if else bloğu:
        //a = a==b ? c : d

        int[] sayiDizim = new int[] { 3, 4, 5, 7, 98, 87 };
        private int SayilariTopla(int[] c)
        {
            int toplam = 0;
            foreach (var item in sayiDizim)
            {
                toplam += item;
            }
            return toplam;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ref anahtar kelimesi
            //referans olarak kullanmak için kullanırız ref'i . bu sayede değer globalde de değişir.
            //daha öncesinde ref olarak aldığımız değere değer atanmalıdır.

            int sayi = 1;
            DegerDegistir(ref sayi);
            MessageBox.Show(sayi.ToString());
        }

        private void DegerDegistir(ref int sayi)
        {
            sayi = 100;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Out Anahtar Kelimesi
            //refden farkı, daha öncesinde değer ataması yapmamıza gerek yoktur.
            //mutlaka metod içinde değiştirmeliyim değerimi.

            int number;
            DegerDegistirOut(out number);
            MessageBox.Show(number.ToString());
        }

        private void DegerDegistirOut(out int number)
        {
            number = 100;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string ad = "Ahmet", soyad = "Aksakal", adSoyad;
            CumleBirlestir(ad, ref soyad, out adSoyad);
            lblMesaj.Text = $"{ad}\n{soyad}\n{adSoyad}";
        }

        private void CumleBirlestir(string ad, ref string soyad, out string adSoyad)
        {
            ad = "Kuzey";
            soyad = "Genç";
            adSoyad = ad + " " + soyad;
        }

        private void _7_Metodlar_Load(object sender, EventArgs e)
        {

        }

        //params, metodun paremetlerinin sınırsız olmasını sağlıyor.

    }
}
