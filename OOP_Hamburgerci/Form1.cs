using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Siparis> tumsiparisler = new List<Siparis>();
        public static List<Siparis> mevcutsiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi="Big King", Fiyati=30.25M},
            new Menu{MenuAdi="Double King Chicken", Fiyati=28.25M},
            new Menu{MenuAdi="SteakHouse", Fiyati=40.50M},
            new Menu{MenuAdi="Whooper", Fiyati=32.00M},
            new Menu{MenuAdi="Whooper Jr.", Fiyati=20.25M},
            new Menu{MenuAdi="Chicken Royal", Fiyati=26.80M},
        };

        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra{EkstraAdi="Acı", Fiyati=100M},
            new Ekstra{EkstraAdi="Ketçap", Fiyati=0.50M},
            new Ekstra{EkstraAdi="Mayonez", Fiyati=0.50M},
            new Ekstra{EkstraAdi="Hardal", Fiyati=0.75M},
            new Ekstra{EkstraAdi="BBQ", Fiyati=1.00M},
            new Ekstra{EkstraAdi="Ranch", Fiyati=1.00M},
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
            {
                cmbMenuler.Items.Add(item);//ToString() metodunu override ettiğimiz için MenüAdı + Menü olarak combobbpx'a yazılmaktadır.
            }
            foreach (Ekstra item in ekstralar)
            {
                flwEkstraMalzeme.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item }); //Tag propertysi object tutar
            }
            foreach (Siparis item in mevcutsiparisler)
            {
                lstSiparisler.Items.Add(item);
            }
            TutarHesapla();
            rdKucuk.Checked = true;
            cmbMenuler.SelectedIndex = 0;
        }
        public decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lstSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");

            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu =(Menu)cmbMenuler.SelectedItem;

            if (rdKucuk.Checked)
            {
                yeniSiparis.Boyut = Boyut.Kucuk;
            }
            else if (rdOrta.Checked)
            {
                yeniSiparis.Boyut = Boyut.Orta;
            }
            else
            {
                yeniSiparis.Boyut = Boyut.Buyuk;
            }

            yeniSiparis.EkstraMalzeme = new List<Ekstra>();
            foreach (CheckBox item in flwEkstraMalzeme.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.EkstraMalzeme.Add((Ekstra)item.Tag); //FlowLayoutPanel'deki kontrollerden seçilenlerin her birinin Tag Propertysinde tutalan ekstra malzemenin kopyasını verir
                }
            }
            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla(); //Sipariş classındaki Hesapla metotu oluşan yeni siparişinn toplam fiyatını hesaplar

            tumsiparisler.Add(yeniSiparis);
            mevcutsiparisler.Add(yeniSiparis);
            lstSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();

            //Ödev: Fonksiyonlar isimli bir class oluşturun ve Temizle() adında bir metot oluşturup bu metodu burada kontrolleri temizlemek için kullanın
        }

        private void btnSiparisTmm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutar: " + TutarHesapla().ToString("C2") + "\nSiparişi Tamamlamak İster Misiniz?", "Siarpiş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr==DialogResult.Yes)
            {
                
                lstSiparisler.Items.Clear();
                mevcutsiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz Tamamlandı :)");
            }
            else
            {
                MessageBox.Show("İptal Edildi");
            }
        }
    }
}
