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
    public partial class OknoUsuwania : Form
    {
        Artykul artykul = new Artykul();
        int Id;
        public OknoUsuwania()
        {
            InitializeComponent();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Czy napewno chcesz usunąc wino o nazwie {artykul.Marka} i roczniku {artykul.Rocznik}", "Czy chcesz usunąć?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                artykul.Usuwanie(Id);
               
                listView2.Clear();
                artykul.WyswietlanieTabeli("", listView1);

            }
        }

        private void OknoUsuwania_Load(object sender, EventArgs e)
        {
            artykul.WyswietlanieTabeli("", listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int id = Int32.Parse(listView1.SelectedItems[0].Text);
                artykul.WyswietlanieTabeli(artykul.ZapytaniaUsuwania(id), listView2);
                Id = id;

                artykul.Marka = listView1.SelectedItems[0].SubItems[1].Text;
                artykul.Rocznik= listView1.SelectedItems[0].SubItems[2].Text;

            }
            catch (Exception ex)
            {
                Console.WriteLine("bywa" + ex);
            }

        }
    }
}
