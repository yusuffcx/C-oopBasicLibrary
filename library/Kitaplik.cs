using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Kitaplik
    {
        private Raf[] rafs;
        public Kitaplik(int rafSayisi)
        {
            rafs = new Raf[rafSayisi];
            for(int i=0;i<rafSayisi;i++)
            {
                rafs[i] = new Raf();
            }
        }


        public void kitapEkle(Kitap kitap,int rafNo)
        {
            rafs[rafNo].KitapEkle(kitap);
        }

        public void kitapSilSıraNo(int kitapNo,int rafNo)
        {
            rafs[rafNo].kitapSilSıraNo(kitapNo); 
        }

        public void kitapSil(int rafNo,Kitap kitap)
        {
            rafs[rafNo].kitapSil(kitap);
        }

        public int kitapAra(String kitapAd)
        {
            int isFound = 0; // bulundu ise 1 olacak bu sayede kitaplıkta bulunamadı çıktısı vermeyecek.
            for(int i = 0;i < rafs.Length; i++)
            {
                var listKitaps = rafs[i].getKitaplar();
                for (int j = 0; j < listKitaps.Count; j++)
                {
                    if (listKitaps[j] != null)
                    {
                        if (listKitaps[j].getAd() == kitapAd)
                        {
                            Console.WriteLine($"Kitap {i}. Rafta");
                            isFound++;
                            break;
                        }
                    }
                }
            }
            if (isFound == 0)
            {
                Console.WriteLine("Aranılan kitap kitaplıkta bulunamadı.");
            }
            return isFound;
        }

        public void gosterRaf(int rafNo)
        {
            Console.WriteLine($"{rafNo}. Raf");
            rafs[rafNo].RafGoster();
        }

        public void tumRaflariGoster()
        {
            for(int i = 0;i< rafs.Length;i++)
            {
                gosterRaf(i);
            }
        }




    }
}
