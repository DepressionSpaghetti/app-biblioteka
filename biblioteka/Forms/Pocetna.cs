using biblioteka.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajKorisnika noviKorisnik = new DodajKorisnika();

            noviKorisnik.ShowDialog(Owner);
        }

        private void dodajKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajKnjigu novaKnjiga = new DodajKnjigu();

            novaKnjiga.ShowDialog(Owner);
        }
    }
}
