using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Raf
    {
        private List<Kitap>kitaps;
        public Raf()
        {
            kitaps = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            kitaps.Add(kitap);
        }

        public void kitapSilSıraNo(int siraNo)
        {
            //kitaps[siraNo] = null;
            for (int i = siraNo; i< kitaps.Count; i++)
            {
                if (i == kitaps.Count  -1 )
                {
                    kitaps[i] = null;
                }
                else
                {
                    kitaps[i] = kitaps[i + 1];
                }          
            }
        }

        public void kitapSil(Kitap kitap)
        {
           for(int i = 0; i < kitaps.Count; i++)
            {
                if (kitaps[i].getAd == kitap.getAd)
                {
                    for(int j= i; j < kitaps.Count; j++)
                    {
                        if (j != kitaps.Count - 1 )
                        {
                            kitaps[j] = kitaps[j + 1];
                        }
                        else
                        {
                            kitaps[j] = null;
                        }
                    }
                    break;
                }
            }
        }

        public void RafGoster()
        {
            for (int i = 0; i < kitaps.Count; i++)
            {
                if (kitaps[i] != null)
                {
                    Console.WriteLine(kitaps[i].ToString()); 
                }
            }
        }
        public List<Kitap> getKitaplar()
        {
            return kitaps;
        }
    }
}
