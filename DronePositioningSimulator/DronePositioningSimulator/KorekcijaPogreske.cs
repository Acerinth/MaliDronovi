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

        public struct tocka
        {
            public float x;
            public float y;
        }

        //public struct vidljiviDron
        //{
        //    public int id;
        //    public float R;
        //    public float x;
        //    public float y;
        //}

        public List<tocka> listaTocaka = new List<tocka>();
        //public List<vidljiviDron> vidljiviDronovi = new List<vidljiviDron>();


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



        // OVO NADOLJE MI VIŠE NE TREBA

        /*public float izracunajKorigiraniX(float r, float x1, float y1, float xp, float yp) {
            float x2;
            float brojnik = (float)Math.Pow((xp - x1),2);
            float nazivnik = (float)Math.Pow((yp - y1), 2) + (float)Math.Pow((xp - x1), 2);
            float razlomak = brojnik / nazivnik;
            float korijen = (float)Math.Sqrt((razlomak * Math.Pow(r, 2)));
            x2 = korijen - x1;
            return x2;
        }

        public float izracunajKorigiraniY(float x1, float x2, float y1, float xp, float yp)
        {
            float y2;
            float brojnik = (x2 - x1) * (yp - y1);
            float nazivnik = xp - x1;
            y2 = brojnik / nazivnik + y1;
            return y2;
        }

        public float izracunajProsjekX(List<tocka> l)
        {
            float suma = 0;
            float prosjecniX;
            foreach (tocka t in l)
            {
                suma += t.x;
            }
            prosjecniX = suma / l.Count;
            return prosjecniX;
        }

        public float izracunajProsjekY(List<tocka> l)
        {
            float suma = 0;
            float prosjecniY;
            foreach (tocka t in l)
            {
                suma += t.y;
            }
            prosjecniY = suma / l.Count;
            return prosjecniY;
        } */
    }
}
