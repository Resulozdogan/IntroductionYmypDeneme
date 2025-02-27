namespace Introduction
{
    public partial class _13_KelimeOyunu2 : Form
    {
        public _13_KelimeOyunu2()
        {
            InitializeComponent();
        }
        List<char> turkAlfabesi = new List<char>() { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', };
        List<string> sehirler = new List<string>() { "İSTANBUL", "ANTALYA", "ANKARA", "İZMİR", "BURDUR", "SAKARYA", "SİNOP", "KARS", "BOLU", "TRABZON", "AFYONKARAHİSAR" };
        List<string> secilenSehirler = new List<string>();
        List<char> sehirHarfleri = new List<char>();
        string sehir;
        byte dogruSayisi = 0;
        byte hakSayisi = 7;
        private void _13_KelimeOyunu2_Load(object sender, EventArgs e)
        {

        }
        private void btnBaşla_Click(object sender, EventArgs e)
        {
            RandomKontrol();
            hakSayisi = 7;
            dogruSayisi = 0;
            HakDogruGuncelle();
            KlavyeOlustur();
            SehirSec();
            SehirinKutusunuOlustur();
            HarflereParcala();
        }
        private void KlavyeOlustur()
        {
            flwAlfabe.Controls.Clear();
            foreach (var item in turkAlfabesi)
            {
                Button btn1 = new Button();
                btn1.Text = $"{item}";
                btn1.Name = $"btn{item}";
                btn1.Size = new Size(65, 65);
                btn1.Click += Btn1_Click;
                flwAlfabe.Controls.Add(btn1);
            }
        }
        private void Btn1_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            char basılanHarf = Convert.ToChar(btn.Text);
            foreach (var item in flwKelime.Controls)
            {
                Button btn3 = item as Button;
                if (Convert.ToChar(btn3.Tag) == basılanHarf)
                {
                    btn3.Text = btn3.Tag.ToString();
                    dogruSayisi += 1;
                    HakDogruGuncelle();
                }
            }
            if (!sehirHarfleri.Contains(basılanHarf))
            {
                hakSayisi -= 1;
                HakDogruGuncelle();
            }
            OyunDurumu();
        }
        private void OyunDurumu()
        {
            if (dogruSayisi == Convert.ToByte(sehir.Length))
            {
                TekrarButonu("Kazandınız. Tebriklerr!! ");

            }
            else if (hakSayisi == 0)
            {
                TekrarButonu($"Cevap: {sehir}.\n");
            }
        }
        private void SehirSec()
        {
            while (true)
            {
                Random rnd = new Random();
                int sayi = rnd.Next(sehirler.Count);
                if (secilenSehirler.Contains(sehirler[sayi]))
                {
                    continue;
                }
                else
                {
                    secilenSehirler.Add(sehirler[sayi]);
                    sehir = sehirler[sayi];
                    break;
                }
            }
        }
        private void SehirinKutusunuOlustur()
        {
            flwKelime.Controls.Clear();
            for (int i = 0; i < sehir.Length; i++)
            {
                Button btn2 = new Button();
                btn2.Text = "--";
                btn2.Name = $"btn{i}";
                btn2.Tag = sehir[i];
                btn2.Size = new Size(60, 50);
                flwKelime.Controls.Add(btn2);
            }
        }
        private void HarflereParcala()
        {
            sehirHarfleri.Clear();
            for (int i = 0; i < sehir.Length; i++)
            {
                sehirHarfleri.Add(sehir[i]);
            }
        }
        private void TekrarButonu(string a)
        {
            DialogResult sonuc = MessageBox.Show(a + "Tekrar Oynamak İstermisiniz:", "RGames", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                btnBaşla.PerformClick();
            }
            else if (sonuc == DialogResult.No)
            {
                Application.Exit();
            }
        }
        private void RandomKontrol()
        {
            if (sehirler.Count == secilenSehirler.Count)
            {
                secilenSehirler.Clear();
            }
        }
        private void HakDogruGuncelle()
        {
            lblDogru.Text = $"Dogru Sayınız: {dogruSayisi.ToString()}";
            lblHak.Text = $"Kalan Hak Sayınız: {hakSayisi.ToString()}";
        }
    }
}