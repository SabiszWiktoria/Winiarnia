using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Projekt1
{
    public partial class OknoDodawanie : Form
    {
        public OknoDodawanie()
        {
            InitializeComponent();
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string Marka = txtMarka.Text;
                smak Smak = (smak)cmbSmak.SelectedIndex;
                odmiana Odmiana = (odmiana)cmOdmiana.SelectedIndex;
                string Rocznik = mtxtRocznik.Text;
                string GdzieWyprodukowano = txtGdzieWyprodukowano.Text;
                string w = mtxtCena.Text.Replace(',', '.');

                string c = w.Replace("zł", "");
                string Cena = c;

                int Ilosc = (int)nIlosc.Value;
                int Ocena = (int)nOcena.Value;



                Artykul artykul = new Artykul(Marka, Rocznik, Odmiana, Smak, GdzieWyprodukowano, Cena, Ilosc, Ocena);
                artykul.DodajDobazyDanych();
                txtMarka.Text = "";
                cmbSmak.Text = "";
                cmOdmiana.Text = "";
                mtxtRocznik.Text = "";
                txtGdzieWyprodukowano.Text = "";
                mtxtCena.Text = "";
                nIlosc.Value = 0;
                nOcena.Value = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("bywa" + ex);
            }
            
        }

        private void cmbSmak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
