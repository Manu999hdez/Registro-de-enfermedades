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
    public partial class Inicio_1 : Form
    {
        public static string usuarioAdmitido;
        public Inicio_1()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btnRegistrar1, "Registrarse");
            tt.SetToolTip(btnIngresar1, "Iniciar Sesion");
            tt.SetToolTip(btnSalir1, "Salir"); 
            tt.SetToolTip(btnabout, "Acerca de....");
        }

        private void btnRegistar1_Click(object sender, EventArgs e)
        {
            
            RegistroUsuario_2 frmregistro = new RegistroUsuario_2();
            frmregistro.Visible = true;
            this.Hide();
            
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Saliendo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (result == DialogResult.No)
            {

            }                 
  
        }

        private void btnIngresar1_Click(object sender, EventArgs e)
        {
            if (txtNombre1.Text == RegistroUsuario_2.user && txtPass1.Text == RegistroUsuario_2.pass)
            {
                MessageBox.Show("Ha ingresado con exito", "Alerta", MessageBoxButtons.OK);
                OpcionesRegistros frmOpciones= new OpcionesRegistros();
                frmOpciones.Visible = true;
                this.Close();
                usuarioAdmitido = "user";
            }
            else if (txtNombre1.Text == RegistroUsuario_2.admin && txtPass1.Text == RegistroUsuario_2.apass)
            {
                MessageBox.Show("Ha ingresado con exito como Administrador", "Alerta", MessageBoxButtons.OK);
                OpcionesRegistros frmOpciones = new OpcionesRegistros();
                frmOpciones.Visible = true;
                this.Close();
                usuarioAdmitido = "admin";
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            AboutBox1 frmabout = new AboutBox1();
            frmabout.Visible = true;
            this.Close();
        }
    }
}
