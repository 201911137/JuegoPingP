namespace Juego_ping_pong
{
    partial class Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.pbJugador1 = new System.Windows.Forms.PictureBox();
            this.pbJugador2 = new System.Windows.Forms.PictureBox();
            this.pbPantallaPequeña = new System.Windows.Forms.PictureBox();
            this.tmrTiempoActualizar = new System.Windows.Forms.Timer(this.components);
            this.tmrTiempoDibujar = new System.Windows.Forms.Timer(this.components);
            this.pbBola = new System.Windows.Forms.PictureBox();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaPequeña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBola)).BeginInit();
            this.SuspendLayout();
            // 
            // pbJugador1
            // 
            this.pbJugador1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbJugador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbJugador1.Location = new System.Drawing.Point(12, 178);
            this.pbJugador1.Name = "pbJugador1";
            this.pbJugador1.Size = new System.Drawing.Size(65, 160);
            this.pbJugador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJugador1.TabIndex = 2;
            this.pbJugador1.TabStop = false;
            this.pbJugador1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbJugador2
            // 
            this.pbJugador2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbJugador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbJugador2.Location = new System.Drawing.Point(725, 230);
            this.pbJugador2.Name = "pbJugador2";
            this.pbJugador2.Size = new System.Drawing.Size(65, 160);
            this.pbJugador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJugador2.TabIndex = 1;
            this.pbJugador2.TabStop = false;
            // 
            // pbPantallaPequeña
            // 
            this.pbPantallaPequeña.Image = ((System.Drawing.Image)(resources.GetObject("pbPantallaPequeña.Image")));
            this.pbPantallaPequeña.Location = new System.Drawing.Point(30, 22);
            this.pbPantallaPequeña.Name = "pbPantallaPequeña";
            this.pbPantallaPequeña.Size = new System.Drawing.Size(751, 341);
            this.pbPantallaPequeña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPantallaPequeña.TabIndex = 4;
            this.pbPantallaPequeña.TabStop = false;
            // 
            // tmrTiempoActualizar
            // 
            this.tmrTiempoActualizar.Enabled = true;
            this.tmrTiempoActualizar.Interval = 16;
            this.tmrTiempoActualizar.Tick += new System.EventHandler(this.tmrTiempoActualizar_Tick);
            // 
            // tmrTiempoDibujar
            // 
            this.tmrTiempoDibujar.Enabled = true;
            this.tmrTiempoDibujar.Interval = 16;
            this.tmrTiempoDibujar.Tick += new System.EventHandler(this.tmrTiempoDibujar_Tick);
            // 
            // pbBola
            // 
            this.pbBola.Image = ((System.Drawing.Image)(resources.GetObject("pbBola.Image")));
            this.pbBola.Location = new System.Drawing.Point(312, 67);
            this.pbBola.Name = "pbBola";
            this.pbBola.Size = new System.Drawing.Size(39, 34);
            this.pbBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBola.TabIndex = 5;
            this.pbBola.TabStop = false;
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblScore2.Location = new System.Drawing.Point(624, 22);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(166, 181);
            this.lblScore2.TabIndex = 10;
            this.lblScore2.Text = "0";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblScore1.Location = new System.Drawing.Point(12, 22);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(166, 181);
            this.lblScore1.TabIndex = 9;
            this.lblScore1.Text = "0";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 425);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.pbBola);
            this.Controls.Add(this.pbJugador1);
            this.Controls.Add(this.pbJugador2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.pbPantallaPequeña);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaPequeña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.PictureBox Imgfondo2;
        private System.Windows.Forms.PictureBox pbJugador2;
        private System.Windows.Forms.PictureBox pbJugador1;
        private System.Windows.Forms.PictureBox pbPantallaPequeña;
        private System.Windows.Forms.Timer tmrTiempoActualizar;
        private System.Windows.Forms.Timer tmrTiempoDibujar;
        private System.Windows.Forms.PictureBox pbBola;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore1;
    }
}