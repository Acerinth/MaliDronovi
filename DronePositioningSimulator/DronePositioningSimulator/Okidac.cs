using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DronePositioningSimulator
{
    public class Okidac
    {
        System.Windows.Forms.Timer okidacKretanja; 
        
        public Okidac()
        {
            this.okidacKretanja = new System.Windows.Forms.Timer();
            this.okidacKretanja.Interval = 30;
            this.okidacKretanja.Tick += new System.EventHandler(this.okidacKretanja_Tick);
        }

        private void okidacKretanja_Tick(object sender, EventArgs e)
        {
            
        }
        
        
    }
}
