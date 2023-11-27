using System;
using biblioteka;
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
    public partial class Knjige : Form
    {

        //controls setup
        #region
        Label lblNas;
        Label lblAut;
        Label lblIzd;
        Label lblNaslov;
        Label lblAutor;
        Label lblIzdavac;
        GroupBox grpDetNew;
        int space, i, yOfLastControl;
        public int YofLastControl { get => yOfLastControl; set => yOfLastControl = value; }
        #endregion


        public Knjige()
        {
            InitializeComponent();
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            if (Pocetna.KnjigaList.Count == 1) yOfLastControl = 23;
            i = 0;
            space = 0;
            YofLastControl = 47;

            foreach(Knjiga k in Pocetna.KnjigaList)
            {
                space = 0;
                if (i == 0) space = 0;
                else space = 129;

                lblNas = new Label();
                lblAut = new Label();
                lblIzd = new Label();
                lblNaslov = new Label();
                lblAutor = new Label();
                lblIzdavac = new Label();
                grpDetNew = new GroupBox();
                grpDetNew.SuspendLayout();

                //groupBox
                this.groupBox1.Controls.Add(this.lblIzdavac);
                this.groupBox1.Controls.Add(this.lblAutor);
                this.groupBox1.Controls.Add(this.lblNas);
                this.groupBox1.Controls.Add(this.lblAut);
                this.groupBox1.Controls.Add(this.lblNaslov);
                this.groupBox1.Controls.Add(this.lblIzd);
                this.groupBox1.Location = new System.Drawing.Point(12, YofLastControl + space);
                this.groupBox1.Name = "groupBox1";
                this.groupBox1.Size = new System.Drawing.Size(391, 123);
                this.groupBox1.TabIndex = 0;
                this.groupBox1.TabStop = false;
                //label naslov
                this.lblNas.AutoSize = true;
                this.lblNas.Location = new System.Drawing.Point(17, 28);
                this.lblNas.Name = "lblnas" + i;
                this.lblNas.Size = new System.Drawing.Size(43, 13);
                this.lblNas.TabIndex = 0;
                this.lblNas.Text = "Naslov:";
                //naslov
                this.lblNaslov.AutoSize = true;
                this.lblNaslov.Location = new System.Drawing.Point(84, 28);
                this.lblNaslov.Name = "lblNaslov";
                this.lblNaslov.Size = new System.Drawing.Size(35, 13);
                this.lblNaslov.TabIndex = 1;
                this.lblNaslov.Text = ;
            }
        }

    }
}
