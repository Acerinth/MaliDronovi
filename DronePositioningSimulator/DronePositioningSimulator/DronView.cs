using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DronePositioningSimulator
{
    public partial class DronView : UserControl
    {
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

        Greska g = new Greska();
        KorekcijaPogreske kp = new KorekcijaPogreske();

        public static List<DronView> listaDronova = new List<DronView>();
        public List<DronView> vidljiviDronovi = new List<DronView>();


        public DronView()
        {
            InitializeComponent();
        }

        public void postaviVrijednosti(int id, float x, float y, Color b, string naz = "", float gx = 0, float gy = 0, float s = 0, float v = 0)
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

        private void DronView_Load(object sender, EventArgs e)
        {

            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(DronView_Paint);
        }

        private void DronView_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush boja = new SolidBrush(this.Boja);
            Pen olovka = new Pen(this.Boja);
            e.Graphics.FillEllipse(boja, this.Size.Width/2 - 5, this.Size.Height/2 - 5, 10, 10);
            this.GreskaX = g.polje[Math.Abs((int)this.TrenX), Math.Abs((int)this.TrenY)].greskaX;
            this.GreskaY = g.polje[Math.Abs((int)this.TrenX), Math.Abs((int)this.TrenY)].greskaY;
            e.Graphics.DrawEllipse(olovka, this.Size.Width / 2 - this.GreskaX, this.Size.Width / 2 - this.GreskaY, this.GreskaX * 2, this.GreskaY * 2);
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
            this.KorX = this.TrenX;
            this.KorY = this.TrenY;
            this.Location = new Point((int)this.TrenX - this.Size.Width/2, (int)this.TrenY - this.Size.Height/2);
            
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
            if (znak == 1)
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
            foreach (DronView d in listaDronova)
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

    }

    
}
