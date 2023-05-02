using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Pruebas.Form1;

namespace Pruebas
{
    public partial class Form1 : Form
    {
        public static int puntos;
        public static int tiempo;
        private Marcador marcador;
        private Serpiente serpiente;
        private Segmento cabeza;
        private Segmento cola;
        public const Keys arriba = Keys.Up;
        public const Keys abajo = Keys.Down;
        public const Keys izquierda = Keys.Left;
        public const Keys derecha = Keys.Right;
        public Keys direccion = Keys.Right;
        public Form1()
        {
            InitializeComponent();
            marcador = new Marcador();
            Controls.Add(marcador.MiLabel);
            //cabeza = new Segmento(Color.Green,200,200);
            //Controls.Add(cabeza.MiPictureBox);
            serpiente = new Serpiente(Controls);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Marcador
        {
            public Label MiLabel = new Label();
            public Marcador()
            {
                MiLabel.Font = new Font("Courier", 18);
                MiLabel.AutoSize = true;
                MiLabel.Left = 10;
                MiLabel.Top = 20;
                MiLabel.Text = "Puntos: " + Convert.ToString(puntos) + "\n" + "Tiempo de vida: " + Convert.ToString(tiempo);
            }
        }
        public class Serpiente
        {
            private int posx {get;set;}
            private int posy { get; set; }
            private int posxanterior { get; set; }
            private int posyanterior { get; set; }
            private int separacion = 25;
            private int n_cola = 1;
            private Segmento cabeza;
            private Control.ControlCollection controls;
            public List<Segmento> cola = new List<Segmento>();

            public Serpiente(Control.ControlCollection c)
            {
                posx = 200;
                posy = 200;
                cabeza = new Segmento(Color.Green, posx, posy);
                cola.Add(cabeza);
                cola.Add(new Segmento(Color.Blue, posx - separacion * n_cola, posy));
                n_cola++;
                cola.Add(new Segmento(Color.Blue, posx - separacion * n_cola, posy));
                n_cola++;
                foreach (Segmento segmento in cola)
                {
                    c.Add(segmento.MiPictureBox);
                }
                c.Add(cabeza.MiPictureBox);

            }
            public void MoverSerpiente (Keys direccion)
            {
                if (direccion == arriba)
                {
                    cola[0].CambiaPosY(-5);
                }
                else if (direccion == abajo)
                {
                    cola[0].CambiaPosY(5);
                }
                else if (direccion == izquierda)
                {
                    cola[0].CambiaPosX(-5);
                }
                else if (direccion == derecha)
                {
                    cola[0].CambiaPosX(5);
                }
            }


        }

        public class Segmento 
        {
            public PictureBox MiPictureBox = new PictureBox();

            public Segmento(Color color, int posicionx, int posiciony)
            {
                MiPictureBox.BackColor = color;
                MiPictureBox.Top= posiciony;
                MiPictureBox.Left = posicionx;
                MiPictureBox.Width = 25;
                MiPictureBox.Height = 25;
            }
            public void CambiaPosX(int n)
            {
                MiPictureBox.Left = MiPictureBox.Left + n;
            }
            public void CambiaPosY(int n) 
            { 
                MiPictureBox.Top = MiPictureBox.Top + n;
            }
            public void Actualizar()
            {
                MiPictureBox.Refresh();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e, Keys direccion)
        {
            switch (e.KeyCode)
            {
                case arriba:
                    direccion = arriba;
                    break;
                case abajo:
                    direccion = abajo;
                    break;
                case izquierda:
                    direccion = izquierda;
                    break;
                case derecha:
                    direccion = derecha;
                    break;
                default:
                    this.direccion = direccion;
                    break;

            }

        }

        //private void Form1_Paint(object sender, PaintEventArgs e, Control.ControlCollection c, List<Segmento>  cola)
        //{
            //foreach (Segmento segmento in cola)
            //{
                //segmento.Actualizar();
            //}
            //this.Invalidate();
        //}
    }
}
