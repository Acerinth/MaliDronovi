using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronePositioningSimulator
{
    class Greska
    {
        public struct tGreska
        {
            public float greskaX;
            public float greskaY;
        }

        public tGreska[,] polje = new tGreska[800,600];
        
        public Greska()
        {
            Random r = new Random();
            for (int i = 0; i < 800; i++)
            {
                for (int j = 0; j < 600; j++)
                {
                    if (i >= 0 && i<=200 && j>=0 && j<=300)
                    {
                        this.polje[i, j].greskaX = 15;
                        this.polje[i, j].greskaY = 12;
                    }
                    if (i > 200 && i <= 400 && j >= 0 && j <= 300)
                    {
                        this.polje[i, j].greskaX = 19;
                        this.polje[i, j].greskaY = 21;
                    }
                    if (i > 400 && i <= 600 && j >= 0 && j <= 150)
                    {
                        this.polje[i, j].greskaX = 13;
                        this.polje[i, j].greskaY = 10;
                    }
                    if (i > 600 && i < 800 && j >= 0 && j <= 300)
                    {
                        this.polje[i, j].greskaX = 8;
                        this.polje[i, j].greskaY = 12;
                    }
                    if (i >= 0 && i <= 400 && j > 300 && j < 600)
                    {
                        this.polje[i, j].greskaX = 24;
                        this.polje[i, j].greskaY = 21;
                    }
                    if (i > 400 && i <= 600 && j > 300 && j < 600)
                    {
                        this.polje[i, j].greskaX = 14;
                        this.polje[i, j].greskaY = 11;
                    }
                    if (i > 600 && i < 800 && j > 300 && j <= 450)
                    {
                        this.polje[i, j].greskaX = 32;
                        this.polje[i, j].greskaY = 25;
                    }
                }
            }
        }


    }
}
