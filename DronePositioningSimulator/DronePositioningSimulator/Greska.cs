using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronePositioningSimulator
{
    public class Greska
    {
        public struct tGreska
        {
            public float greskaX;
            public float greskaY;
        }

        public static tGreska[,] polje;

        public Greska()
        {
            kreirajPolje();
        }

        private void kreirajPolje()
        {
            polje = new tGreska[800, 600];
            Random r = new Random();
            for (int i = 0; i < 800; i++)
            {
                for (int j = 0; j < 600; j++)
                {
                    if (i >= 0 && i <= 200 && j >= 0 && j <= 300)
                    {
                        polje[i, j].greskaX = 18;
                        polje[i, j].greskaY = 12;
                    }
                    else if (i > 200 && i <= 400 && j >= 0 && j <= 300)
                    {
                        polje[i, j].greskaX = 19;
                        polje[i, j].greskaY = 25;
                    }
                    else if (i > 400 && i <= 600 && j >= 0 && j <= 150)
                    {
                        polje[i, j].greskaX = 13;
                        polje[i, j].greskaY = 8;
                    }
                    else if (i > 400 && i < 800 && j >= 0 && j <= 300)
                    {
                        polje[i, j].greskaX = 8;
                        polje[i, j].greskaY = 12;
                    }
                    else if (i >= 0 && i <= 400 && j > 300 && j < 600)
                    {
                        polje[i, j].greskaX = 28;
                        polje[i, j].greskaY = 21;
                    }
                    else if (i > 600 && i < 800 && j > 300 && j <= 450)
                    {
                        polje[i, j].greskaX = 32;
                        polje[i, j].greskaY = 23;
                    }
                    else if (i > 400 && i <= 800 && j > 300 && j < 600)
                    {
                        polje[i, j].greskaX = 17;
                        polje[i, j].greskaY = 11;
                    }
                }
            }
        }

    }
}
