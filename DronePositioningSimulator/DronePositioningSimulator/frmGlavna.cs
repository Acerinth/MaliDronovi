using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DronePositioningSimulator
{
    public partial class frmGlavna : Form
    {
        public static List<string> listaRezultata = new List<string>();
        public static GeneratorGreske g = new GeneratorGreske();

        int id;
        float pozX;
        float pozY;
        float s;
        float v;
        public frmIzlaz izlaz;

        public frmGlavna()
        {
            InitializeComponent();
        }

        private bool ProvjeriIspravnost()
        {
            if (int.TryParse(txtIDDron.Text, out id) &&
            float.TryParse(txtPozX.Text, out pozX) &&
            float.TryParse(txtPozY.Text, out pozY) &&
            float.TryParse(txtSmjerX.Text, out s) &&
            float.TryParse(txtBrzina.Text, out v)) {
                if (s >= 0 && s <= 360 && v>=0 && v<=15)
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
            this.txtBrzina.Text = "0";
            this.txtSmjerX.Text = "0";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //dgvPostojeciDronovi.DataSource = Dron.listaDronova;
            this.txtBrzina.Text = "0";
            this.txtSmjerX.Text = "0";
            dgvPostojeciDronovi.DataSource = Dron.listaDronova.Select(l => new { IDDron = l.IDDron, NazivDron = l.NazivDron, X = l.X, Y = l.Y, Boja = l.Boja, Brzina = l.Brzina, Smjer = l.Smjer }).ToList();
            izlaz = new frmIzlaz();
            izlaz.Show();
        }

        private void btnSpremiDron_Click(object sender, EventArgs e)
        {
            if (ProvjeriIspravnost())
            {
                Dron noviDron = new Dron();
                noviDron.postaviVrijednosti(id, pozX, pozY, btnBoja.BackColor, txtNazivDrona.Text, 0, 0, s, v);
                Dron.listaDronova.Add(noviDron);
                
                OcistiPolja();
                dgvPostojeciDronovi.DataSource = Dron.listaDronova.Select(l => new { IDDron = l.IDDron, NazivDron = l.NazivDron, X = l.X, Y = l.Y, Boja = l.Boja, Brzina = l.Brzina, Smjer = l.Smjer }).ToList();
                
            }
            else
            {
                MessageBox.Show("Pogrešno uneseni podaci", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (Dron.listaDronova.Count > 0)
            {
                omoguciGumbe(true);
                izlaz.Refresh();
                //izlaz.pokaziDronove();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int index = dgvPostojeciDronovi.CurrentRow.Index;
            //izlaz.Controls.Remove(DronView.listaDronova.ElementAt(index));
            Dron.listaDronova.RemoveAt(index);
            //dgvPostojeciDronovi.DataSource = Dron.listaDronova;
            dgvPostojeciDronovi.DataSource = Dron.listaDronova.Select(l => new { IDDron = l.IDDron, NazivDron = l.NazivDron, X = l.X, Y = l.Y, Boja = l.Boja, Brzina = l.Brzina, Smjer = l.Smjer }).ToList();
            
            if (Dron.listaDronova.Count > 0)
            {
                omoguciGumbe(true);
                izlaz.Refresh();
                //izlaz.pokaziDronove();
            }
            else
            {
                izlaz.Refresh();
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
            izlaz.tmrDrawingTimer.Enabled = true;
            izlaz.tmrDrawingTimer.Start();
            omoguciPonovnoPokretanje(false);
        }

        private void omoguciGumbe(bool y)
        {
            this.btnObrisi.Enabled = y;
            this.btnPokreni.Enabled = y;
            this.btnVijenci.Enabled = y;
        }

        private void omoguciPonovnoPokretanje (bool y)
        {
            btnPauziraj.Enabled = !y;
            btnPokreni.Enabled = y;
            btnObrisi.Enabled = y;
            btnReset.Enabled = y;
            btnExport.Enabled = y;
            btnSpremiDron.Enabled = y;
            btnExit.Enabled = y;
        }

        private void btnPauziraj_Click(object sender, EventArgs e)
        {
            izlaz.tmrDrawingTimer.Stop();
            izlaz.tmrDrawingTimer.Enabled = false;
            omoguciPonovnoPokretanje(true);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listaRezultata.Clear();
            foreach (Dron d in Dron.listaDronova)
            {
                d.resetrirajTrenutno();
            }
            izlaz.Refresh();
            //izlaz.pokaziDronove();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StringBuilder csv = new StringBuilder();
            csv.AppendLine("ID Drona;Naziv drona;Lokacija X;LokacijaY;GPS površina;Korigirana površina;Postotak poboljšanja");
            foreach (string z in listaRezultata)
            {
                csv.AppendLine(z);
            }
            File.WriteAllText(saveFileDialog1.FileName, csv.ToString(), UTF8Encoding.UTF8);
            MessageBox.Show("Uspješno spremljeno.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVijenci_Click(object sender, EventArgs e)
        {
            int index = dgvPostojeciDronovi.CurrentRow.Index;
            Dron d = Dron.listaDronova.ElementAt(index);
            d.PrikazVijenaca = !d.PrikazVijenaca;
        }
    }
}
