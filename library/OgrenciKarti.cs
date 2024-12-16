using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class OgrenciKarti : Kart
    {
        private double bonus;

        public double getBonus()
        {
            return bonus;
        }

        public OgrenciKarti(int id, String sahip, double bakiye)
        {
            setSahip(sahip);
            setId(id);
            setBakiye(bakiye);
        }

        public override bool odemeYap(double tutar)
        {
            if(bonus >= tutar)
            {
                bonus = bonus - tutar;
                Console.WriteLine("Ödeme bonus ile gerçekleştirildi.");
                return true;
            }

            else if(getBakiye() >= tutar)
            {
                setBakiye(getBakiye() - tutar);
                bonus = bonus + (tutar/4);
                Console.WriteLine("Ödeme gerçekleştirildi.");
                return true;
            }

            else if(getBakiye() < tutar) 
            {
                Console.WriteLine("Bakiye yetersiz.");
                return false;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Id {getId()} Sahip {getSahip()} Bakiye {getBakiye()} Bonus {bonus}";
        }
    }
}
