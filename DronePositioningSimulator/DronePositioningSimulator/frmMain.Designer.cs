namespace DronePositioningSimulator
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aplikacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokreniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaustaviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dronoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aplikacijaToolStripMenuItem,
            this.simulacijaToolStripMenuItem,
            this.pomoćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // aplikacijaToolStripMenuItem
            // 
            this.aplikacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postavkeToolStripMenuItem,
            this.zatvoriToolStripMenuItem});
            this.aplikacijaToolStripMenuItem.Name = "aplikacijaToolStripMenuItem";
            this.aplikacijaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aplikacijaToolStripMenuItem.Text = "Aplikacija";
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.postavkeToolStripMenuItem.Text = "Postavke";
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            // 
            // simulacijaToolStripMenuItem
            // 
            this.simulacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dronoviToolStripMenuItem,
            this.pokreniToolStripMenuItem,
            this.zaustaviToolStripMenuItem});
            this.simulacijaToolStripMenuItem.Name = "simulacijaToolStripMenuItem";
            this.simulacijaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.simulacijaToolStripMenuItem.Text = "Simulacija";
            // 
            // pokreniToolStripMenuItem
            // 
            this.pokreniToolStripMenuItem.Name = "pokreniToolStripMenuItem";
            this.pokreniToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pokreniToolStripMenuItem.Text = "Pokreni";
            // 
            // zaustaviToolStripMenuItem
            // 
            this.zaustaviToolStripMenuItem.Name = "zaustaviToolStripMenuItem";
            this.zaustaviToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zaustaviToolStripMenuItem.Text = "Zaustavi";
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            // 
            // dronoviToolStripMenuItem
            // 
            this.dronoviToolStripMenuItem.Name = "dronoviToolStripMenuItem";
            this.dronoviToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dronoviToolStripMenuItem.Text = "Dronovi";
            this.dronoviToolStripMenuItem.Click += new System.EventHandler(this.dronoviToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 497);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem postavkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaustaviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokreniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplikacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dronoviToolStripMenuItem;
    }
}

