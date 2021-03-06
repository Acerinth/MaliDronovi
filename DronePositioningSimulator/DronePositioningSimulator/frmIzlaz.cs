﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

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
            /*
            foreach (Dron d in Dron.listaDronova)
            {
                SolidBrush boja = new SolidBrush(d.Boja);
                Pen olovka = new Pen(d.Boja);
                //for (int i = 0; i < 800; i++)
                //{
                //    for (int j = 0; j < 600; j++)
                //    {
                //        if (g.polje[i,j].greskaX != 0)
                //        {
                //            e.Graphics.DrawEllipse(Pens.Black, i, j, 1, 1);
                //        }
                //    }
                //}                
                e.Graphics.FillEllipse(boja, d.TrenX-5, d.TrenY-5, 10, 10);
                //e.Graphics.FillEllipse(Brushes.Black, d.KorX - 5, d.KorY - 5, 10, 10);
                d.GreskaX = g.polje[Math.Abs((int)d.TrenX), Math.Abs((int)d.TrenY)].greskaX;
                d.GreskaY = g.polje[Math.Abs((int)d.TrenX), Math.Abs((int)d.TrenY)].greskaY;
                e.Graphics.DrawEllipse(olovka, d.TrenX- d.GreskaX, d.TrenY- d.GreskaY, d.GreskaX*2, d.GreskaY*2);

            } */
            foreach (Dron d in Dron.listaDronova)
            {
                foreach (Region r in d.listaVijenaca)
                {
                    if (d.PrikazVijenaca)
                    {
                        e.Graphics.FillRegion(System.Drawing.Brushes.Beige, r);
                    }
                }
                    
                foreach (System.Drawing.Drawing2D.GraphicsPath gp in d.listaElipsi)
                {
                    if (d.PrikazVijenaca)
                    {
                        System.Drawing.Pen olovka2 = new System.Drawing.Pen(d.Boja);
                        e.Graphics.DrawPath(olovka2, gp);
                    }
                }

                if (tmrDrawingTimer.Enabled == true)
                {
                    e.Graphics.FillRegion(System.Drawing.Brushes.LightBlue, d.regijaPogreske);
                }


                SolidBrush boja = new SolidBrush(d.Boja);
                System.Drawing.Pen olovka = new System.Drawing.Pen(d.Boja);
                e.Graphics.FillEllipse(boja, d.TrenX - 5, d.TrenY - 5, 10, 10);
                d.GreskaX = GeneratorGreske.polje[Math.Abs((int)d.TrenX), Math.Abs((int)d.TrenY)].greskaX;
                d.GreskaY = GeneratorGreske.polje[Math.Abs((int)d.TrenX), Math.Abs((int)d.TrenY)].greskaY;
                e.Graphics.DrawEllipse(olovka, d.TrenX - d.GreskaX, d.TrenY - d.GreskaY, d.GreskaX * 2, d.GreskaY * 2);
            }
            
        }

        private void tmrDrawingTimer_Tick(object sender, EventArgs e)
        {
            foreach (Dron d in Dron.listaDronova)
            {
                d.provjeriRub(this.ClientSize.Width-5, this.ClientSize.Height - 5);
                d.pomakniDron();
                d.pronadjiDronove();
                d.korigirajPogresku();
            }
            this.Refresh();
        }

        /*public void pokaziDronove()
        {
            foreach (DronView d in DronView.listaDronova)
            {
                if (!this.Controls.Contains(d))
                {
                    this.Controls.Add(d);
                }
            }
        }*/
        
       
    }
}
