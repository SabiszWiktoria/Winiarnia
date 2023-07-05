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
    public partial class OknoKoszyka : Form
    {
        string wynik = "0 zł";
        int Id;
        Koszyk koszyk = new Koszyk();
        
        public OknoKoszyka()
        {
            InitializeComponent();
        }

        private void OknoKoszyka_Load(object sender, EventArgs e)
        {
            koszyk.WyswietlanieTabeli(listView1);
          lWartoscKoszyka.Text= koszyk.Zlicz(listView1).ToString()+" zł";
            wynik = koszyk.Zlicz(listView1).ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                lNazwa.Text = listView1.SelectedItems[0].SubItems[1].Text;


                nIlosc.Value = Int32.Parse(listView1.SelectedItems[0].SubItems[7].Text);
                int ilosc = (int)nIlosc.Value;
                float cena = float.Parse(listView1.SelectedItems[0].SubItems[6].Text);

                float wynik = cena * ilosc;
                lCena.Text = wynik.ToString();
               
                int id = Int32.Parse(listView1.SelectedItems[0].Text);

                Id = id;
                koszyk.IdProduktu = id;
                koszyk.Ilosc = ilosc;
                koszyk.WyswietlanieTabeli1(id, listView2);




            }
            catch (Exception ex)
            {
                Console.WriteLine("bywa" + ex);
            }
           
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Czy napewno chcesz usunąc wino o nazwie {lNazwa.Text} w ilości {nIlosc.Value}", "Czy chcesz usunąć?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                koszyk.Usuwanie(Id);

                listView2.Clear();
                koszyk.WyswietlanieTabeli( listView1);

            }
        }

        private void btnModyfikuj_Click(object sender, EventArgs e)
        {
            int ilosc = (int)nIlosc.Value;
            koszyk.ModyfikacjaTabeli(Id, ilosc);
            koszyk.WyswietlanieTabeli(listView1);
            nIlosc.Value = 0;
            lCena.Text = "0 zł";
            lNazwa.Text = "Nazwa";
            listView2.Clear();
            lWartoscKoszyka.Text = koszyk.Zlicz(listView1).ToString()+" zł";
            wynik= koszyk.Zlicz(listView1).ToString();
        }

        private void nIlosc_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int ilosc = (int)nIlosc.Value;
                koszyk.Ilosc = ilosc;
                float cena = float.Parse(listView1.SelectedItems[0].SubItems[6].Text);
                float wynik = cena * ilosc;
                lCena.Text = wynik.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine("bywa" + ex);
            }

        }

        private void btnZmow_Click(object sender, EventArgs e)
        {
            Form okno = new OknoFormularzuDoZamawiania(wynik);
            okno.Show();
            this.Close();

        }
    }
}
