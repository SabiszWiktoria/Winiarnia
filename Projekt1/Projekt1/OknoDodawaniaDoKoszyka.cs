using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1
{
    public partial class OknoDodawaniaDoKoszyka : Form
    {
        Artykul artykul = new Artykul();
        Koszyk koszyk = new Koszyk();
        public string SortujWedlug = "";
        public string Sortuj = "";
        int Id;
        public OknoDodawaniaDoKoszyka()
        {
            InitializeComponent();
        }

        private void btnDodajDoKoszyka_Click(object sender, EventArgs e)
        {
            koszyk.DodajDobazyDanych();
           
        }

        private void btnPrzejdzDoKoszyka_Click(object sender, EventArgs e)
        {
            Form okno = new OknoKoszyka();
            okno.Show();
            this.Close();
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {

            artykul.Marka = txtMarka.Text;
            artykul.Smak = (smak)cmbSmak.SelectedIndex;
            artykul.Odmiana = (odmiana)cmOdmiana.SelectedIndex;
            artykul.GdzieWyprodukowano = txtGdzieWyprodukowano.Text;
            artykul.Rocznik = mtxtRocznik.Text;

            string CenaOd = mtxtCenaOd.Text.Replace("zł", "").Replace(",", ".");

            string CenaDo = mtxtCenaDo.Text.Replace("zł", "").Replace(",", ".");

            if (CenaOd == "   .   ")
            {
                CenaOd = "0";
            }

            if (CenaDo == "   .   ")
            {
                CenaDo = "0";
            }
            if (SortujWedlug == "")
            {
                Sortuj = "";
            }
            string zapytanie = artykul.WyszukiwaniePoParametrach(CenaOd, CenaDo, SortujWedlug, Sortuj, artykul);

            artykul.WyswietlanieTabeli(zapytanie, listView1);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nIlosc.Maximum = int.Parse(listView1.SelectedItems[0].SubItems[7].Text);


                lNazwa.Text = listView1.SelectedItems[0].SubItems[1].Text;



                int ilosc = (int)nIlosc.Value;
                float cena = float.Parse(listView1.SelectedItems[0].SubItems[6].Text);
               
                float wynik = cena * ilosc;
                lCena.Text = wynik.ToString();

                int id = Int32.Parse(listView1.SelectedItems[0].Text);
                
                Id = id;
                koszyk.IdProduktu = id;
                koszyk.Ilosc = ilosc;
              




            }
            catch (Exception ex)
            {
                Console.WriteLine("bywa" + ex);
            }
        }

        private void nIlosc_ValueChanged(object sender, EventArgs e)
        {
            int ilosc = (int)nIlosc.Value;
            koszyk.Ilosc = ilosc;
            float cena = float.Parse(listView1.SelectedItems[0].SubItems[6].Text);
            float wynik = cena * ilosc;
            lCena.Text = wynik.ToString();
        }

        private void OknoDodawaniaDoKoszyka_Load(object sender, EventArgs e)
        {
            koszyk.WyswietlanieTabeli2(listView1);
        }

        private void cmbSortuj_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortuj.SelectedIndex == 0)
            {
                Sortuj = "ASC";
            }
            if (cmbSortuj.SelectedIndex == 1)
            {

                Sortuj = "DESC";
            }

        }

        private void btnSortujCena_Click(object sender, EventArgs e)
        {
            SortujWedlug = "Cena";

        }

        private void btnSortujOcena_Click(object sender, EventArgs e)
        {
            SortujWedlug = "Ocena";
        }

        private void btnSortujRocznik_Click(object sender, EventArgs e)
        {
            SortujWedlug = "Rocznik";
        }
    }
}
