using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka.Forms
{
    public partial class DodajKorisnika : Form
    {
        public DodajKorisnika()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPrihvati_Click(object sender, EventArgs e)
        {
            bool exceptionFound = false;

            if (exceptionFound == false) DialogResult = DialogResult.OK;
        }
    }
}
