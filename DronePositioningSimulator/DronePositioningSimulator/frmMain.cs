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
    public partial class frmMain : Form
    {
        

        public frmMain()
        {
            InitializeComponent();
        }

        
        private void dronoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDronovi dronovi = new frmDronovi();
            dronovi.Show();
        }
    }
}
