using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Interface1
{
    public class Hayvan
    {
        public byte Yas { get; set; }
        public string? Renk { get; set; }
        public virtual string YemekYe()
        {
            return "Yemek Yerim";
        }
    }

    public class Kopek : Hayvan
    {
        public string? Isim { get; set; }

        public override string YemekYe()
        {
            return "Köpek Maması Yerim";
        }
    }

    public class Yarasa : Hayvan,IUcanbilir
    {
        public byte GorusAcisi { get; set; }
        public byte UcusHizi { get ; set ; }

        public void Uc()
        {
            UcusHizi = 5;
        }

        public override string YemekYe()
        {
            return "Böcek Yerim";
        }
        
    }

    public interface IUcanbilir
    {
        void Uc();

        public byte UcusHizi { get; set; }
    }
}
