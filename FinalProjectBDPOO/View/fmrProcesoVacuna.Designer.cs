
namespace FinalProjectBDPOO.View
{
    partial class fmrProcesoVacuna
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHorainicio = new System.Windows.Forms.Label();
            this.lblcita = new System.Windows.Forms.Label();
            this.cmbSeleccion = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblHorainicio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblcita, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbSeleccion, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHorainicio
            // 
            this.lblHorainicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHorainicio.AutoSize = true;
            this.lblHorainicio.Location = new System.Drawing.Point(3, 108);
            this.lblHorainicio.Name = "lblHorainicio";
            this.lblHorainicio.Size = new System.Drawing.Size(210, 15);
            this.lblHorainicio.TabIndex = 0;
            this.lblHorainicio.Text = "Hora de Inicio";
            this.lblHorainicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcita
            // 
            this.lblcita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcita.AutoSize = true;
            this.lblcita.Location = new System.Drawing.Point(3, 70);
            this.lblcita.Name = "lblcita";
            this.lblcita.Size = new System.Drawing.Size(210, 15);
            this.lblcita.TabIndex = 1;
            this.lblcita.Text = "Cita";
            this.lblcita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSeleccion
            // 
            this.cmbSeleccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSeleccion.FormattingEnabled = true;
            this.cmbSeleccion.Location = new System.Drawing.Point(219, 66);
            this.cmbSeleccion.Name = "cmbSeleccion";
            this.cmbSeleccion.Size = new System.Drawing.Size(210, 23);
            this.cmbSeleccion.TabIndex = 2;
            // 
            // fmrProcesoVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(432, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "fmrProcesoVacuna";
            this.Text = "Proceso Vacuna";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHorainicio;
        private System.Windows.Forms.Label lblcita;
        private System.Windows.Forms.ComboBox cmbSeleccion;
    }
}