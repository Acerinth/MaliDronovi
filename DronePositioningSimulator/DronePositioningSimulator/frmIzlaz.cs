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
                e.Graphics.FillEllipse(boja, d.TrenX, d.TrenY, 10, 10);
            }
            
        }

        private void tmrDrawingTimer_Tick(object sender, EventArgs e)
        {
            foreach (Dron d in Dron.listaDronova)
            {
                d.pomakniDron();
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
