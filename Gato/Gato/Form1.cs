using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gato
{

    public partial class Form1 : Form
    {
        public int jugadoractivo;
        public Jugador jugador1;
        public Jugador jugador2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        public void CambiarBoton(Button btn, int fila, int columna)
        {
            if (jugadoractivo == 0)
            {
                btn.Text = "X";
                jugador1.Tablero = AgregarPuntuacion(fila, columna, jugador1.Tablero);
                if(VerificarGanador(jugador1.Tablero) == true)
                {
                    jugador1.Puntuacion++;
                    lblp1.Text = jugador1.Puntuacion.ToString();
                    ReiniciarBotones();
                    return;
                }
                else
                {
                    jugadoractivo = 1;
                    label1.Text = "Turno del Jugador 2";
                }

            }
            else
            {
                btn.Text = "O";
                jugador2.Tablero = AgregarPuntuacion(fila, columna, jugador2.Tablero);
                if (VerificarGanador(jugador2.Tablero) == true)
                {
                    jugador2.Puntuacion++;
                    lblp2.Text = jugador2.Puntuacion.ToString();
                    ReiniciarBotones();
                    return;
                }
                else
                {
                    jugadoractivo = 0;
                    label1.Text = "Turno del Jugador 1";
                }
            }
            btn.Enabled = false;
        }


        public bool[,] AgregarPuntuacion(int fila, int columna, bool[,] tablero)
        {
            tablero[fila, columna] = true;
            return tablero;

        }

        public static bool VerificarGanador(bool[,] tablero)
        {
            bool victoria = false;
                    
           
            if(Vertical(tablero) == true)
            {
                victoria = true;
            }
            else if (Horizontal(tablero) == true)
            {
                victoria = true;
            }
            else if(Cruzado(tablero) == true)
            {
                victoria = true;
            }
                    
            return victoria;
        }

        public static bool Vertical(bool[,] tablero)
        {
            bool victoria = false;

            for(int a=0;a<2;a++)
            {
                if(tablero[a,0] == true && tablero[a,1] == true && tablero[a,2] == true)
                {
                    victoria = true;
                    break;
                }
            }

            return victoria;
        }

        public static bool Horizontal(bool[,] tablero)
        {
            bool victoria = false;

            for (int a = 0; a < 2; a++)
            {
                if (tablero[0, a] == true && tablero[1, a] == true && tablero[2, a] == true)
                {
                    victoria = true;
                    break;
                }
            }

            return victoria;
        }

        public static bool Cruzado(bool[,] tablero)
        {
            bool victoria = false;

            if (tablero[0, 0] == true && tablero[1, 1] == true && tablero[2, 2])
            {
                victoria = true;
 
            }
            else if (tablero[0, 2] == true && tablero[1, 1] == true && tablero[2, 0])
            {
                victoria = true;
            }
          
            return victoria;
        }

        public bool[,] InicializarFalso(bool[,] tablero)
        {
            for(int a=0;a<2; a++)
            {
                for(int b=0;b<2;b++)
                {
                    tablero[a, b] = false;
                }
            }
            return tablero;
        }

        public void Inicializar()
        {
            bool[,] tablero_inicial1 = new bool[3, 3];
            tablero_inicial1 = InicializarFalso(tablero_inicial1);
            bool[,] tablero_inicial2 = new bool[3, 3];
            tablero_inicial2 = InicializarFalso(tablero_inicial2);
            jugador1 = new Jugador(0, tablero_inicial1);
            jugador2 = new Jugador(0, tablero_inicial2);
            jugadoractivo = 0;
        }

        public void ReiniciarBotones()
        {
            label1.Text = "Turno del Jugador 1";
            jugadoractivo = 0;

            jugador1.Tablero = InicializarFalso(jugador1.Tablero);
            jugador2.Tablero = InicializarFalso(jugador2.Tablero);


            bt1.Text = "-";
            bt1.Enabled = true;
            bt2.Text = "-";
            bt2.Enabled = true;
            bt3.Text = "-";
            bt3.Enabled = true;
            bt4.Text = "-";
            bt4.Enabled = true;
            bt5.Text = "-";
            bt5.Enabled = true;
            bt6.Text = "-";
            bt6.Enabled = true;
            bt7.Text = "-";
            bt7.Enabled = true;
            bt8.Text = "-";
            bt8.Enabled = true;
            bt9.Text = "-";
            bt9.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ReiniciarBotones();

        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            CambiarBoton(bt1, 0, 0);
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            CambiarBoton(bt2, 0, 1);
        }

        private void Bt3_Click(object sender, EventArgs e)
        {
            CambiarBoton(bt3, 0, 2);
        }

        private void Bt4_Click(object sender, EventArgs e)
        {
            CambiarBoton(bt4, 1, 0);
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            CambiarBoton(bt5, 1, 1);
        }

        private void Bt6_Click(object sender, EventArgs e)
        {
            CambiarBoton(bt6, 1, 2);
        }

        private void Bt7_Click(object sender, EventArgs e)
        {
            CambiarBoton(bt7, 2, 0);
        }

        private void Bt8_Click(object sender, EventArgs e)
        {
            CambiarBoton(bt8, 2, 1);
        }

        private void Bt9_Click(object sender, EventArgs e)
        {
            CambiarBoton(bt9, 2, 2);
        }
    }
    public class Jugador
    {
        public int Puntuacion;
        public bool[,] Tablero;

        public Jugador(int puntuacion,bool[,] tablero)
        {
            Puntuacion = puntuacion;
            Tablero = tablero;
        }

    }


    


}
