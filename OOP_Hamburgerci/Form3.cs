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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            Form1.ekstralar.Add(new Ekstra { EkstraAdi = txtExtraMalzemeBil.Text, Fiyati = nmrEMenuFiyati.Value });
            //Ödevdeki Temizle() metodubnu kullnarak buradaki kontroller içinde kullanınız
            MessageBox.Show("Ekstra Başarılı Şekilde Eklendi");
        }
    }
}
