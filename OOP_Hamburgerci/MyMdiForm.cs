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
    public partial class MyMdiForm : Form
    {
        public MyMdiForm()
        {
            InitializeComponent();
        }
        void ChildForm(Form childform)
        {
            this.Width = childform.Width + 27;
            this.Height = childform.Height + 50;
            //Ödev: Formların üst üste açılmaması ve açılan formun textinin başlığa yazılması
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childform.Text)
                {
                    durum = true;
                    form.Dock = DockStyle.Fill;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childform.MdiParent = this;
                childform.Dock = DockStyle.Fill;
                childform.Show();
            }




        }
        //void Childform2(Form childform2)
        //{

        //}
        private void tsmSiparisOlusturma_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void tsmMalzemEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Console.WriteLine("Menü Adını Gir");
        }
    }
}
