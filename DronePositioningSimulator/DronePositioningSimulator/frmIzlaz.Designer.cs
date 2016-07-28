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
            this.SuspendLayout();
            // 
            // tmrDrawingTimer
            // 
            this.tmrDrawingTimer.Enabled = true;
            this.tmrDrawingTimer.Interval = 10;
            this.tmrDrawingTimer.Tick += new System.EventHandler(this.tmrDrawingTimer_Tick);
            // 
            // frmIzlaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Name = "frmIzlaz";
            this.Text = "frmIzlaz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIzlaz_FormClosed);
            this.Load += new System.EventHandler(this.frmIzlaz_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmIzlaz_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrDrawingTimer;
    }
}