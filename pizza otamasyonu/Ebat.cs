using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_otamasyonu
{
    internal class Ebat
    {
        public string Adi { get; set; }
        public double  Carpan { get; set; }
        public override string ToString()
        {
            return string.Format("{0}-{1} TL Fark ",Adi,Carpan) ;
        }
    }
}
