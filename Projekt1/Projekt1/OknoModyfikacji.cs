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
    public partial class OknoModyfikacji : Form
    {
        int Id;
        Artykul artykul = new Artykul();
        public OknoModyfikacji()
        {
            InitializeComponent();
        }

        private void OknoModyfikacji_Load(object sender, EventArgs e)
        {
            artykul.WyswietlanieTabeli("", listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                int id = Int32.Parse(listView1.SelectedItems[0].Text);
                LMarka.Text = listView1.SelectedItems[0].SubItems[1].Text;
                lRocznik.Text = listView1.SelectedItems[0].SubItems[2].Text;
                lSmak.Text = listView1.SelectedItems[0].SubItems[3].Text;
                lOdmiana.Text = listView1.SelectedItems[0].SubItems[4].Text;
                lGdziewyprodukowano.Text = listView1.SelectedItems[0].SubItems[5].Text;
                lcena.Text = listView1.SelectedItems[0].SubItems[6].Text;
                lIlosc.Text = listView1.SelectedItems[0].SubItems[7].Text;
                lOcena.Text = listView1.SelectedItems[0].SubItems[8].Text;
                Id = id;
            }
            catch (Exception ex)
            {
                Console.WriteLine("bywa" + ex);
            }
        }

        private void btnModyfikuj_Click(object sender, EventArgs e)
        {

            if (txtMarka.Text != "")
            {

                artykul.ModyfikacjaTabeli(Id, "Marka", txtMarka.Text);
            }
            if (mtxtRocznik.Text != "")
            {
                artykul.ModyfikacjaTabeli(Id, "Rocznik", mtxtRocznik.Text);
            }
            if (cmbSmak.Text != "")
            {
                artykul.ModyfikacjaTabeli(Id, "Smak", cmbSmak.Text);
            }
            if (cmOdmiana.Text != "")
            {
                artykul.ModyfikacjaTabeli(Id, "Odmiana", cmOdmiana.Text);
            }
            if (txtGdzieWyprodukowano.Text != "")
            {
                artykul.ModyfikacjaTabeli(Id, "GdzieWyprodukowano", txtGdzieWyprodukowano.Text);
            }
            MessageBox.Show(mtxtCena.Text);
            if (mtxtCena.Text != "   ,   zł")
            {
                artykul.ModyfikacjaTabeli(Id, "Cena", mtxtCena.Text.Replace(",", "."));
            }
            if (nIlosc.Value != 0)
            {
                artykul.ModyfikacjaTabeli(Id, "Ilosc", nIlosc.Text);
            }
            if (nOcena.Value != 0)
            {
                artykul.ModyfikacjaTabeli(Id, "Ocena", nOcena.Text);
            }
            artykul.WyswietlanieTabeli("", listView1);
            txtMarka.Text = "";
            cmbSmak.Text = "";
            cmOdmiana.Text = "";
            mtxtRocznik.Text = "";
            txtGdzieWyprodukowano.Text = "";
            mtxtCena.Text = "";
            nIlosc.Value = 0;
            nOcena.Value = 0;

            LMarka.Text = "";
            lSmak.Text = "";
            lOdmiana.Text = "";
            lRocznik.Text = "";
            lGdziewyprodukowano.Text = "";
            lcena.Text = "";
            lIlosc.Text = "";
            lOcena.Text = "";


        }
    }
}
