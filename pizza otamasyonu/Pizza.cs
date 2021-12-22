using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_otamasyonu
{
    internal class Pizza
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public Ebat Ebati { get; set; }
        public KenarTİp KenarTİpi { get; set; }
        public List<string> Malzemeler { get; set; }

        public override string ToString()
        {
            return (Adi + "  " + Fiyat + "TL");
        }

        public decimal Tutar
        {

        
            get
            {
                decimal tutar = 0;
                tutar = Fiyat * (decimal)Ebati.Carpan;
                tutar = tutar + KenarTİpi.EkFiyat;
                return tutar;   


            }

           }


    }
}
