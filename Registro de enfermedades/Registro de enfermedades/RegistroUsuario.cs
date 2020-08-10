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
    public partial class RegistroUsuario_2 : Form
    {   
       public static string user,pass;
        public static string admin = "admin", apass = "123456";

        private void btnregresar_Click(object sender, EventArgs e)
        {
            Inicio_1 frmregistro = new Inicio_1();
            frmregistro.Visible = true;
            this.Hide();
        }

        public RegistroUsuario_2()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btnRegistrar2, "Registrar");
        }

        private void btnRegistrar2_Click(object sender, EventArgs e)
        {
            Inicio_1 frminicio = new Inicio_1();
            user = txtNombre2.Text;
            try
            {
                if (txtPass2.Text == txtPassConf2.Text)
                {
                    pass = txtPass2.Text;
                    MessageBox.Show("Usuario registrado con exito");
                    frminicio.Visible = true;
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al registrar usuario", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre2.Clear();
                txtPass2.Clear();
                txtPassConf2.Clear();
                txtNombre2.Focus();
            }

        }
    }
}
