using System;
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
    public partial class frmGlavna : Form
    {
        int id;
        float pozX;
        float pozY;
        float sig;
        float s;
        float v;

        public frmGlavna()
        {
            InitializeComponent();
        }

        

        private bool ProvjeriIspravnost()
        {
            if (int.TryParse(txtIDDron.Text, out id) &&
            float.TryParse(txtPozX.Text, out pozX) &&
            float.TryParse(txtPozY.Text, out pozY) &&
            float.TryParse(txtSignal.Text, out sig) &&
            float.TryParse(txtSmjerX.Text, out s) &&
            float.TryParse(txtBrzina.Text, out v)) {
                if (s >= 0 && s <= 360)
                {
                    return true;
                }
                else return false;
            } 
            else return false;
        }

        private void OcistiPolja()
        {
            this.txtIDDron.Text = "";
            this.txtNazivDrona.Text = "";
            this.txtPozX.Text = "";
            this.txtPozY.Text = "";
            this.txtSignal.Text = "";
            this.txtBrzina.Text = "0";
            this.txtSmjerX.Text = "0";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //dgvPostojeciDronovi.DataSource = Dron.listaDronova;
            this.txtBrzina.Text = "0";
            this.txtSmjerX.Text = "0";
            dgvPostojeciDronovi.DataSource = Dron.listaDronova.Select(l => new { IDDron = l.IDDron, NazivDron = l.NazivDron, X = l.X, Y = l.Y, Boja = l.Boja, Brzina = l.Brzina, Smjer = l.Smjer, JacinaSignala = l.JacinaSignala }).ToList();
        }

        private void rbRucno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRucno.Checked == true)
            {
                grpNoviDron.Enabled = true;
                btnBoja.BackColor = Color.Black;
            }
            else
            {
                grpNoviDron.Enabled = false;
                btnBoja.BackColor = Color.White;
            }
        }

        private void btnSpremiDron_Click(object sender, EventArgs e)
        {
            if (ProvjeriIspravnost())
            {
                Dron noviDron = new Dron(id, pozX, pozY, sig, btnBoja.BackColor, txtNazivDrona.Text, 0, 0, s, v);
                Dron.listaDronova.Add(noviDron);
                MessageBox.Show("Novi dron uspješno dodan!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OcistiPolja();
                //dgvPostojeciDronovi.DataSource = Dron.listaDronova;
                dgvPostojeciDronovi.DataSource = Dron.listaDronova.Select(l => new { IDDron = l.IDDron, NazivDron = l.NazivDron, X = l.X, Y = l.Y, Boja = l.Boja, Brzina = l.Brzina, Smjer = l.Smjer, JacinaSignala = l.JacinaSignala }).ToList();
            }
            else
            {
                MessageBox.Show("Pogrešno uneseni podaci", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Dron.listaDronova.Count > 0)
            {
                omoguciGumbe(true);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int index = dgvPostojeciDronovi.CurrentRow.Index;
            Dron.listaDronova.RemoveAt(index);
            //dgvPostojeciDronovi.DataSource = Dron.listaDronova;
            dgvPostojeciDronovi.DataSource = Dron.listaDronova.Select(l => new { IDDron = l.IDDron, NazivDron = l.NazivDron, X = l.X, Y = l.Y, Boja = l.Boja, Brzina = l.Brzina, Smjer = l.Smjer, JacinaSignala = l.JacinaSignala }).ToList();
            if (Dron.listaDronova.Count > 0)
            {
                omoguciGumbe(true);
            }
            else
            {
                omoguciGumbe(false);
            }
        }

        private void btnBoja_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnBoja.BackColor = colorDialog1.Color;
            txtBoja.Text = colorDialog1.Color.ToString();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            frmIzlaz izlaz = new frmIzlaz();
            izlaz.Show();
        }

        private void omoguciGumbe(bool y)
        {
            this.btnObrisi.Enabled = y;
            this.btnPokreni.Enabled = y;
        }
    }
}
