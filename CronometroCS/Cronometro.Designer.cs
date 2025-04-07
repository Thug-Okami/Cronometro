
using System;

namespace CronometroCS
{
    partial class FrmCronometro
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
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnComecarPausar = new System.Windows.Forms.Button();
            this.lblTempoSegundos = new System.Windows.Forms.Label();
            this.lblTempoMinutos = new System.Windows.Forms.Label();
            this.lblTempoMilesimos = new System.Windows.Forms.Label();
            this.lblTempoHoras = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(12, 351);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(112, 98);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnComecarPausar
            // 
            this.btnComecarPausar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComecarPausar.Location = new System.Drawing.Point(310, 351);
            this.btnComecarPausar.Name = "btnComecarPausar";
            this.btnComecarPausar.Size = new System.Drawing.Size(112, 98);
            this.btnComecarPausar.TabIndex = 2;
            this.btnComecarPausar.Text = "Iniciar / Pausar";
            this.btnComecarPausar.UseVisualStyleBackColor = true;
            this.btnComecarPausar.Click += new System.EventHandler(this.btnComecarPausar_Click_1);
            // 
            // lblTempoSegundos
            // 
            this.lblTempoSegundos.AutoSize = true;
            this.lblTempoSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoSegundos.Location = new System.Drawing.Point(207, 32);
            this.lblTempoSegundos.Name = "lblTempoSegundos";
            this.lblTempoSegundos.Size = new System.Drawing.Size(84, 46);
            this.lblTempoSegundos.TabIndex = 3;
            this.lblTempoSegundos.Text = "00s";
            // 
            // lblTempoMinutos
            // 
            this.lblTempoMinutos.AutoSize = true;
            this.lblTempoMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoMinutos.Location = new System.Drawing.Point(104, 32);
            this.lblTempoMinutos.Name = "lblTempoMinutos";
            this.lblTempoMinutos.Size = new System.Drawing.Size(97, 46);
            this.lblTempoMinutos.TabIndex = 4;
            this.lblTempoMinutos.Text = "00m";
            // 
            // lblTempoMilesimos
            // 
            this.lblTempoMilesimos.AutoSize = true;
            this.lblTempoMilesimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoMilesimos.Location = new System.Drawing.Point(297, 32);
            this.lblTempoMilesimos.Name = "lblTempoMilesimos";
            this.lblTempoMilesimos.Size = new System.Drawing.Size(139, 46);
            this.lblTempoMilesimos.TabIndex = 5;
            this.lblTempoMilesimos.Text = "000ms";
            // 
            // lblTempoHoras
            // 
            this.lblTempoHoras.AutoSize = true;
            this.lblTempoHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoHoras.Location = new System.Drawing.Point(12, 32);
            this.lblTempoHoras.Name = "lblTempoHoras";
            this.lblTempoHoras.Size = new System.Drawing.Size(86, 46);
            this.lblTempoHoras.TabIndex = 6;
            this.lblTempoHoras.Text = "00h";
            // 
            // FrmCronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(447, 461);
            this.Controls.Add(this.lblTempoHoras);
            this.Controls.Add(this.lblTempoMilesimos);
            this.Controls.Add(this.lblTempoMinutos);
            this.Controls.Add(this.lblTempoSegundos);
            this.Controls.Add(this.btnComecarPausar);
            this.Controls.Add(this.btnReiniciar);
            this.MaximizeBox = false;
            this.Name = "FrmCronometro";
            this.Text = "Cronômetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnComecarPausar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnComecarPausar;
        private System.Windows.Forms.Label lblTempoSegundos;
        private System.Windows.Forms.Label lblTempoMinutos;
        private System.Windows.Forms.Label lblTempoMilesimos;
        private System.Windows.Forms.Label lblTempoHoras;
    }
}

