using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronePositioningSimulator
{
    public class KorekcijaPogreske
    {
        float T = 17;
        float K = -147.55f;
        float f = 2450000000;
        float n = 2;

        public float izracunajUdaljenost(float x1, float y1, float x2, float y2)
        {
            float r;
            float pom1 = (float)Math.Pow((x2 - x1), 2);
            float pom2 = (float)Math.Pow((y2 - y1), 2);
            r = (float)Math.Sqrt((pom1 + pom2));
            return r;
        }

        public float izracunajPrimljeniSignal(float r)
        {
            float R;
            float pom = ((float)Math.Log10((double)r)*10*n)/(float)Math.Log(10);
            R = T - pom - K - 20 * (float)Math.Log10(f);
            return R;
        }

        public float izracunajUdaljenostPomocuSignala(float R)
        {
            float r;
            float pom = T - R - K - 20 * (float)Math.Log10((double)f);
            float pot = (float)(Math.Log(10) * pom) / (10 * n);
            r = (float)Math.Pow(10, pot); 
            return r;
        }

       
    }
}
