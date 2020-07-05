using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Juego_ping_pong
{
    public partial class Ping_Pong : Form
    {
        bool isServer=false;

        int p1 = 0, p2=0;
        public Ping_Pong()
        {
            InitializeComponent();
        }


        private void comienzo_click(object sender, EventArgs e)
        {
            if(p1 == 1 || p2 == 1)
            {
                Juego frm = new Juego(gMultiplayer.Visible, isServer, txtName.Text, txtServerIP.Text);
                frm.Show();
            }

        }  
        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.txtP1.Text != "Nombre de Player 1")
                {
                    if (this.txtP1.Text == null || this.txtP1.Text == "")
                    {
                        MessageBox.Show("Por favor ingrese un usuario.");
                    }
                    else
                    { 
                        string t = (string.Format(txtP1.Text));

                        label1.Text = t.ToString();

                        txtP1.Text = "";

                        picbox1.Image = Properties.Resources.conectado;

                        p1 = 1;

                        this.txtP1.Enabled = false;
                        ClasePublica.NombrePlayer1 = this.label1.Text;
                    }
                }
            }
        }

        private void bStartHost_Click(object sender, EventArgs e)
        {
            try
            {
                isServer = true;
                SocketFiles.SocketServer SS = new SocketFiles.SocketServer();
                tStatus.Text = "Server started!";
                tStatus.ForeColor = Color.DarkGreen;
                
                //comienzo_click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bMultiPlayer_Click(object sender, EventArgs e)
        {
            if(gMultiplayer.Visible==false)
            {
                gMultiplayer.Visible = true;
            }
            else
            {
                gMultiplayer.Visible = false;
            }
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            isServer = false;
            comienzo_click(sender, e);
        }

        private void txtP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (this.txtP2.Text != "Nombre de Player 2")
                {
                    if (this.txtP2.Text == null || this.txtP2.Text == "")
                    {
                        MessageBox.Show("Por favor ingrese un usuario.");
                        this.txtP1.Text = "Nombre de Player 2";
                    }
                    else
                    {
                        string t = (string.Format(txtP2.Text));

                        label2.Text = t.ToString();

                        txtP2.Text = "";

                        picbox2.Image = Properties.Resources.conectado;

                        p2 = 1;

                        this.txtP2.Enabled = false;
                        ClasePublica.NombrePlayer2 = this.label2.Text;
                    }
                }
            }
        }
    }
}
