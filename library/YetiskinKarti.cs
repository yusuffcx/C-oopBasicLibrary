using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class YetiskinKarti : Kart
    {

        public YetiskinKarti(int id,String sahip,double bakiye)
        {
            setBakiye(bakiye);
            setSahip(sahip);
            setId(id);
        }

        public override bool odemeYap(double tutar)
        {
            //Console.WriteLine("odemeYap fonksiyonu.");
            if(getBakiye() >= tutar)
            {

                Console.WriteLine("Ödeme gerçekleştirildi.");
                setBakiye(getBakiye() - tutar);
                return true;
            }
            else
            {
                Console.WriteLine("Bakiye Yetersiz");
                return false;
            }

        }

        public override string ToString()
        {
            return $"Id {getId()} Sahip {getSahip()} Bakiye {getBakiye()}";
        }
    }
}


