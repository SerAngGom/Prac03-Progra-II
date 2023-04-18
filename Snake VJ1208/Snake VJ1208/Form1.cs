using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_VJ1208
{
    public partial class Form1 : Form
    {
        private const int anchoEscenario = 735;
        private const int altoEscenario = 500;
        private Marcador marcador;
        private Serpiente serpiente;
        private Comida comida;
        private const Keys arriba = Keys.Up;
        private const Keys abajo = Keys.Down;
        private const Keys izquierda = Keys.Left;
        private const Keys derecha = Keys.Right;
        public static int puntos = 0;
        public static int tiempo = 0;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.SupportsTransparentBackColor,true);
            this.Text = "Serpiente VJ1208 ...";
            this.Width = anchoEscenario;
            this.Height = altoEscenario;
            this.BackColor = Color.DarkRed;
            serpiente = new Serpiente();
            Controls.Add( Serpiente.MiPictureBox );
            comida = new Comida();
            Controls.Add( Comida.MiPictureBox );
            marcador = new Marcador();
            Controls.Add( Marcador.MiLabel );
            marcador.MiLabel.SendToBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class Marcador
        {
            private Label MiLabel = new Label();
            public Marcador()
            {
                MiLabel.Font = new Font("Courier", 18);
                MiLabel.AutoSize= true;
                MiLabel.Location = new Point(200, 200);
                MiLabel.Text = "Puntos: " + Convert.ToString(puntos) + "\n" + "Tiempo de vida: " + Convert.ToString(tiempo);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case arriba:break;
                case abajo:
                case izquierda:
                case derecha:break;
                default:
            }
        }
    }
}
