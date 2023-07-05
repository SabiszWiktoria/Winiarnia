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
    public partial class Witamy : Form
    {
        public Witamy()
        {
            InitializeComponent();
        }

       

        private void btnAdministrator_Click(object sender, EventArgs e)
        {
            Form okno = new OknoAdministratora();
            okno.Show();
        }

        private void btnKlient_Click(object sender, EventArgs e)
        {
            Form okno = new OknoDodawaniaDoKoszyka();
            okno.Show();
        }
    }
}
