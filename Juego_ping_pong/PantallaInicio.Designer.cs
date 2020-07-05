using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace Juego_ping_pong
{


    partial class Ping_Pong
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }




        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ping_Pong));
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.Imgstart = new System.Windows.Forms.PictureBox();
            this.Imgfondo1 = new System.Windows.Forms.PictureBox();
            this.bStartHost = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gMultiplayer = new System.Windows.Forms.GroupBox();
            this.bMultiPlayer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgfondo1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.gMultiplayer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtP1
            // 
            this.txtP1.AcceptsReturn = true;
            this.txtP1.AccessibleDescription = "";
            this.txtP1.AccessibleName = "";
            this.txtP1.BackColor = System.Drawing.SystemColors.Window;
            this.txtP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtP1.Location = new System.Drawing.Point(269, 162);
            this.txtP1.MaxLength = 30;
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(220, 24);
            this.txtP1.TabIndex = 2;
            this.txtP1.Text = "Nombre de Player 1";
            this.txtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 5;
            // 
            // txtP2
            // 
            this.txtP2.AcceptsReturn = true;
            this.txtP2.AccessibleDescription = "";
            this.txtP2.AccessibleName = "";
            this.txtP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtP2.Location = new System.Drawing.Point(269, 213);
            this.txtP2.MaxLength = 30;
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(220, 24);
            this.txtP2.TabIndex = 6;
            this.txtP2.Text = "Nombre de Player 2";
            this.txtP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtP2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(147, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 7;
            // 
            // picbox2
            // 
            this.picbox2.Location = new System.Drawing.Point(81, 55);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(60, 24);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox2.TabIndex = 4;
            this.picbox2.TabStop = false;
            // 
            // picbox1
            // 
            this.picbox1.Location = new System.Drawing.Point(81, 25);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(60, 24);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox1.TabIndex = 3;
            this.picbox1.TabStop = false;
            // 
            // Imgstart
            // 
            this.Imgstart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Imgstart.Image = global::Juego_ping_pong.Properties.Resources.Comienzo;
            this.Imgstart.Location = new System.Drawing.Point(257, 256);
            this.Imgstart.Name = "Imgstart";
            this.Imgstart.Size = new System.Drawing.Size(246, 93);
            this.Imgstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imgstart.TabIndex = 1;
            this.Imgstart.TabStop = false;
            this.Imgstart.Click += new System.EventHandler(this.comienzo_click);
            // 
            // Imgfondo1
            // 
            this.Imgfondo1.Image = ((System.Drawing.Image)(resources.GetObject("Imgfondo1.Image")));
            this.Imgfondo1.Location = new System.Drawing.Point(-1, -4);
            this.Imgfondo1.Name = "Imgfondo1";
            this.Imgfondo1.Size = new System.Drawing.Size(789, 400);
            this.Imgfondo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imgfondo1.TabIndex = 0;
            this.Imgfondo1.TabStop = false;
            // 
            // bStartHost
            // 
            this.bStartHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStartHost.Location = new System.Drawing.Point(48, 157);
            this.bStartHost.Name = "bStartHost";
            this.bStartHost.Size = new System.Drawing.Size(143, 61);
            this.bStartHost.TabIndex = 8;
            this.bStartHost.Text = "Start Host";
            this.bStartHost.UseVisualStyleBackColor = true;
            this.bStartHost.Click += new System.EventHandler(this.bStartHost_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tStatus
            // 
            this.tStatus.Name = "tStatus";
            this.tStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // gMultiplayer
            // 
            this.gMultiplayer.Controls.Add(this.groupBox2);
            this.gMultiplayer.Controls.Add(this.bStartHost);
            this.gMultiplayer.Location = new System.Drawing.Point(509, 118);
            this.gMultiplayer.Name = "gMultiplayer";
            this.gMultiplayer.Size = new System.Drawing.Size(234, 231);
            this.gMultiplayer.TabIndex = 18;
            this.gMultiplayer.TabStop = false;
            this.gMultiplayer.Visible = false;
            // 
            // bMultiPlayer
            // 
            this.bMultiPlayer.Location = new System.Drawing.Point(592, 89);
            this.bMultiPlayer.Name = "bMultiPlayer";
            this.bMultiPlayer.Size = new System.Drawing.Size(75, 23);
            this.bMultiPlayer.TabIndex = 19;
            this.bMultiPlayer.Text = "MultiPlayer";
            this.bMultiPlayer.UseVisualStyleBackColor = true;
            this.bMultiPlayer.Click += new System.EventHandler(this.bMultiPlayer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bConnect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtServerIP);
            this.groupBox2.Location = new System.Drawing.Point(10, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 124);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(137, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "&Server IP:";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(73, 88);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(58, 23);
            this.bConnect.TabIndex = 13;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "&Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(73, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 11;
            this.txtName.Text = "Luis";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(73, 59);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(128, 20);
            this.txtServerIP.TabIndex = 12;
            this.txtServerIP.Text = "192.168.1.19";
            // 
            // Ping_Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 389);
            this.Controls.Add(this.bMultiPlayer);
            this.Controls.Add(this.gMultiplayer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.Imgstart);
            this.Controls.Add(this.Imgfondo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Ping_Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping_Pong";
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgfondo1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gMultiplayer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imgfondo1;
        private System.Windows.Forms.PictureBox Imgstart;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.PictureBox picbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bStartHost;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tStatus;
        private System.Windows.Forms.GroupBox gMultiplayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button bMultiPlayer;
    }
}

