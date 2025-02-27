using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOPTemelPrensipler2.Entities
{
    public class Sepet
    {
        private List<Urun>? UrunListesi { get; set; } = new();
        public void SepeteUrunEkle(Urun prd)
        {
            var deger = UrunListesi?.FirstOrDefault(x => x.ProductName == prd.ProductName);
            if (deger != null)
            {
                deger.Quantity += prd.Quantity;
            }
            else
            {
                UrunListesi.Add(prd);
            }
        }
        public void SepettenUrunCıkar(Urun prd)
        {
            UrunListesi?.Remove(prd);
        }
        public List<Urun>? TumUrunleriListele()
        {
            return UrunListesi;
        }

        public void SepettenUrunCikar(Urun prd)
        {
            if (prd.Quantity > 1)
            {
                prd.Quantity -= 1;
            }
            else 
            { 
                UrunListesi.Remove(prd);
            }
        }
    }
}
