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
    public partial class OknoFormularzuDoZamawiania : Form
    {
        Koszyk koszyk = new Koszyk();
        string Wynik;
        public OknoFormularzuDoZamawiania(string wynik)
        {
            InitializeComponent();
            lWartosc.Text = wynik + " zł ";
            Wynik = wynik;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZamow_Click(object sender, EventArgs e)
        {
            if (txtMiasto.Text == "" || txtNrDomu.Text == "" || TxtUlica.Text == "" || mtxtKodpocztowy.Text == "  -")
            {
                MessageBox.Show("Pola nie są wypełnione");
            }
            else
            {
                MessageBox.Show($"Dziękujemy za złożenie zamówienia o wartości {Wynik}", "Dziękujemy! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtMiasto.Text = "";
                txtNrDomu.Text = "";
                TxtUlica.Text = "";
                mtxtKodpocztowy.Text = "";
                lWartosc.Text = "0 zł";
                koszyk.UsuwanieDanych();
                this.Close();

            }
        }
    }
}
