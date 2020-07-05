using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using System.Net;
using System.Net.Sockets;

namespace Juego_ping_pong
{
    public partial class Juego : Form
    {
        //Parametros socket
        public Socket clientSocket;
        public string strName;
        public byte[] byteData = new byte[1024];
        SocketFiles.Data msgToSend;
        SocketFiles.Data msgReceived;
        bool isMultiplayer;
        bool isServer;
        string player;
        string serverIP;

        //Parametros del formulario
        private const int AnchoPantalla = 800;
        private const int AlturaPantalla = 428;
        //Velocidad base y Maxima
        private const int BaseVelPelota = 2;
        private int Nivel = 7;
        //Elementos para Jugar
        private PongOrigen Jugador1;
        private PongOrigen Jugador2;
        private PongOrigen Set1;
        private PongOrigen Set2;
        private PongBola Bola;
        //Pantalla del juego y variable aleatoria para movimiento de pelota
        private PongCubo PantallaPequeña;
        private Random random;
        //Puntaje de los jugadores
        private int PuntuacionJ1;
        private int PuntuacionJ2;
        private int SetGanados1;
        private int SetGanados2;
     

        public Juego(bool IsmultiPlayer, bool isserver, string playerName, string serveriP)
        {
            InitializeComponent();
            ClientSize = new Size(AnchoPantalla, AlturaPantalla);
            Inicializar();
            Load += Juego_Load;
            //pbJugador2.BackColor = Color.Transparent;
            //pbJugador1.BackColor = Color.Transparent;
            //pbBola.BackColor = Color.Transparent;
            label1.Parent = pfondo;
            label2.Parent = pfondo;
            lblScore1.Parent = pfondo;
            lblScore2.Parent = pfondo;
            pbBola.Parent = pfondo;
            pbJugador1.Parent = pfondo;
            pbJugador2.Parent = pfondo;
            pbSet1.Parent = pfondo;
            pbSet2.Parent = pfondo;

            isMultiplayer = IsmultiPlayer;
            isServer = isserver;
            player = playerName;
            serverIP = serveriP;
        }
        #region Metodos del juego

        private void ComenzarJuego()
        {
            _isGameRunning = true;
            ResetearBola();
            pbPantallaPequeña.Hide();
        }
        #endregion
        #region Eventos
        private void Juego_Load(object sender, EventArgs e)
        {
            CargarGraficos();

            if(isMultiplayer==true && isServer==false)
            {
                try
                {
                    CheckForIllegalCrossThreadCalls = false;
                    strName = player;
                    this.Text = strName;
                    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    IPAddress ipAddress = IPAddress.Parse(serverIP);
                    //Server is listening on port 1000
                    IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 1000);

                    //Connect to the server
                    clientSocket.BeginConnect(ipEndPoint, new AsyncCallback(OnConnect), null);

                    MessageBox.Show("Connected");

                    msgToSend = new SocketFiles.Data();
                    msgToSend.cmdCommand = SocketFiles.Command.List;
                    msgToSend.strName = strName;
                    msgToSend.strMessage = null;

                    byteData = msgToSend.ToByte();

                    clientSocket.BeginSend(byteData, 0, byteData.Length, SocketFlags.None, new AsyncCallback(OnSend), null);

                    byteData = new byte[1024];

                    //Start listening to the data asynchronously
                    clientSocket.BeginReceive(byteData,
                                               0,
                                               byteData.Length,
                                               SocketFlags.None,
                                               new AsyncCallback(OnReceive),
                                               null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void tmrTiempoActualizar_Tick(object sender, EventArgs e)
        {
            ActualizarEscena();

        }
        private void tmrTiempoDibujar_Tick(object sender, EventArgs e)
        {
            DibujarEscena();

        }
        #endregion
        #region EngineMethods
        private void Inicializar()
        {
            random = new Random();
            Jugador1 = new PongOrigen();
            Set1 = new PongOrigen();
            Set2 = new PongOrigen();
            Jugador2 = new PongOrigen
            {
                Posicion = new Point(AnchoPantalla - 3, AlturaPantalla / 2)
            };
            Bola = new PongBola
            {
                Velocidad = new Point(2, 5)
            };
            PantallaPequeña = new PongCubo();
            PantallaPequeña.Posicion = new Point(0, 0);
            PantallaPequeña.Ancho = AnchoPantalla;
            PantallaPequeña.Altura = AlturaPantalla;
        }
        private void CargarGraficos()
        {
            pbJugador1.Load("RacketLeft.png");
            Jugador1.Texturas = pbJugador1;

            pbJugador2.Load("RacketRigth.png");
            Jugador2.Texturas = pbJugador2;

            pbSet1.Load("Set0.png");
            Set1.Texturas = pbSet1;

            pbSet2.Load("Set0.png");
            Set2.Texturas = pbSet2;

            pbBola.Load("bola.png");
            Bola.Texturas = pbBola;

            pbPantallaPequeña.Load("Logo.png");
            PantallaPequeña.Texturas = pbPantallaPequeña;
        }
        private void ActualizarEscena()
        {
            if (_isGameRunning)
            {
                ActualizarJugador();
                Bola.Actualizar();

                CheckColisionMuro();
                CheckMuroAfuera();
                CheckColisionRaqueta();
            }
            else if (MouseButtons == MouseButtons.Left)
            {
                ComenzarJuego();
            }
        }
        private bool _isGameRunning;
        private void DibujarEscena()
        {
            if (_isGameRunning)
            {
                Jugador1.Dibujar();
                Jugador2.Dibujar();
                Bola.Dibujar();
            }
            else
            {
                PantallaPequeña.Dibujar();
            }
        }
        #endregion
        #region Mechanics

        private int ActualY;

        private void ActualizarJugador()
        {
            int JugadorX = 0 + 30;
            int playerY = PointToClient(MousePosition).Y;
            Jugador1.Posicion = new Point(JugadorX, playerY);

            if (Jugador1.Texturas.Bottom >= AlturaPantalla)
            {
                Jugador1.Posicion = new Point(JugadorX, AlturaPantalla - Jugador1.Origen.Y - 1);
            }
            else if (Jugador1.Texturas.Top <= 0)
            {
                Jugador1.Posicion = new Point(JugadorX, Jugador1.Origen.Y + 1);
            }
            if (Keyboard.IsKeyDown(Key.S)) //movimiento con s hacia abajo
            {
                if (Jugador2.Texturas.Bottom >= AlturaPantalla)
                {
                    ActualY -= 0;
                }
                else
                {
                    ActualY += 30;
                }
                Jugador2.Posicion = new Point(AnchoPantalla - 30, ActualY);
            }
            else if (Keyboard.IsKeyDown(Key.W)) //movimiento con w hacia abajo
            {
                if (Jugador2.Texturas.Top <= 0)
                {
                    ActualY += 5;
                }
                else
                {
                    ActualY -= 30;
                }
                int Jugador2X = AnchoPantalla - 30;
                int Jugador2Y = ActualY;
                Jugador2.Posicion = new Point(Jugador2X, Jugador2Y);
            }
        }
        private void ResetearBola()
        {
            Nivel = 7;
            int VelocidadY = GenerateBallY();
            int VelocidadX = GenerarBolaX();
            Bola.Posicion = new Point(AnchoPantalla / 2, AlturaPantalla / 2);
            Bola.Velocidad = new Point(VelocidadX, VelocidadY);

            ActualBolaX = VelocidadX;
        }
        private int GenerarBolaX()
        {
            Nivel += 1;
            int velocityX = Nivel;
            if (random.Next(2) == 0)
            {
                velocityX *= -1;
            }
            return velocityX;
        }
        private int GenerateBallY()
        {
            Nivel += (int).5;
            int velocityY = random.Next(0, Nivel);
            if (random.Next(2) == 0)
            {
                velocityY *= -1;
            }
            return velocityY;
        }
        #endregion
        #region Collision
        private int ActualBolaX;
        private void CheckColisionMuro()
        {
            if (pbBola.Bottom >= AlturaPantalla)
            {
                Bola.Velocidad = new Point(ActualBolaX, -BaseVelPelota);
            }
            else if (pbBola.Top <= 0)
            {
                Bola.Velocidad = new Point(ActualBolaX, BaseVelPelota);
            }
        }
        private void CheckMuroAfuera()
        {
            if (pbBola.Left < 0)
            {
                ResetearBola();
                PuntuacionJ2 += 1;
                //lblScore2.Text = PuntuacionJ2.ToString();
                PuntosLimite();
                Set();
            }
            else if (pbBola.Right > AnchoPantalla)
            {
                ResetearBola();
                PuntuacionJ1 += 1;
                //lblScore1.Text = PuntuacionJ1.ToString();
                PuntosLimite();
                Set();
            }
        }
        private void CheckColisionRaqueta()
        {
            if (Bola.EsquIzquierda.X < Jugador1.EsqDerecha.X &&
                Bola.EsqInferiorIzquierda.Y > Jugador1.EsqDerecha.Y &&
                Bola.EsquIzquierda.Y < Jugador1.EsqInferiorDerecha.Y)
            {
                ActualBolaX = GenerarBolaX();
                if (ActualBolaX < 0)
                {
                    ActualBolaX *= -1;
                }
                Bola.Velocidad = new Point(ActualBolaX, GenerateBallY());
            }
            if (Bola.EsqDerecha.X > Jugador2.EsquIzquierda.X &&
                Bola.EsqInferiorDerecha.Y > Jugador2.EsquIzquierda.Y &&
                Bola.EsqDerecha.Y < Jugador2.EsqInferiorIzquierda.Y)
            {
                ActualBolaX = GenerarBolaX();
                if (ActualBolaX > 0)
                {
                    ActualBolaX *= -1;
                }
                Bola.Velocidad = new Point(ActualBolaX, GenerateBallY());
            }
        }
        #endregion
        #region Puntos & Set´s
        private void PuntosLimite()
        {
            switch (PuntuacionJ1)
            {
                case 1:
                    lblScore1.Text = "15";
                    break;
                case 2:
                    lblScore1.Text = "30";
                    break;
                case 3:
                    lblScore1.Text = "40";
                    break;
                case 4:
                    PuntuacionJ1 = 0;
                    PuntuacionJ2 = 0;
                    lblScore1.Text = "0";
                    lblScore2.Text = "0";
                    SetGanados1 += 1;
                    //MessageBox.Show(SetGanados1.ToString());
                    break;
            }
            switch (PuntuacionJ2)
            {
                case 1:
                    lblScore2.Text = "15";
                    break;
                case 2:
                    lblScore2.Text = "30";
                    break;
                case 3:
                    lblScore2.Text = "40";
                    break;
                case 4:
                    PuntuacionJ1 = 0;
                    PuntuacionJ2 = 0;
                    lblScore1.Text = "0";
                    lblScore2.Text = "0";
                    SetGanados2 += 1;
                    //MessageBox.Show(SetGanados2.ToString());
                    break;
            }
        }
        

        private void Set()
        {
            switch (SetGanados1)
            {
                case 1:
                    pbSet1.Load("Set1-0.png");
                    Set1.Texturas = pbSet1;
                    break;
                case 2:
                    pbSet1.Load("Set2-0.png");
                    Set1.Texturas = pbSet1;
                    break;
                case 3:
                    pbSet1.Load("Set3-0.png");
                    Set1.Texturas = pbSet1;
                    break;
                case 4:
                    pbSet1.Load("Set4-0.png");
                    Set1.Texturas = pbSet1;
                    this.tmrTiempoActualizar.Stop();
                    this.tmrTiempoDibujar.Stop();
                    MessageBox.Show("Felicidades " + ClasePublica.NombrePlayer1 + " Usted ha ganado.");
                    this.Close();
                    break;
            }

            switch (SetGanados2)
            {
                case 1:
                    pbSet2.Load("Set0-1.png");
                    Set2.Texturas = pbSet2;
                    break;
                case 2:
                    pbSet2.Load("Set0-2.png");
                    Set2.Texturas = pbSet2;
                    break;
                case 3:
                    pbSet2.Load("Set0-3.png");
                    Set2.Texturas = pbSet2;
                    break;
                case 4:
                    pbSet2.Load("Set0-4.png");
                    Set2.Texturas = pbSet2;
                    this.tmrTiempoActualizar.Stop();
                    this.tmrTiempoDibujar.Stop();
                    MessageBox.Show("Felicidades " + ClasePublica.NombrePlayer2 + " Usted ha ganado.");
                    this.Close();
                    break;
            }
            #endregion

        }


        private void OnSend(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndSend(ar);
                strName = player;
                DialogResult = DialogResult.OK;

                //tStatus.Text = "Connected to Server!";
                //tStatus.ForeColor = Color.DarkGreen;
                ////Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SGSclient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnConnect(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndConnect(ar);

                //We are connected so we login into the server
                msgToSend = new SocketFiles.Data();
                msgToSend.cmdCommand = SocketFiles.Command.Login;
                msgToSend.strName = player;
                msgToSend.strMessage = null;

                byte[] b = msgToSend.ToByte();

                //Send the message to the server
                clientSocket.BeginSend(b, 0, b.Length, SocketFlags.None, new AsyncCallback(OnSend), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SGSclient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndReceive(ar);

                msgReceived = new SocketFiles.Data(byteData);
                //Accordingly process the message received
                switch (msgReceived.cmdCommand)
                {
                    case SocketFiles.Command.Login:
                        //lstChatters.Items.Add(msgReceived.strName);
                        break;

                    case SocketFiles.Command.Logout:
                        //lstChatters.Items.Remove(msgReceived.strName);
                        break;

                    case SocketFiles.Command.Message:
                        //TODO
                        break;

                    case SocketFiles.Command.List:

                        //lstChatters.Items.AddRange(msgReceived.strMessage.Split('*'));
                        //lstChatters.Items.RemoveAt(lstChatters.Items.Count - 1);
                        //txtChatBox.Text += "<<<" + strName + " Ha entrado al Juego>>>\r\n";
                        break;
                }

                //if (msgReceived.strMessage != null && msgReceived.cmdCommand != Command.List)
                //    txtChatBox.Text += msgReceived.strMessage + "\r\n";

                byteData = new byte[1024];

                clientSocket.BeginReceive(byteData,0,byteData.Length,SocketFlags.None,new AsyncCallback(OnReceive),null);

            }
            catch (ObjectDisposedException)
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SGSclientTCP: " + strName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pfondo_Click(object sender, EventArgs e)
        {
            if (tmrTiempoActualizar.Enabled ==true)
            {
                tmrTiempoActualizar.Stop();
                tmrTiempoDibujar.Stop();
            }
            else
            {
                tmrTiempoActualizar.Start();
                tmrTiempoDibujar.Start();
            }
        }
    }
}



