using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" Tebrikler "+ urun.Adi + " Sepete Eklendi.");
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine(" Tebrikler " + urunAdi + " Sepete Eklendi.");
        }
    }
}
