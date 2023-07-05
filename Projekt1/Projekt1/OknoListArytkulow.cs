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
    public partial class OknoListArytkulow : Form
    {
        Artykul artykul = new Artykul();
        public string SortujWedlug = "";
        public string Sortuj = "";
        public OknoListArytkulow()
        {
            InitializeComponent();
        }

        private void OknoListArytkulow_Load(object sender, EventArgs e)
        {
            artykul.WyswietlanieTabeli("", listView1);
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
                Sortuj = "ASC";
                SortujWedlug = "Cena";
            }
            string zapytanie = artykul.WyszukiwaniePoParametrach(CenaOd, CenaDo, SortujWedlug, Sortuj, artykul);

            artykul.WyswietlanieTabeli(zapytanie, listView1);


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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
