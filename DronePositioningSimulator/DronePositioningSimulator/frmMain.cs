﻿using System;
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
        int id;
        float pozX;
        float pozY;
        float sig;

        public frmMain()
        {
            InitializeComponent();
        }

        

        private bool ProvjeriIspravnost()
        {
            if (int.TryParse(txtIDDron.Text, out id) &&
            float.TryParse(txtPozX.Text, out pozX) &&
            float.TryParse(txtPozY.Text, out pozY) &&
            float.TryParse(txtSignal.Text, out sig)) return true;
            else return false;
        }

        private void OcistiPolja()
        {
            this.txtIDDron.Text = "";
            this.txtNazivDrona.Text = "";
            this.txtPozX.Text = "";
            this.txtPozY.Text = "";
            this.txtSignal.Text = "";
            this.txtSmjer.Text = "";
            this.txtBrzina.Text = "";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvPostojeciDronovi.DataSource = Dron.listaDronova.Select(l => new { IDDron = l.IDDron, NazivDron = l.NazivDron, X = l.X, Y = l.Y }).ToList();
        }

        private void rbRucno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRucno.Checked == true)
            {
                grpNoviDron.Enabled = true;
            }
            else
            {
                grpNoviDron.Enabled = false;
            }
        }

        private void btnSpremiDron_Click(object sender, EventArgs e)
        {
            if (ProvjeriIspravnost())
            {
                Dron noviDron = new Dron(id, pozX, pozY, sig, txtNazivDrona.Text);
                Dron.listaDronova.Add(noviDron);
                MessageBox.Show("Novi dron uspješno dodan!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPolja();
                dgvPostojeciDronovi.DataSource = Dron.listaDronova.Select(l => new { IDDron = l.IDDron, NazivDron = l.NazivDron, X = l.X, Y = l.Y }).ToList();
            }
            else
            {
                MessageBox.Show("Pogrešno uneseni podaci", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
