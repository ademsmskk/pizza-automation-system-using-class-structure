using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_otamasyonu
{
    internal class Siparis
    {
        public Pizza Pizzalar  { get; set; }
        public int Adet { get; set; }
        public decimal Toplamtutar { get; set; }





        public override string ToString()
        {
            string spr = "";
            spr += Pizzalar.Ebati.Adi;
            spr += Pizzalar.Adi;
            spr += Pizzalar.KenarTİpi.Adi;
            foreach (string  mlz in Pizzalar.Malzemeler)
            {
                spr += string.Format("{0},", mlz);
            }
            spr+= string .Format ("{0},{1} ={2}",Adet ,Pizzalar.Tutar,Adet *Pizzalar.Tutar );
            return spr;


        }
    }
}
