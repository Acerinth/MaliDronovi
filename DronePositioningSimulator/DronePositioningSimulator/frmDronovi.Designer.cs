namespace DronePositioningSimulator
{
    partial class frmDronovi
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
            this.grpNoviDron = new System.Windows.Forms.GroupBox();
            this.txtIDDron = new System.Windows.Forms.TextBox();
            this.txtNazivDrona = new System.Windows.Forms.TextBox();
            this.txtPozX = new System.Windows.Forms.TextBox();
            this.txtSmjer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPozY = new System.Windows.Forms.TextBox();
            this.txtBrzina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSpremiDron = new System.Windows.Forms.Button();
            this.txtSignal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPostojeciDronovi = new System.Windows.Forms.DataGridView();
            this.IDDron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivDron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpNoviDron.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciDronovi)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNoviDron
            // 
            this.grpNoviDron.Controls.Add(this.label6);
            this.grpNoviDron.Controls.Add(this.txtSignal);
            this.grpNoviDron.Controls.Add(this.btnSpremiDron);
            this.grpNoviDron.Controls.Add(this.label5);
            this.grpNoviDron.Controls.Add(this.label4);
            this.grpNoviDron.Controls.Add(this.txtBrzina);
            this.grpNoviDron.Controls.Add(this.txtPozY);
            this.grpNoviDron.Controls.Add(this.label3);
            this.grpNoviDron.Controls.Add(this.label2);
            this.grpNoviDron.Controls.Add(this.label1);
            this.grpNoviDron.Controls.Add(this.txtSmjer);
            this.grpNoviDron.Controls.Add(this.txtPozX);
            this.grpNoviDron.Controls.Add(this.txtNazivDrona);
            this.grpNoviDron.Controls.Add(this.txtIDDron);
            this.grpNoviDron.Location = new System.Drawing.Point(30, 28);
            this.grpNoviDron.Name = "grpNoviDron";
            this.grpNoviDron.Size = new System.Drawing.Size(526, 207);
            this.grpNoviDron.TabIndex = 1;
            this.grpNoviDron.TabStop = false;
            this.grpNoviDron.Text = "Novi dron";
            // 
            // txtIDDron
            // 
            this.txtIDDron.Location = new System.Drawing.Point(148, 35);
            this.txtIDDron.Name = "txtIDDron";
            this.txtIDDron.Size = new System.Drawing.Size(151, 20);
            this.txtIDDron.TabIndex = 0;
            // 
            // txtNazivDrona
            // 
            this.txtNazivDrona.Location = new System.Drawing.Point(148, 61);
            this.txtNazivDrona.Name = "txtNazivDrona";
            this.txtNazivDrona.Size = new System.Drawing.Size(151, 20);
            this.txtNazivDrona.TabIndex = 1;
            // 
            // txtPozX
            // 
            this.txtPozX.Location = new System.Drawing.Point(148, 87);
            this.txtPozX.Name = "txtPozX";
            this.txtPozX.Size = new System.Drawing.Size(68, 20);
            this.txtPozX.TabIndex = 2;
            // 
            // txtSmjer
            // 
            this.txtSmjer.Location = new System.Drawing.Point(148, 141);
            this.txtSmjer.Name = "txtSmjer";
            this.txtSmjer.Size = new System.Drawing.Size(151, 20);
            this.txtSmjer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID drona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv drona:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Početna pozicija (x, y):";
            // 
            // txtPozY
            // 
            this.txtPozY.Location = new System.Drawing.Point(232, 87);
            this.txtPozY.Name = "txtPozY";
            this.txtPozY.Size = new System.Drawing.Size(67, 20);
            this.txtPozY.TabIndex = 3;
            // 
            // txtBrzina
            // 
            this.txtBrzina.Location = new System.Drawing.Point(148, 167);
            this.txtBrzina.Name = "txtBrzina";
            this.txtBrzina.Size = new System.Drawing.Size(151, 20);
            this.txtBrzina.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Smjer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Brzina:";
            // 
            // btnSpremiDron
            // 
            this.btnSpremiDron.Location = new System.Drawing.Point(360, 114);
            this.btnSpremiDron.Name = "btnSpremiDron";
            this.btnSpremiDron.Size = new System.Drawing.Size(140, 69);
            this.btnSpremiDron.TabIndex = 7;
            this.btnSpremiDron.Text = "Spremi dron";
            this.btnSpremiDron.UseVisualStyleBackColor = true;
            this.btnSpremiDron.Click += new System.EventHandler(this.btnSpremiDron_Click);
            // 
            // txtSignal
            // 
            this.txtSignal.Location = new System.Drawing.Point(148, 114);
            this.txtSignal.Name = "txtSignal";
            this.txtSignal.Size = new System.Drawing.Size(151, 20);
            this.txtSignal.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Jačina signala:";
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
            this.Y});
            this.dgvPostojeciDronovi.Location = new System.Drawing.Point(30, 255);
            this.dgvPostojeciDronovi.Name = "dgvPostojeciDronovi";
            this.dgvPostojeciDronovi.ReadOnly = true;
            this.dgvPostojeciDronovi.Size = new System.Drawing.Size(526, 150);
            this.dgvPostojeciDronovi.TabIndex = 8;
            // 
            // IDDron
            // 
            this.IDDron.DataPropertyName = "IDDron";
            this.IDDron.HeaderText = "ID drona";
            this.IDDron.Name = "IDDron";
            this.IDDron.ReadOnly = true;
            // 
            // NazivDron
            // 
            this.NazivDron.DataPropertyName = "NazivDron";
            this.NazivDron.HeaderText = "Naziv drona";
            this.NazivDron.Name = "NazivDron";
            this.NazivDron.ReadOnly = true;
            // 
            // X
            // 
            this.X.DataPropertyName = "X";
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.DataPropertyName = "Y";
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // frmDronovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 435);
            this.Controls.Add(this.dgvPostojeciDronovi);
            this.Controls.Add(this.grpNoviDron);
            this.Name = "frmDronovi";
            this.Text = "Dronovi";
            this.Load += new System.EventHandler(this.frmDronovi_Load);
            this.grpNoviDron.ResumeLayout(false);
            this.grpNoviDron.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostojeciDronovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpNoviDron;
        private System.Windows.Forms.Button btnSpremiDron;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrzina;
        private System.Windows.Forms.TextBox txtPozY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSmjer;
        private System.Windows.Forms.TextBox txtPozX;
        private System.Windows.Forms.TextBox txtNazivDrona;
        private System.Windows.Forms.TextBox txtIDDron;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSignal;
        private System.Windows.Forms.DataGridView dgvPostojeciDronovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDron;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivDron;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}