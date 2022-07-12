﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public Boyut Boyut { get; set; }

        public List<Ekstra> EkstraMalzeme { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        //Küçük boy seçerse normal fiyat, Orta Boy ise fiyatın %10 falzası, büyük ise %25 fazlası olacak
        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;
            switch (Boyut)
            {
                
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
                
            }
            foreach (Ekstra ekstra in EkstraMalzeme)//{ketçap=0.25, mayonez=0.50; BBQ=1.25}
            {
                ToplamTutar += ekstra.Fiyati;
            }
            ToplamTutar = ToplamTutar * Adet;
        }

        public override string ToString()
        {
            //Ekstra malzeme seçilmediyse seçilen siparişin listboxa nasıl uazılacağının formatını belirliyoruz
            if (EkstraMalzeme.Count<1) //Ekstra malzemem yoksa
            {
                return string.Format("{0} Menü x {1} Adet ,{2} Boy, Toplam {3} ", SeciliMenu.MenuAdi,Adet, Boyut,ToplamTutar.ToString("C2"));//C2 formatında yazsın, parasal değer formatı
            }
            //Ekstra malzeme seçildiyse seçilen siparişin listboxa nasıl uazılacağının formatını belirliyoruz
            else
            {
                string ekstraMalzemeler = null;
                foreach (Ekstra ekstra in EkstraMalzeme)
                {
                    ekstraMalzemeler += ekstra.EkstraAdi + ",";
                }
                //ekstraMalzemeler = ketçap, mayonez, BBQ
                ekstraMalzemeler = ekstraMalzemeler.Trim(',');

                return string.Format("{0} Menü x {1} Adet ,{2} Boy, Toplam {3} ", SeciliMenu.MenuAdi, Adet, Boyut, ToplamTutar.ToString("C2"));
            };
        }
    }
}
