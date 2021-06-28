
namespace FinalProjectBDPOO.View
{
    partial class fmrMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proceoDeVacunaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesosToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarCitasToolStripMenuItem,
            this.realizarCitasToolStripMenuItem,
            this.proceoDeVacunaciónToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // verificarCitasToolStripMenuItem
            // 
            this.verificarCitasToolStripMenuItem.Name = "verificarCitasToolStripMenuItem";
            this.verificarCitasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.verificarCitasToolStripMenuItem.Text = "Verificar Citas";
            this.verificarCitasToolStripMenuItem.Click += new System.EventHandler(this.verificarCitasToolStripMenuItem_Click);
            // 
            // realizarCitasToolStripMenuItem
            // 
            this.realizarCitasToolStripMenuItem.Name = "realizarCitasToolStripMenuItem";
            this.realizarCitasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.realizarCitasToolStripMenuItem.Text = "Realizar Citas";
            this.realizarCitasToolStripMenuItem.Click += new System.EventHandler(this.realizarCitasToolStripMenuItem_Click);
            // 
            // proceoDeVacunaciónToolStripMenuItem
            // 
            this.proceoDeVacunaciónToolStripMenuItem.Name = "proceoDeVacunaciónToolStripMenuItem";
            this.proceoDeVacunaciónToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.proceoDeVacunaciónToolStripMenuItem.Text = "Proceso de Vacunación";
            this.proceoDeVacunaciónToolStripMenuItem.Click += new System.EventHandler(this.proceoDeVacunaciónToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // fmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmrMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fmrMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proceoDeVacunaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}