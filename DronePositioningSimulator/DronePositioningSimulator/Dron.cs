using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronePositioningSimulator
{
    class Dron
    {
        public int IDDron { set; get; }
        public string NazivDron { set; get; }
        public float X { set; get; }
        public float Y { set; get; }
        public float GreskaX { set; get; }
        public float GreskaY { set; get; }
        public float JacinaSignala { set; get; }
        // dodati još za kretanje smjer i brzinu

        public static List<Dron> listaDronova = new List<Dron>();

        public Dron (int id, float x, float y, float sig, string naz="", float gx=0, float gy=0)
        {
            this.IDDron = id;
            this.NazivDron = naz;
            this.X = x;
            this.Y = y;
            this.GreskaX = gx;
            this.GreskaY = gy;
            this.JacinaSignala = sig;
        }

    }
}
