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
    public partial class OknoAdministratora : Form
    {
        public OknoAdministratora()
        {
            InitializeComponent();
        }

        private void btnListaArtykulow_Click(object sender, EventArgs e)
        {
            Form okno = new OknoListArytkulow();
            okno.Show();

        }


        private void btnUsuwanie_Click_1(object sender, EventArgs e)
        {
            Form okno = new OknoUsuwania();
            okno.Show();
        }

        private void btnDodawanie_Click_1(object sender, EventArgs e)
        {
            Form okno = new OknoDodawanie();
            okno.Show();
        }

        private void btnModyfikowanie_Click_1(object sender, EventArgs e)
        {
            Form okno = new OknoModyfikacji();
            okno.Show();
        }
    }
}
