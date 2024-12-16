using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public abstract class Kart
    {
        private int id;
        private string sahip;
        private double bakiye;

        public void setId(int id)
        {
            this.id = id;
        }
        public void setSahip(string sahip)
        {
            this.sahip = sahip;
        }
        public void setBakiye(double bakiye)
        {
            this.bakiye = bakiye;
        }

        public int getId()
        {
            return id;
        }
        public String getSahip()
        {
            return sahip;
        }

        public double getBakiye()
        {
            return bakiye;
        }
        public abstract override string ToString();
        public abstract bool odemeYap(double tutar);


    }
}
