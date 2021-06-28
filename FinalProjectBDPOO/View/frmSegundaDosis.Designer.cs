
namespace FinalProjectBDPOO.View
{
    partial class frmSegundaDosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSegundaDosis));
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(219, 76);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(148, 23);
            this.btnAgendar.TabIndex = 0;
            this.btnAgendar.Text = "Agendar Segunda Dosis";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(60, 76);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(143, 23);
            this.txtDui.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese DUI";
            // 
            // frmSegundaDosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(208)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(427, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.btnAgendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSegundaDosis";
            this.Text = "Segunda Dosis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label label1;
    }
}