using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTopologySuite.Utilities;
using NetTopologySuite.Geometries.Utilities;
using GeoAPI.Geometries;

namespace DronePositioningSimulator
{
    class Dron
    {
        public static List<Dron> listaDronova = new List<Dron>();

        public int MinSignal = -90;
        public int IDDron { set; get; }
        public string NazivDron { set; get; }
        public float X { set; get; }
        public float Y { set; get; }
        public float GreskaX { set; get; }
        public float GreskaY { set; get; }
        public System.Drawing.Color Boja { set; get; }
        public float Smjer { set; get; }
        public float Brzina { set; get; }
        public float TrenX { set; get; }
        public float TrenY { set; get; }
        public float TrenSmjer { set; get; }
        public bool PrikazVijenaca { set; get; } = true;
        public Region regijaPogreske = new Region();
        private IGeometry pocRegijaPogreskeRacun;
        private IGeometry trenRegijaPogreskeRacun;

        public List<Region> listaVijenaca = new List<Region>();
        public List<System.Drawing.Drawing2D.GraphicsPath> listaElipsi = new List<System.Drawing.Drawing2D.GraphicsPath>();
        public List<Dron> vidljiviDronovi = new List<Dron>();

        KorekcijaPogreske kp = new KorekcijaPogreske();

        public Dron()
        {
        }

        public void postaviVrijednosti(int id, float x, float y, System.Drawing.Color b, string naz = "", float gx = 0, float gy = 0, float s = 0, float v = 0)
        {
            this.IDDron = id;
            this.NazivDron = naz;
            this.X = x;
            this.Y = y;
            this.GreskaX = gx;
            this.GreskaY = gy;
            this.Boja = b;
            this.Smjer = s;
            this.TrenSmjer = s;
            this.Brzina = v;
            this.TrenX = x;
            this.TrenY = y;
            regijaPogreske.MakeEmpty();
        }

        public void pomakniDron()
        {
            if (this.TrenSmjer < 90 && this.TrenSmjer > 0)
            {
                this.TrenX += izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
                this.TrenY -= izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer == 90)
            {
                this.TrenX += izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer > 90 && this.TrenSmjer < 180)
            {
                this.TrenX += izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
                this.TrenY += izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer == 180)
            {
                this.TrenY += izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer > 180 && this.TrenSmjer < 270)
            {
                this.TrenX -= izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
                this.TrenY += izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer == 270)
            {
                this.TrenX -= izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer > 270 && this.TrenSmjer < 360)
            {
                this.TrenX -= izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
                this.TrenY -= izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer == 360 || this.TrenSmjer == 0)
            {
                this.TrenY -= izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }

        }

        private float izracunajPomakX(float x, float s, float v)
        {
            float pomakX;
            float kut = korigirajKut(s);
            double kutRadijani = Math.PI * kut / 180.0;
            pomakX = (float)Math.Sin(kutRadijani) * v;
            return pomakX;
        }

        private float izracunajPomakY(float y, float s, float v)
        {
            float pomakY;
            float kut = korigirajKut(s);
            double kutRadijani = Math.PI * kut / 180.0;
            pomakY = (float)Math.Cos(kutRadijani) * v;
            return pomakY;
        }

        private float korigirajKut(float s)
        {
            float noviKut = s;
            if (s > 90 && s < 180)
            {
                noviKut = 180 - s;
            }
            if (s == 180)
            {
                noviKut = 0;
            }
            if (s > 180 && s < 270)
            {
                noviKut = s - 180;
            }
            if (s == 270)
            {
                noviKut = 90;
            }
            if (s > 270 && s < 360)
            {
                noviKut = 360 - s;
            }
            if (s == 360)
            {
                noviKut = 0;
            }
            return noviKut;
        }

        public void resetrirajTrenutno()
        {
            this.TrenSmjer = this.Smjer;
            this.TrenX = this.X;
            this.TrenY = this.Y;
            this.listaElipsi.Clear();
            this.listaVijenaca.Clear();
            this.regijaPogreske.MakeEmpty();
        }

        public void provjeriRub(int w, int h)
        {
            if (this.TrenX >= w || this.TrenX <= 1)
            {
                this.TrenSmjer = 360 - this.TrenSmjer;
            }
            if (this.TrenY >= h || this.TrenY <= 1)
            {
                if (this.TrenSmjer > 0 && this.TrenSmjer < 90)
                {
                    this.TrenSmjer = 180 - this.TrenSmjer;
                }
                else if (this.TrenSmjer > 90 && this.TrenSmjer < 180)
                {
                    this.TrenSmjer = 180 - this.TrenSmjer;
                }
                else if (this.TrenSmjer > 180 && this.TrenSmjer < 270)
                {
                    this.TrenSmjer = 360 - (this.TrenSmjer - 180);
                }
                else if (this.TrenSmjer > 270 && this.TrenSmjer < 360)
                {
                    this.TrenSmjer = (360 - this.TrenSmjer) + 180;
                }
                else if (this.TrenSmjer == 0 || this.TrenSmjer == 180)
                {
                    this.TrenSmjer += 180;
                }
                else if (this.TrenSmjer == 360)
                {
                    this.TrenSmjer = 0;
                }

            }
        }

        public void pronadjiDronove()
        {
            vidljiviDronovi.Clear();
            foreach (Dron d in listaDronova)
            {
                float r;
                float R;
                if (d.IDDron != this.IDDron)
                {
                    r = kp.izracunajUdaljenost(this.TrenX, this.TrenY, d.TrenX, d.TrenY);
                    R = kp.izracunajPrimljeniSignal(r);
                    if (R > this.MinSignal)
                    {
                        vidljiviDronovi.Add(d);
                    }
                }

            }
        }

        private void napraviRegijuPogreskeZaCrtanje()
        {
            regijaPogreske.MakeEmpty();
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(this.TrenX - this.GreskaX, this.TrenY - this.GreskaY, this.GreskaX * 2, this.GreskaY * 2);
            regijaPogreske.Union(gp);
        }

        private void napraviRegijuPogreskeZaRacun()
        {
            GeometricShapeFactory gsf = new GeometricShapeFactory();
            gsf.Centre = new Coordinate(this.TrenX, this.TrenY);
            gsf.Height = this.GreskaY * 2;
            gsf.Width = this.GreskaX * 2;
            var pocetnaRegijaRacun = gsf.CeateEllipse();

            GeometryTransformer t = new GeometryTransformer();
            this.pocRegijaPogreskeRacun = t.Transform(pocetnaRegijaRacun);
            this.trenRegijaPogreskeRacun = this.pocRegijaPogreskeRacun;
        }

        public void korigirajPogresku()
        {
            string zapis = String.Empty;

            napraviRegijuPogreskeZaCrtanje();

            listaElipsi.Clear();
            listaVijenaca.Clear();

            napraviRegijuPogreskeZaRacun();

            foreach (Dron d in vidljiviDronovi)
            {
                //simulacija podataka
                float rSim = kp.izracunajUdaljenost(this.TrenX, this.TrenY, d.TrenX, d.TrenY);
                float R = kp.izracunajPrimljeniSignal(rSim);

                //izracun udaljenosti izmedju dronova
                float r = kp.izracunajUdaljenostPomocuSignala(R);

                //izracun tocaka (gornja lijeva) i polumjera za elipse
                float maliRY = (r - d.GreskaY);
                float maliRX = (r - d.GreskaX);
                float malaTockaX = d.TrenX - (r - d.GreskaX);
                float malaTockaY = d.TrenY - (r - d.GreskaY);

                float velikiRY = (r + d.GreskaY);
                float velikiRX = (r + d.GreskaX);
                float velikaTockaX = d.TrenX - (r + d.GreskaX);
                float velikaTockaY = d.TrenY - (r + d.GreskaY);

                //mala elipsa
                Region vijenac = new Region();
                GraphicsPath gpeMala = new GraphicsPath();
                gpeMala.AddEllipse(malaTockaX, malaTockaY, maliRX * 2, maliRY * 2);
                listaElipsi.Add(gpeMala);

                GeometricShapeFactory gsf = new GeometricShapeFactory();
                gsf.Centre = new Coordinate(d.TrenX, d.TrenY);
                gsf.Height = maliRY * 2;
                gsf.Width = maliRX * 2;
                var malaRacun = gsf.CeateEllipse();

                //velika elipsa
                GraphicsPath gpeVelika = new GraphicsPath();
                gpeVelika.AddEllipse(velikaTockaX, velikaTockaY, velikiRX * 2, velikiRY * 2);
                listaElipsi.Add(gpeVelika);

                gsf.Height = velikiRY * 2;
                gsf.Width = velikiRX * 2;
                var velikaRacun = gsf.CeateEllipse();

                //vijenac
                vijenac.Intersect(gpeVelika);
                vijenac.Exclude(gpeMala);

                var vijenacRacun = velikaRacun.Difference(malaRacun);

                listaVijenaca.Add(vijenac);

                //intersect
                regijaPogreske.Intersect(vijenac);
                this.trenRegijaPogreskeRacun = trenRegijaPogreskeRacun.Intersection(vijenacRacun);

            }

            //podaci za zapis
            float postotak = (float)trenRegijaPogreskeRacun.Area / (float)pocRegijaPogreskeRacun.Area;
            postotak = (float)Math.Round(((1 - postotak) * 100), 4);
            float povrsinaPoc = (float)Math.Round(pocRegijaPogreskeRacun.Area, 4);
            float povrsinaZav = (float)Math.Round(trenRegijaPogreskeRacun.Area, 4);
            float XzaIspis = (float)Math.Round(this.TrenX, 4);
            float YzaIspis = (float)Math.Round(this.TrenY, 4);

            zapis = this.IDDron.ToString() + ";" + this.NazivDron.ToString() + ";" + XzaIspis.ToString() + ";" + YzaIspis.ToString() + ";" + povrsinaPoc.ToString() + ";" + povrsinaZav.ToString() + ";" + postotak;
            frmGlavna.listaRezultata.Add(zapis);

        }







        /*
        public int minSignal = -90;
        public int IDDron { set; get; }
        public string NazivDron { set; get; }
        public float X { set; get; }
        public float Y { set; get; }
        public float GreskaX { set; get; }
        public float GreskaY { set; get; }
        public Color Boja { set; get; }
        public float Smjer { set; get; }
        public float Brzina { set; get; }
        public float TrenX { set; get; }
        public float TrenY { set; get; }
        public float KorX { set; get; }
        public float KorY { set; get; }
        public float TrenSmjer { set; get; }
        KorekcijaPogreske kp = new KorekcijaPogreske();

        public static List<Dron> listaDronova = new List<Dron>();
        public List<Dron> vidljiviDronovi = new List<Dron>();

        public Dron (int id, float x, float y, Color b, string naz="", float gx =0, float gy =0, float s=0, float v=0)
        {
            this.IDDron = id;
            this.NazivDron = naz;
            this.X = x;
            this.Y = y;
            this.GreskaX = gx;
            this.GreskaY = gy;
            this.Boja = b;
            this.Smjer = s;
            this.TrenSmjer = s;
            this.Brzina = v;
            this.TrenX = x;
            this.TrenY = y;
            this.KorX = x;
            this.KorY = y;
        }

        public void pomakniDron ()
        {
            if (this.TrenSmjer < 90 && this.TrenSmjer > 0)
            {
                this.TrenX += izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
                this.TrenY -= izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer == 90)
            {
                this.TrenX += izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer > 90 && this.TrenSmjer < 180)
            {
                this.TrenX += izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
                this.TrenY += izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer == 180)
            {
                this.TrenY += izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer > 180 && this.TrenSmjer < 270)
            {
                this.TrenX -= izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
                this.TrenY += izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer == 270)
            {
                this.TrenX -= izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer > 270 && this.TrenSmjer < 360)
            {
                this.TrenX -= izracunajPomakX(this.TrenX, this.TrenSmjer, this.Brzina);
                this.TrenY -= izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            else if (this.TrenSmjer == 360 || this.TrenSmjer == 0)
            {
                this.TrenY -= izracunajPomakY(this.TrenY, this.TrenSmjer, this.Brzina);
            }
            this.KorX = this.TrenX;
            this.KorY = this.TrenY;
        }

        private float izracunajPomakX(float x, float s, float v)
        {
            float pomakX;
            float kut = korigirajKut(s);
            double kutRadijani = Math.PI * kut / 180.0;
            pomakX = (float)Math.Sin(kutRadijani) * v;
            return pomakX;
        }

        private float izracunajPomakY(float y, float s, float v)
        {
            float pomakY;
            float kut = korigirajKut(s);
            double kutRadijani = Math.PI * kut / 180.0;
            pomakY = (float)Math.Cos(kutRadijani) * v;
            return pomakY;
        }

        private float korigirajKut(float s)
        {
            float noviKut = s;
            if (s > 90 && s < 180)
            {
                noviKut = 180 - s;
            }
            if (s == 180)
            {
                noviKut = 0;
            }
            if (s > 180 && s < 270)
            {
                noviKut = s - 180;
            }
            if (s == 270)
            {
                noviKut = 90;
            }
            if (s > 270 && s < 360)
            {
                noviKut = 360 - s;
            }
            if (s == 360)
            {
                noviKut = 0;
            }
            return noviKut;
        }

        public void resetrirajTrenutno()
        {
            this.TrenSmjer = this.Smjer;
            this.TrenX = this.X;
            this.TrenY = this.Y;
            this.KorX = this.X;
            this.KorY = this.Y;
        }

        public void provjeriRub(int w, int h)
        {
            if (this.TrenX >= w || this.TrenX <= 1)
            {
                this.TrenSmjer = 360 - this.TrenSmjer;
            }
            if (this.TrenY >= h || this.TrenY <= 1)
            {
                if (this.TrenSmjer > 0 && this.TrenSmjer < 90)
                {
                    this.TrenSmjer = 180 - this.TrenSmjer;
                }
                else if (this.TrenSmjer > 90 && this.TrenSmjer < 180)
                {
                    this.TrenSmjer = 180 - this.TrenSmjer;
                }
                else if (this.TrenSmjer > 180 && this.TrenSmjer < 270)
                {
                    this.TrenSmjer = 360 - (this.TrenSmjer - 180);
                }
                else if (this.TrenSmjer > 270 && this.TrenSmjer < 360)
                {
                    this.TrenSmjer = (360 - this.TrenSmjer) + 180;
                }
                else if (this.TrenSmjer == 0 || this.TrenSmjer == 180)
                {
                    this.TrenSmjer += 180;
                }
                else if (this.TrenSmjer == 360)
                {
                    this.TrenSmjer = 0;
                }

            }
        }

        public float generirajX(float x, float ex)
        {
            float noviX;
            Random r = new Random();
            int pomak = r.Next(0, (int)Math.Floor((decimal)ex));
            int znak = r.Next(0, 1);
            if (znak==1)
            {
                noviX = x + pomak; 
            }            
            else
            {
                noviX = x - pomak;
            }
            return noviX;
        }

        public float generirajY(float y, float ey)
        {
            float noviY;
            Random r = new Random();
            int pomak = r.Next(0, (int)Math.Floor((decimal)ey));
            int znak = r.Next(0, 1);
            if (znak == 1)
            {
                noviY = y + pomak;
            }
            else
            {
                noviY = y - pomak;
            }
            return noviY;
        }

        public void pronadjiDronove()
        {
            vidljiviDronovi.Clear();
            foreach (Dron d in listaDronova)
            {
                float r;
                float R;
                if (d.IDDron != this.IDDron)
                {
                    r = kp.izracunajUdaljenost(this.TrenX, this.TrenY, d.KorX, d.KorY);
                    R = kp.izracunajPrimljeniSignal(r);
                    if (R > this.minSignal)
                    {
                        vidljiviDronovi.Add(d);
                    }
                }

            }
        }

        public void korigirajMojuLokaciju()
        {           

        }*/


    }
}
