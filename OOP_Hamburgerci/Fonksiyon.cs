using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public static class Fonksiyon
    {
        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is RadioButton)
                {
                    RadioButton rdo = (RadioButton)item;
                    if (rdo.Name == "rdKucuk")
                    {
                        rdo.Checked = true;
                    }
                    else
                    {
                        rdo.Checked = false;
                    }
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is TextBox)
                {
                    ((TextBox)item).Text = null;
                   // ((TextBox)item).Text = "";
                   // ((TextBox)item).Text = string.Empty;
                   // ((TextBox)item).Clear();
                }
                else if (item is GroupBox)
                {
                    Temizle(((GroupBox)item).Controls);
                }

            }
        }
    }
}
