using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Kitap
    {
        private String ad;
        private String yazar;
        private String isbn;
        private double fiyat;

        public Kitap(String ad,String yazar,String isbn,double fiyat)
        {
            this.ad = ad;
            this.yazar = yazar;
            this.isbn = isbn;
            this.fiyat = fiyat;
        }

        public String getAd() { return ad; }
        public String getYazar() { return yazar; }
        public String getIsbn() { return isbn; }
        public double getFiyat() { return fiyat; }

        public void setAd(String ad) { this.ad = ad; }
        public void setYazar(String yazar) {  this.yazar = yazar;}
        public void setIsbn(String isbn) { this.isbn = isbn;}
        public void setFiyat(double fiyat) {  this.fiyat = fiyat;}

        public override string ToString()
        {
            return $"Ad {ad} Yazar {yazar} ISBN {isbn} Fiyat {fiyat}";
        }


    }
}
