using _4_OOPTemelPrensipler2.Entities;

namespace _4_OOPTemelPrensipler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            cmbKategoriler.Items.AddRange(new string[] { "Gömlek", "Cep Telefonu" });
        }
        int secilenKategori;
        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKategori = cmbKategoriler.SelectedIndex;
        }
        Sepet sepetim = new Sepet();
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {

            if (secilenKategori == 0)
            {
                Gomlek g = new Gomlek()
                {
                    Description = "yeni sezon",
                    Material = "Pamuk",
                    UnitPrice = 6000,
                    ProductName = txtUrunAdý.Text,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    Size = "XL"
                };
                sepetim.SepeteUrunEkle(g);
            }
            else
            {
                CepTelefonu cep = new CepTelefonu()
                {
                    BatteryLife = 0,
                    Description = "Yeni",
                    ProductName = txtUrunAdý.Text,
                    Quantity = Convert.ToInt32(nmrAdet.Value),
                    RamCapacity = 0,
                    UnitPrice = 5000,

                };
                sepetim.SepeteUrunEkle(cep);
            }
            ListeyiGüncelle();
        }

        private void ListeyiGüncelle()
        {
            lstSepet.Items.Clear();
            sepetim.TumUrunleriListele()?.ForEach(x => lstSepet.Items.Add(x));
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstSepet.SelectedIndex != -1)
            {
                sepetim.SepettenUrunCikar(secilenUrun);
                ListeyiGüncelle();
            }
        }
        Urun secilenUrun;
        private void lstSepet_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenUrun = (Urun)lstSepet.SelectedItem;
        }
    }
}
