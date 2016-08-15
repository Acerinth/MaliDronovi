using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DronePositioningSimulator
{
    public partial class frmIzlaz : Form
    {
        Greska g = new Greska();

        public frmIzlaz()
        {
            InitializeComponent();
        }

        private void frmIzlaz_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(frmIzlaz_Paint);
        }

        private void frmIzlaz_Paint(object sender, PaintEventArgs e)
        {
            foreach (Dron d in Dron.listaDronova)
            {
                SolidBrush boja = new SolidBrush(d.Boja);
                Pen olovka = new Pen(d.Boja);
                //for (int i = 0; i < 800; i++)
                //{
                //    for (int j = 0; j < 600; j++)
                //    {
                //        if (g.polje[i,j].greskaX != 0)
                //        {
                //            e.Graphics.DrawEllipse(Pens.Black, i, j, 1, 1);
                //        }
                //    }
                //}                
                //e.Graphics.FillEllipse(boja, d.TrenX-5, d.TrenY-5, 10, 10);
                e.Graphics.FillEllipse(Brushes.Black, d.KorX - 5, d.KorY - 5, 10, 10);
                d.GreskaX = g.polje[Math.Abs((int)d.TrenX), Math.Abs((int)d.TrenY)].greskaX;
                d.GreskaY = g.polje[Math.Abs((int)d.TrenX), Math.Abs((int)d.TrenY)].greskaY;
                e.Graphics.DrawEllipse(olovka, d.TrenX- d.GreskaX, d.TrenY- d.GreskaY, d.GreskaX*2, d.GreskaY*2);

            }
            
        }

        private void tmrDrawingTimer_Tick(object sender, EventArgs e)
        {
            foreach (Dron d in Dron.listaDronova)
            {
                d.pocisti();
                d.provjeriRub(this.ClientSize.Width-5, this.ClientSize.Height-5);
                d.pomakniDron();
                d.pronadjiDronove();
                d.korigirajMojuLokaciju();
            }
            this.Refresh();
        }

        private void frmIzlaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Dron d in Dron.listaDronova)
            {
                d.resetrirajTrenutno();
            }
        }
        
       
    }
}
