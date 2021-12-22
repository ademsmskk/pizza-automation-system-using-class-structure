using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_otamasyonu
{
    public partial class cmbebat : Form
    {
        public cmbebat()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nudadet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbebat_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat { Adi = "Küçük", Carpan = 1 };
            Ebat orta = new Ebat { Adi ="Orta", Carpan=1.25 };
            Ebat buyuk = new Ebat { Adi = "Büyük", Carpan = 1.75 };
            Ebat maxi = new Ebat { Adi = "Maxi", Carpan = 2 };
            comboBoxebat.Items.Add(kucuk);
            comboBoxebat.Items.Add(orta); 
            comboBoxebat.Items.Add(buyuk);   
            comboBoxebat.Items.Add (maxi);


            Pizza klasik = new Pizza { Adi = "Klasik", Fiyat = 14 };
            Pizza karisik = new Pizza { Adi = "Karışık", Fiyat = 17 };
            Pizza turkish = new Pizza { Adi = "Turkish", Fiyat = 20 };
            Pizza tuna = new Pizza { Adi = "Tuna", Fiyat = 21 };
            Pizza akdeniz = new Pizza { Adi = "Akdeniz", Fiyat = 19 };
            Pizza karadeniz = new Pizza { Adi = "Karadeniz", Fiyat = 22 };

            listpizzalar.Items.Add(karadeniz);
            listpizzalar.Items.Add(akdeniz);
            listpizzalar.Items.Add(tuna);
            listpizzalar.Items.Add(turkish);
            listpizzalar.Items.Add(karisik);
            listpizzalar.Items.Add(klasik);


            KenarTİp incekenar = new KenarTİp { Adi = "İnce Kenar", EkFiyat = 0 };
            rdbincekenar.Tag = incekenar;
            KenarTİp kalinkenar = new KenarTİp { Adi="Kalın Kenar",EkFiyat =2 };    
            rdbkalinkenar.Tag = kalinkenar;



        }
        Siparis s;
        private void btnHesap_Click(object sender, EventArgs e)
        {
            Pizza p = (Pizza)listpizzalar .SelectedItem;
            p.Ebati = (Ebat)comboBoxebat.SelectedItem  ;
            if (rdbincekenar.Checked )
            {
                p.KenarTİpi = (KenarTİp)rdbincekenar.Tag;
            }
            else
            {
                p.KenarTİpi = (KenarTİp)rdbkalinkenar.Tag;
            }

            p.Malzemeler = new List<string> { };
            foreach (CheckBox  item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    p.Malzemeler.Add(item.Text);
                }
            }

            decimal tutar = nudadet.Value  * p.Tutar;
            txttutat.Text = tutar.ToString();
           s= new Siparis() ;
            s.Pizzalar = p;
            s.Adet =(int) nudadet.Value;
        }

        private void btnsepeteekle_Click(object sender, EventArgs e)
        {
            if (s!=null)
            {
                listsepet.Items.Add(s);

            }
        }

        private void btnonay_Click(object sender, EventArgs e)
        {
            decimal toplamtutar=0;
            int adet = 0;
            foreach (Siparis  item in listsepet.Items)
            {
                toplamtutar += item.Adet *item.Pizzalar.Tutar;
                adet++;
            }

            lbltoplamtutar.Text= toplamtutar.ToString();
            MessageBox.Show(String.Format("Toplam Sipariş Adeti: {0} Adet \n Toplam Tutar: {1} TL", adet, toplamtutar));
        }
    }
}
