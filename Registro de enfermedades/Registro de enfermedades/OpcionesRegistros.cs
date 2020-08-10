using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Registro_de_enfermedades
{
    public partial class OpcionesRegistros : Form
    {
        private SqlConnection conn;
        private string sCn;
        public OpcionesRegistros()
        {
            InitializeComponent();
            Conexion.conectar();
            sCn = Conexion.cadena;
            conn = new SqlConnection(sCn);
            var tt = new ToolTip();
            tt.SetToolTip(btnGenerar, "Generar Base de Datos");
            tt.SetToolTip(button1, "Registros de pacientes");
            tt.SetToolTip(btnVolver, "Cerrar sesion");
            tt.SetToolTip(button2, "Mostrar totales");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroPacientes frmPacientes = new RegistroPacientes();
            frmPacientes.Visible = true;
            this.Hide();
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
      
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=" + Conexion.server + ";" + "database =master; integrated security = yes");
            string crear = "CREATE DATABASE " + "RegistroEnfermedades";

            string tablaEnf = "USE RegistroEnfermedades;" + "CREATE TABLE Enfermedades(" +
                "IdEnfermedad int NOT NULL," + "IdPersona int IDENTITY(1,1) NOT NULL," + "Enfermedad varchar(150)," + "Clasificacion varchar (200)," +
                "CONSTRAINT PK_IdEnfermedad PRIMARY KEY(IdEnfermedad)," +
                "CONSTRAINT FK_IdPersona FOREIGN KEY(IdPersona) REFERENCES Personas(IdPersona));";
               

            string tablaPersonas = "USE RegistroEnfermedades;" + "CREATE TABLE Personas(" +
                "IdPersona int IDENTITY(1,1) NOT NULL," + "Edad varchar (40)," + "Sexo varchar(10)," + "Fecha varchar(150) "+
                "CONSTRAINT PK_idpersona PRIMARY KEY(IdPersona));";


            string tablaAspectos = "USE RegistroEnfermedades;" + "CREATE TABLE Aspectos(" +
                "IdAspecto int NOT NULL," + "IdEnfermedad int NOT NULL," + "IdPersona int IDENTITY(1,1) NOT NULL," +
                "Aspecto varchar(275)," + "CONSTRAINT PK_IdAspecto PRIMARY KEY(IdAspecto)," +
                "CONSTRAINT FK_idenfermedad FOREIGN KEY(IdEnfermedad) REFERENCES Enfermedades(IdEnfermedad) " +
                "ON DELETE CASCADE " +
                "ON UPDATE CASCADE," +
                "CONSTRAINT FK2_persona FOREIGN KEY(IdPersona) REFERENCES Personas(IdPersona));";

           

            SqlCommand cmdbd= new SqlCommand(crear,cnn);
            SqlCommand cmdt1 = new SqlCommand(tablaEnf,cnn);
            SqlCommand cmdt2 = new SqlCommand(tablaPersonas,cnn);
            SqlCommand cmdt3 = new SqlCommand(tablaAspectos,cnn);
       
           
            try
            {
                cnn.Open();
                cmdbd.ExecuteNonQuery();
                cmdt2.ExecuteNonQuery();
                cmdt1.ExecuteNonQuery();
                cmdt3.ExecuteNonQuery();
        
                cnn.Close();
                MessageBox.Show("Base de datos creada con exito", "Base Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al crear la base", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicio_1 frminicio = new Inicio_1();
            frminicio.Visible = true;
            this.Close();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
