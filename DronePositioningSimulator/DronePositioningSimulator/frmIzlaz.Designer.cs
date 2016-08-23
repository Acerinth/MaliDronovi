namespace DronePositioningSimulator
{
    partial class frmIzlaz
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
            this.components = new System.ComponentModel.Container();
            this.tmrDrawingTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tmrDrawingTimer
            // 
            this.tmrDrawingTimer.Enabled = true;
            this.tmrDrawingTimer.Interval = 30;
            this.tmrDrawingTimer.Tick += new System.EventHandler(this.tmrDrawingTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 553);
            this.panel1.TabIndex = 0;
            // 
            // frmIzlaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel1);
            this.Name = "frmIzlaz";
            this.Text = "Output Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIzlaz_FormClosed);
            this.Load += new System.EventHandler(this.frmIzlaz_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmIzlaz_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrDrawingTimer;
        private System.Windows.Forms.Panel panel1;
    }
}