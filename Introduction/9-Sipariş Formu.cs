namespace Introduction
{
    public partial class _9_Sipariş_Formu : Form
    {
        byte secilen;
        string[,] urunListesi = new string[3, 2];
        double sepetTutarı;

        public _9_Sipariş_Formu()
        {
            InitializeComponent();
        }

        private void _9_Sipariş_Formu_Load(object sender, EventArgs e)
        {
            ComboboxGetValues();
            UrunleriOlustur();
        }

        private void UrunleriOlustur()
        {
            urunListesi[0, 0] = "1";
            urunListesi[0, 1] = "hp laptop";

            urunListesi[1, 0] = "1";
            urunListesi[1, 1] = "pro max";

            urunListesi[2, 0] = "2";
            urunListesi[2, 1] = "hortum";
        }

        private void ComboboxGetValues()
        {
            Array tümKategoriler = Enum.GetValues(typeof(Kategoriler));
            foreach (var item in tümKategoriler)
            {
                cmbKategori.Items.Add(item);
            }
        }

        private void txtbirimFiyat_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstUrunListesi.SelectedIndex != -1 && nmrAdet.Value != 0 && !string.IsNullOrEmpty(txtbirimFiyat.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    decimal toplam = nmrAdet.Value * Convert.ToDecimal(txtbirimFiyat.Text);
                    txtSepetToplamı.Text = toplam.ToString();
                }
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedIndex != -1)
            {
                secilen = (byte)cmbKategori.SelectedItem;
                UrunleriListeyeDoldur(secilen);
            }
        }

        private void UrunleriListeyeDoldur(byte secilen)
        {
            lstUrunListesi.Items.Clear();
            int satirSayisi = urunListesi.GetLength(0);
            for (int i = 0; i < satirSayisi; i++)
            {
                if (urunListesi[i, 0] == secilen.ToString())
                {
                    lstUrunListesi.Items.Add(urunListesi[i, 1]);
                }
            }
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (rbBireysel.Checked)
            {
                double bireysel = Convert.ToInt32(txtSepetToplamı.Text) * 1.18;
                lstSepet.Items.Add($"{lstUrunListesi.SelectedItem} ---> {nmrAdet.Value} Adet ---> {bireysel} Bireysel Kdv dahil fiyatı");
                sepetTutarı += bireysel;
            }
            else if (rbKurumsal.Checked)
            {
                double kurumsal = Convert.ToInt32(txtSepetToplamı.Text) * 1.2;
                lstSepet.Items.Add($"{lstUrunListesi.SelectedItem} ---> {nmrAdet.Value} Adet ---> {kurumsal} Kurumsal Kdv dahil fiyatı");
                sepetTutarı += kurumsal;

            }
            else
            {
                MessageBox.Show("Lütfen Fatura Tipini Seçiniz.", "Fatura Tipi:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblSepetToplami.Text = $"Sepet Tutarı: {sepetTutarı}";


        }

        private void grpFaturaTipi_Enter(object sender, EventArgs e)
        {

        }
    }
}
