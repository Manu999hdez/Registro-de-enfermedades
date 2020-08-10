using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Registro_de_enfermedades
{
    public partial class RegistroPacientes : Form
    {
        private int indice = 0;
        private SqlConnection conn;
        private SqlCommand insert1,insert2,cmd;
        private string sCn;
        public List<int> IdsEnf = new List<int>();
        private SqlDataAdapter adapt;
        private void actualizarGrid()
        {
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Enfermedades", conn);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            
        }
       
        public RegistroPacientes()
        {
            InitializeComponent();
            Conexion.conectar();
            sCn = Conexion.cadena;
            conn = new SqlConnection(sCn);
            var tt = new ToolTip();
            tt.SetToolTip(button1, "Guardar Registro");
            tt.SetToolTip(button1, "Eliminar Registro");
            tt.SetToolTip(button1, "Editar Registro");
            tt.SetToolTip(btnvolver, "Regresar al menu");
        }
        Paciente persona = new Paciente();
        Enfermedad enf = new Enfermedad();
        private void rbtnSospecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSospecha.Checked == true)
            {
                ListEnf.Items.Clear();
                ListEnf.Items.Add("Sospecha de Difteria"); ListEnf.Items.Add("Sospecha de parálisis flácida aguda"); ListEnf.Items.Add("Sospecha de enfermedad febril eruptiva"); ListEnf.Items.Add("Sospecha de rubéola"); ListEnf.Items.Add("Sospecha de rubéola congenita");
                ListEnf.Items.Add("Sospecha de sarampión"); ListEnf.Items.Add("Sospecha de tétanos"); ListEnf.Items.Add("Sospecha de tétanos neonatal"); ListEnf.Items.Add("Sospecha de tos ferina"); ListEnf.Items.Add("Sospecha de meningitis por haemophilus influinzae");
                ListEnf.Items.Add("Sospecha de meningitis meningocócica"); ListEnf.Items.Add("Sospecha de meningitis neumocócica"); ListEnf.Items.Add("Sospecha de meningitis tuberculosa"); ListEnf.Items.Add("Sospecha de dengue"); ListEnf.Items.Add("Sospecha de dengue grave");
                ListEnf.Items.Add("Sospecha de fiebre amarilla"); ListEnf.Items.Add("Sospecha de fiebre equina venezolana"); ListEnf.Items.Add("Sospecha de leptospirosis"); ListEnf.Items.Add("Sospecha de paludismo"); ListEnf.Items.Add("Sospecha de cólera");
                ListEnf.Items.Add("Sospecha de síndrome respiratorio agudo (SARS)"); ListEnf.Items.Add("Sospecha de conjuntivitis hemorrágica"); ListEnf.Items.Add("Sospecha de rabia humana"); ListEnf.Items.Add("Sospecha enfermedad por hantavirus");
            }
        }
        private void rbtnConfirmada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnConfirmada.Checked == true)
            {
                ListEnf.Items.Clear();
                ListEnf.Items.Add("Difteria"); ListEnf.Items.Add("Parálisis flácida aguda"); ListEnf.Items.Add("Enfermedad febril eruptiva"); ListEnf.Items.Add("Rubéola"); ListEnf.Items.Add("Rubéola congenita"); ListEnf.Items.Add("Sarampión"); ListEnf.Items.Add("Tétanos"); ListEnf.Items.Add("Tétanos neonatal"); ListEnf.Items.Add("Tos ferina"); ListEnf.Items.Add("Meningitis por haemophilus influinzae"); 
                ListEnf.Items.Add("Meningitis meningocócica"); ListEnf.Items.Add("Meningitis neumocócica"); ListEnf.Items.Add("Meningitis tuberculosa"); ListEnf.Items.Add("Dengue"); ListEnf.Items.Add("Dengue grave"); ListEnf.Items.Add("Fiebre amarilla"); ListEnf.Items.Add("Fiebre equina venezolana"); ListEnf.Items.Add("Leptospirosis"); ListEnf.Items.Add("Paludismo"); ListEnf.Items.Add("Cólera");
                ListEnf.Items.Add("Síndrome respiratorio agudo (SARS)"); ListEnf.Items.Add("Conjuntivitis hemorrágica"); ListEnf.Items.Add("Rabia humana"); ListEnf.Items.Add("Enfermedad por hantavirus"); ListEnf.Items.Add("Hepatitis aguda tipo B"); ListEnf.Items.Add("Chagas agudo"); ListEnf.Items.Add("Chagas crónico"); ListEnf.Items.Add("Leishmaniasis cutánea y mucucutánea"); ListEnf.Items.Add("Leishmaniasis visceral"); ListEnf.Items.Add("Lepra (todas las formas)");
                ListEnf.Items.Add("Toxoplasmosis"); ListEnf.Items.Add("Tuberculosis extrapulmonar"); ListEnf.Items.Add("Tuberculosis pulmonar"); ListEnf.Items.Add("Carbunco (ántrax)"); ListEnf.Items.Add("Brucelosis"); ListEnf.Items.Add("Histoplasmosis"); ListEnf.Items.Add("Sífilis adquirida"); ListEnf.Items.Add("Sífilis congénita"); ListEnf.Items.Add("Cáncer cervicouterino"); ListEnf.Items.Add("Cáncer mamario");
                ListEnf.Items.Add("Insuficiencia renal crónica"); ListEnf.Items.Add("Mordedura por serpiente venenosa"); ListEnf.Items.Add("Intoxicación paralizante o neurotóxica por mariscos"); ListEnf.Items.Add("Intoxicación por plaguicidas"); ListEnf.Items.Add("Intoxicación por metales"); ListEnf.Items.Add("Eventos supuestamente atribuibles a vacunas (ESAVI) graves"); ListEnf.Items.Add("Varicela"); ListEnf.Items.Add("Parotiditis infecciosa"); ListEnf.Items.Add("Hepatitis aguda tipo A"); ListEnf.Items.Add("Diarrea y gastroenteritis");
                ListEnf.Items.Add("Fiebre tifoidea"); ListEnf.Items.Add("Parasitismo intestinal"); ListEnf.Items.Add("Conjuntivitis bacteriana aguda"); ListEnf.Items.Add("Infección respiratoria aguda"); ListEnf.Items.Add("Influenza"); ListEnf.Items.Add("Neumonías"); ListEnf.Items.Add("Sintomático respiratorio"); ListEnf.Items.Add("Hepatitis aguda tipo C"); ListEnf.Items.Add("Chancroide"); ListEnf.Items.Add("Granuloma inguinal");
                ListEnf.Items.Add("Infecciones anogenitales por herpesvirus"); ListEnf.Items.Add("Infección por clamidia tracomatis"); ListEnf.Items.Add("Infección gonocócica"); ListEnf.Items.Add("Linfogranuloma venéreo"); ListEnf.Items.Add("Tricomoniasis"); ListEnf.Items.Add("Mordedura por animal transmisor de rabia"); ListEnf.Items.Add("Picadura por abeja africanizada"); ListEnf.Items.Add("Intoxicación alimentaria aguda"); ListEnf.Items.Add("Infarto agudo del miocardio"); ListEnf.Items.Add("Hipertensión arterial");
                ListEnf.Items.Add("Cáncer gástrico"); ListEnf.Items.Add("Cáncer de prostata"); ListEnf.Items.Add("Cáncer de pulmón"); ListEnf.Items.Add("Diabetes mellitus"); ListEnf.Items.Add("Pie diabético"); ListEnf.Items.Add("Bocio endémico"); ListEnf.Items.Add("Desnutrición proteico calórica severa"); ListEnf.Items.Add("Obesidad"); ListEnf.Items.Add("Ansiedad"); ListEnf.Items.Add("Depresión");
                ListEnf.Items.Add("Intento suicidio (conducta suicida)"); ListEnf.Items.Add("Alcoholismo"); ListEnf.Items.Add("Drogodependencia"); ListEnf.Items.Add("Tabaquismo"); ListEnf.Items.Add("Accidente de trabajo"); ListEnf.Items.Add("Herida por arma blanca"); ListEnf.Items.Add("Herida por arma de fuego"); ListEnf.Items.Add("Lesión por accidente por vehiculo automotor"); ListEnf.Items.Add("Maltrato físico"); ListEnf.Items.Add("Violación sexual");
            }
        }
        private void rbtn1año_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn1año.Checked == true)
            {
                persona.EdadPersona = "<1año";
            }
        }

        private void rbtn1a4_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn1a4.Checked == true)
            {
                persona.EdadPersona = "1a4años";
            }
        }

        private void rbtn5a9_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn5a9.Checked == true)
            {
                persona.EdadPersona = "5a9años";
            }
        }

        private void rbtn10a19_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn10a19.Checked == true)
            {
                persona.EdadPersona = "10a19años";
            }
        }

        private void rbtn20a29_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn20a29.Checked == true)
            {
                persona.EdadPersona = "20a29años";
            }
        }

        private void rtbn30a39_CheckedChanged(object sender, EventArgs e)
        {
            if (rtbn30a39.Checked == true)
            {
                persona.EdadPersona = "30a39años";
            }
        }

        private void rbtn40a49_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn40a49.Checked == true)
            {
                persona.EdadPersona = "40a49años";
            }
        }

        private void rbtn50a59_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn50a59.Checked == true)
            {
                persona.EdadPersona = "50a59años";
            }
        }

        private void rbtn60ymas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn60ymas.Checked == true)
            {
                persona.EdadPersona = "60ymasaños";
            }
        }

        private void rbtnM_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnM.Checked == true)
            {
                persona.SexoPersona = 'M';
            }
        }

        private void rbtnF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnF.Checked == true)
            {
                persona.SexoPersona = 'F';
            }
        }

        private void rbtnEstadisticas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEstadisticas.Checked == true)
            {
                ListEnf.Items.Clear();
                ListEnf.Items.Add("Muertes infantiles"); ListEnf.Items.Add("Muertes maternas"); ListEnf.Items.Add("Abortos");
            }
        }

        private void RegistroPacientes_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'enfermedadesDataSet.EnfermedadesView' table. You can move, or remove it, as needed.
            //this.enfermedadesViewTableAdapter.Fill(this.enfermedadesDataSet.EnfermedadesView);
            for (int i = 1; i <=117 ; i++)
            {
                IdsEnf.Add(i);
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            OpcionesRegistros frmopciones = new OpcionesRegistros();
            frmopciones.Visible = true;
            this.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            indice = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Inicio_1.usuarioAdmitido == "admin")
            {
                try
                {
                    if (indice != 0)
                    {
                        cmd = new SqlCommand("DELETE FROM Enfermedades WHERE IdPersona = @IdPersona", conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Idpersona", indice);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Registro eliminado con exito", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizarGrid();

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Su usuario no es un administrador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)//insert en la base de datos
        {
            try
            {
                conn.Open();
                //insert a tabla persona
                string insertPersona, insertEnfermedad, insertAspecto;
                insertPersona = "INSERT INTO Personas(Edad,Sexo,Fecha)";
                insertPersona += "VALUES (@Edad,@Sexo,@Fecha)";
                insert1 = new SqlCommand(insertPersona, conn);
                insert1.Parameters.Add(new SqlParameter("@Edad", SqlDbType.VarChar));
                insert1.Parameters["@Edad"].Value = persona.EdadPersona;
                insert1.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.VarChar));
                insert1.Parameters["@Sexo"].Value = persona.SexoPersona;
                insert1.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.Date));
                insert1.Parameters["@Fecha"].Value = DateTime.Now.ToString("yyyy-MM-dd");


                //insert tabla enfermedades
                insertEnfermedad = "INSERT INTO Enfermedades(IdEnfermedad,Enfermedad,Clasificacion)";
                insertEnfermedad += "VALUES (@IdEnfermedad,@Enfermedad,@Clasificacion)";
                insert2 = new SqlCommand(insertEnfermedad, conn);
                insert2.Parameters.Add(new SqlParameter("@IdEnfermedad", SqlDbType.Int));
                if (rbtnSospecha.Checked == true)
                {
                    for (int i = 0; i <117; i++)
                    {
                        if (ListEnf.SelectedIndex+1 == IdsEnf[i])
                        {
                            insert2.Parameters["@IdEnfermedad"].Value = IdsEnf[i];
                        }
                    }
                }
                else if (rbtnConfirmada.Checked == true)
                {
                    for (int i = 0; i < 117; i++)
                    {
                        if (ListEnf.SelectedIndex+1 == IdsEnf[i]-24)
                        {
                            insert2.Parameters["@IdEnfermedad"].Value = IdsEnf[i];
                        }
                    }
                }
                else if (rbtnEstadisticas.Checked == true)
                {
                    for (int i = 0; i < 117; i++)
                    {
                        if (ListEnf.SelectedIndex+1 == IdsEnf[i]-114)
                        {
                            insert2.Parameters["@IdEnfermedad"].Value = IdsEnf[i];
                        }
                    }
                }
               
                insert2.Parameters.Add(new SqlParameter("@Enfermedad", SqlDbType.VarChar));
                insert2.Parameters["@Enfermedad"].Value = ListEnf.SelectedItem;
                insert2.Parameters.Add(new SqlParameter("@Clasificacion", SqlDbType.VarChar));
                if (rbtnSospecha.Checked == true)
                {
                    enf.ClasificacionEnf = "Sospecha";
                    insert2.Parameters["@Clasificacion"].Value = enf.ClasificacionEnf;
                }
                else if (rbtnConfirmada.Checked == true)
                {
                    enf.ClasificacionEnf = "Confirmada";
                    insert2.Parameters["@Clasificacion"].Value = enf.ClasificacionEnf;
                }
                else if (rbtnEstadisticas.Checked == true)
                {
                    enf.ClasificacionEnf = "Estadisticas vitales";
                    insert2.Parameters["@Clasificacion"].Value = enf.ClasificacionEnf;
                }
                
                insert1.ExecuteNonQuery();
                insert2.ExecuteNonQuery();
                MessageBox.Show("Registro agregado con exito!", "Alerta", MessageBoxButtons.OK);
                conn.Close();
                actualizarGrid();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }
    }
}
