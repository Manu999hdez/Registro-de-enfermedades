using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_enfermedades
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }
        public int timeLeft { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLeft = 50;
            tiempo.Start();

        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (timeLeft >0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                tiempo.Stop();
                Inicio_1 frminicio = new Inicio_1();
                frminicio.Visible = true;
                this.Hide();
            }
        }
    }
}
