﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Form1.menuler.Add(new Menu { MenuAdi = txtMenu.Text, Fiyati = nmrMenuFiyati.Value });

            //Ödevdeki Temizle() metodubnu kullnarak buradaki kontroller içinde kullanınız
            MessageBox.Show("Menü Başarılı Şekilde Eklendi");
        }
    }
}
