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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSet1 = new System.Windows.Forms.PictureBox();
            this.pbSet2 = new System.Windows.Forms.PictureBox();
            this.pfondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaPequeña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbJugador1
            // 
            this.pbJugador1.BackColor = System.Drawing.Color.Transparent;
            this.pbJugador1.Location = new System.Drawing.Point(12, 109);
            this.pbJugador1.Name = "pbJugador1";
            this.pbJugador1.Size = new System.Drawing.Size(65, 160);
            this.pbJugador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJugador1.TabIndex = 2;
            this.pbJugador1.TabStop = false;
            // 
            // pbJugador2
            // 
            this.pbJugador2.BackColor = System.Drawing.Color.Transparent;
            this.pbJugador2.Location = new System.Drawing.Point(715, 123);
            this.pbJugador2.Name = "pbJugador2";
            this.pbJugador2.Size = new System.Drawing.Size(65, 160);
            this.pbJugador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJugador2.TabIndex = 1;
            this.pbJugador2.TabStop = false;
            // 
            // pbPantallaPequeña
            // 
            this.pbPantallaPequeña.BackColor = System.Drawing.Color.Transparent;
            this.pbPantallaPequeña.Location = new System.Drawing.Point(120, 341);
            this.pbPantallaPequeña.Name = "pbPantallaPequeña";
            this.pbPantallaPequeña.Size = new System.Drawing.Size(140, 83);
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
            this.pbBola.BackColor = System.Drawing.Color.Transparent;
            this.pbBola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbBola.Image = ((System.Drawing.Image)(resources.GetObject("pbBola.Image")));
            this.pbBola.Location = new System.Drawing.Point(369, 189);
            this.pbBola.Name = "pbBola";
            this.pbBola.Size = new System.Drawing.Size(28, 28);
            this.pbBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBola.TabIndex = 5;
            this.pbBola.TabStop = false;
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblScore2.Location = new System.Drawing.Point(699, 392);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(20, 24);
            this.lblScore2.TabIndex = 10;
            this.lblScore2.Text = "0";
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.Color.Transparent;
            this.lblScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScore1.Location = new System.Drawing.Point(48, 34);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(20, 24);
            this.lblScore1.TabIndex = 9;
            this.lblScore1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(662, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Marcador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Marcador";
            // 
            // pbSet1
            // 
            this.pbSet1.BackColor = System.Drawing.Color.Transparent;
            this.pbSet1.Location = new System.Drawing.Point(124, 9);
            this.pbSet1.Name = "pbSet1";
            this.pbSet1.Size = new System.Drawing.Size(124, 25);
            this.pbSet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSet1.TabIndex = 14;
            this.pbSet1.TabStop = false;
            // 
            // pbSet2
            // 
            this.pbSet2.BackColor = System.Drawing.Color.Transparent;
            this.pbSet2.Location = new System.Drawing.Point(532, 388);
            this.pbSet2.Name = "pbSet2";
            this.pbSet2.Size = new System.Drawing.Size(124, 25);
            this.pbSet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSet2.TabIndex = 15;
            this.pbSet2.TabStop = false;
            // 
            // pfondo
            // 
            this.pfondo.BackColor = System.Drawing.Color.Transparent;
            this.pfondo.Image = ((System.Drawing.Image)(resources.GetObject("pfondo.Image")));
            this.pfondo.Location = new System.Drawing.Point(1, -2);
            this.pfondo.Name = "pfondo";
            this.pfondo.Size = new System.Drawing.Size(794, 426);
            this.pfondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfondo.TabIndex = 11;
            this.pfondo.TabStop = false;
            this.pfondo.Click += new System.EventHandler(this.pfondo_Click);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 425);
            this.Controls.Add(this.pbSet2);
            this.Controls.Add(this.pbSet1);
            this.Controls.Add(this.pbJugador2);
            this.Controls.Add(this.pbJugador1);
            this.Controls.Add(this.pbBola);
            this.Controls.Add(this.pbPantallaPequeña);
            this.Controls.Add(this.pfondo);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPantallaPequeña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfondo)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSet1;
        private System.Windows.Forms.PictureBox pbSet2;
        private System.Windows.Forms.PictureBox pfondo;
    }
}