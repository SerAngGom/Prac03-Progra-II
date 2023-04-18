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
        public Form1()
        {
            InitializeComponent();
            marcador = new Marcador();
            Controls.Add(marcador.MiLabel);
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
    }
}
