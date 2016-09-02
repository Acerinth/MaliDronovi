namespace DronePositioningSimulator
{
    partial class frmGlavna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPostojeciDronovi = new System.Windows.Forms.DataGridView();
            this.IDDron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivDron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Boja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brzina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Smjer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNoviDron = new System.Windows.Forms.GroupBox();
            this.btnBoja = new System.Windows.Forms.Button();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSpremiDron = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrzina = new System.Windows.Forms.TextBox();
            this.txtPozY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSmjerX = new System.Windows.Forms.TextBox();
            this.txtPozX = new System.Windows.Forms.TextBox();
            this.txtNazivDrona = new System.Windows.Forms.TextBox();
            this.txtIDDron = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.btnPauziraj = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVijenci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciDronovi)).BeginInit();
            this.grpNoviDron.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPostojeciDronovi
            // 
            this.dgvPostojeciDronovi.AllowUserToAddRows = false;
            this.dgvPostojeciDronovi.AllowUserToDeleteRows = false;
            this.dgvPostojeciDronovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostojeciDronovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDron,
            this.NazivDron,
            this.X,
            this.Y,
            this.Boja,
            this.Brzina,
            this.Smjer});
            this.dgvPostojeciDronovi.Location = new System.Drawing.Point(496, 76);
            this.dgvPostojeciDronovi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPostojeciDronovi.Name = "dgvPostojeciDronovi";
            this.dgvPostojeciDronovi.ReadOnly = true;
            this.dgvPostojeciDronovi.Size = new System.Drawing.Size(753, 292);
            this.dgvPostojeciDronovi.TabIndex = 10;
            // 
            // IDDron
            // 
            this.IDDron.DataPropertyName = "IDDron";
            this.IDDron.HeaderText = "ID";
            this.IDDron.Name = "IDDron";
            this.IDDron.ReadOnly = true;
            this.IDDron.Width = 50;
            // 
            // NazivDron
            // 
            this.NazivDron.DataPropertyName = "NazivDron";
            this.NazivDron.HeaderText = "Naziv";
            this.NazivDron.Name = "NazivDron";
            this.NazivDron.ReadOnly = true;
            // 
            // X
            // 
            this.X.DataPropertyName = "X";
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.DataPropertyName = "Y";
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 50;
            // 
            // Boja
            // 
            this.Boja.DataPropertyName = "Boja";
            this.Boja.HeaderText = "Boja";
            this.Boja.Name = "Boja";
            this.Boja.ReadOnly = true;
            // 
            // Brzina
            // 
            this.Brzina.DataPropertyName = "Brzina";
            this.Brzina.HeaderText = "Brzina";
            this.Brzina.Name = "Brzina";
            this.Brzina.ReadOnly = true;
            this.Brzina.Width = 50;
            // 
            // Smjer
            // 
            this.Smjer.DataPropertyName = "Smjer";
            this.Smjer.HeaderText = "Smjer";
            this.Smjer.Name = "Smjer";
            this.Smjer.ReadOnly = true;
            this.Smjer.Width = 50;
            // 
            // grpNoviDron
            // 
            this.grpNoviDron.Controls.Add(this.btnBoja);
            this.grpNoviDron.Controls.Add(this.txtBoja);
            this.grpNoviDron.Controls.Add(this.label9);
            this.grpNoviDron.Controls.Add(this.btnSpremiDron);
            this.grpNoviDron.Controls.Add(this.label5);
            this.grpNoviDron.Controls.Add(this.label4);
            this.grpNoviDron.Controls.Add(this.txtBrzina);
            this.grpNoviDron.Controls.Add(this.txtPozY);
            this.grpNoviDron.Controls.Add(this.label3);
            this.grpNoviDron.Controls.Add(this.label2);
            this.grpNoviDron.Controls.Add(this.label7);
            this.grpNoviDron.Controls.Add(this.txtSmjerX);
            this.grpNoviDron.Controls.Add(this.txtPozX);
            this.grpNoviDron.Controls.Add(this.txtNazivDrona);
            this.grpNoviDron.Controls.Add(this.txtIDDron);
            this.grpNoviDron.Location = new System.Drawing.Point(24, 29);
            this.grpNoviDron.Margin = new System.Windows.Forms.Padding(4);
            this.grpNoviDron.Name = "grpNoviDron";
            this.grpNoviDron.Padding = new System.Windows.Forms.Padding(4);
            this.grpNoviDron.Size = new System.Drawing.Size(428, 339);
            this.grpNoviDron.TabIndex = 9;
            this.grpNoviDron.TabStop = false;
            this.grpNoviDron.Text = "Novi dron";
            // 
            // btnBoja
            // 
            this.btnBoja.BackColor = System.Drawing.Color.Black;
            this.btnBoja.Location = new System.Drawing.Point(197, 201);
            this.btnBoja.Name = "btnBoja";
            this.btnBoja.Size = new System.Drawing.Size(38, 33);
            this.btnBoja.TabIndex = 7;
            this.btnBoja.UseVisualStyleBackColor = false;
            this.btnBoja.Click += new System.EventHandler(this.btnBoja_Click);
            // 
            // txtBoja
            // 
            this.txtBoja.Location = new System.Drawing.Point(256, 206);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.ReadOnly = true;
            this.txtBoja.Size = new System.Drawing.Size(141, 22);
            this.txtBoja.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Boja:";
            // 
            // btnSpremiDron
            // 
            this.btnSpremiDron.Location = new System.Drawing.Point(139, 265);
            this.btnSpremiDron.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremiDron.Name = "btnSpremiDron";
            this.btnSpremiDron.Size = new System.Drawing.Size(147, 55);
            this.btnSpremiDron.TabIndex = 8;
            this.btnSpremiDron.Text = "Dodaj dron";
            this.btnSpremiDron.UseVisualStyleBackColor = true;
            this.btnSpremiDron.Click += new System.EventHandler(this.btnSpremiDron_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Brzina (0-15):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Smjer (0°-360°):";
            // 
            // txtBrzina
            // 
            this.txtBrzina.Location = new System.Drawing.Point(197, 167);
            this.txtBrzina.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrzina.Name = "txtBrzina";
            this.txtBrzina.Size = new System.Drawing.Size(200, 22);
            this.txtBrzina.TabIndex = 6;
            // 
            // txtPozY
            // 
            this.txtPozY.Location = new System.Drawing.Point(309, 107);
            this.txtPozY.Margin = new System.Windows.Forms.Padding(4);
            this.txtPozY.Name = "txtPozY";
            this.txtPozY.Size = new System.Drawing.Size(88, 22);
            this.txtPozY.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Početna pozicija (x, y):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv drona:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "ID drona:";
            // 
            // txtSmjerX
            // 
            this.txtSmjerX.Location = new System.Drawing.Point(197, 137);
            this.txtSmjerX.Margin = new System.Windows.Forms.Padding(4);
            this.txtSmjerX.Name = "txtSmjerX";
            this.txtSmjerX.Size = new System.Drawing.Size(200, 22);
            this.txtSmjerX.TabIndex = 5;
            // 
            // txtPozX
            // 
            this.txtPozX.Location = new System.Drawing.Point(197, 107);
            this.txtPozX.Margin = new System.Windows.Forms.Padding(4);
            this.txtPozX.Name = "txtPozX";
            this.txtPozX.Size = new System.Drawing.Size(89, 22);
            this.txtPozX.TabIndex = 2;
            // 
            // txtNazivDrona
            // 
            this.txtNazivDrona.Location = new System.Drawing.Point(197, 75);
            this.txtNazivDrona.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivDrona.Name = "txtNazivDrona";
            this.txtNazivDrona.Size = new System.Drawing.Size(200, 22);
            this.txtNazivDrona.TabIndex = 1;
            // 
            // txtIDDron
            // 
            this.txtIDDron.Location = new System.Drawing.Point(197, 43);
            this.txtIDDron.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDDron.Name = "txtIDDron";
            this.txtIDDron.Size = new System.Drawing.Size(200, 22);
            this.txtIDDron.TabIndex = 0;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(1078, 386);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(147, 55);
            this.btnObrisi.TabIndex = 12;
            this.btnObrisi.Text = "Obriši označenog";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Enabled = false;
            this.btnPokreni.Location = new System.Drawing.Point(1078, 470);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(147, 55);
            this.btnPokreni.TabIndex = 13;
            this.btnPokreni.Text = "Pokreni simulaciju";
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // btnPauziraj
            // 
            this.btnPauziraj.Enabled = false;
            this.btnPauziraj.Location = new System.Drawing.Point(909, 470);
            this.btnPauziraj.Name = "btnPauziraj";
            this.btnPauziraj.Size = new System.Drawing.Size(147, 55);
            this.btnPauziraj.TabIndex = 14;
            this.btnPauziraj.Text = "Pauziraj";
            this.btnPauziraj.UseVisualStyleBackColor = true;
            this.btnPauziraj.Click += new System.EventHandler(this.btnPauziraj_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(673, 470);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 55);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Resetiraj";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(496, 470);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(147, 55);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Spremi rezultate";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV file|*.csv";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Popis unesenih dronova:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(24, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 55);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Izlaz";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVijenci
            // 
            this.btnVijenci.Enabled = false;
            this.btnVijenci.Location = new System.Drawing.Point(909, 386);
            this.btnVijenci.Name = "btnVijenci";
            this.btnVijenci.Size = new System.Drawing.Size(147, 55);
            this.btnVijenci.TabIndex = 19;
            this.btnVijenci.Text = "Pokaži/sakrij vijence označenog";
            this.btnVijenci.UseVisualStyleBackColor = true;
            this.btnVijenci.Click += new System.EventHandler(this.btnVijenci_Click);
            // 
            // frmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 553);
            this.Controls.Add(this.btnVijenci);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPauziraj);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvPostojeciDronovi);
            this.Controls.Add(this.grpNoviDron);
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Drone Positioning Simulator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciDronovi)).EndInit();
            this.grpNoviDron.ResumeLayout(false);
            this.grpNoviDron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPostojeciDronovi;
        private System.Windows.Forms.GroupBox grpNoviDron;
        private System.Windows.Forms.Button btnSpremiDron;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrzina;
        private System.Windows.Forms.TextBox txtPozY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSmjerX;
        private System.Windows.Forms.TextBox txtPozX;
        private System.Windows.Forms.TextBox txtNazivDrona;
        private System.Windows.Forms.TextBox txtIDDron;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnBoja;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.Button btnPauziraj;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDron;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivDron;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Boja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brzina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Smjer;
        private System.Windows.Forms.Button btnVijenci;
    }
}

