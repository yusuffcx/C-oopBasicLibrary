using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class KitaplikYonetim 
    {
        private Kitaplik kitaplik;
        public KitaplikYonetim(Kitaplik kitaplik)
        {
            this.kitaplik = kitaplik;
        }

        public bool KitapSat(Kitap kitap,Kart kart)
        {
            if(kitaplik.kitapAra(kitap.getAd()) == 1)
            {
                //Console.WriteLine("Kitap bulundu. Ödeme yap fonk cagrılıyor.");
                kart.odemeYap(kitap.getFiyat());
                return true;
            }
            else
            {
                Console.WriteLine("Kitap bulunmadı.");
                return false; // çünkü kitap kitaplıkta yok.
            }


        }

    }
}
