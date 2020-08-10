using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Registro_de_enfermedades
{
    class Enfermedad
    {
        private int Id_Enfermedad;
        private string Nombre;
        private string Clasificacion;
        private int Id_Aspecto;
        private string Aspecto;

        public int ID_Enfermedad
        {
            get { return Id_Enfermedad; }
            set { Id_Enfermedad = value; }
        }
        public string NombreEnf
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string ClasificacionEnf
        {
            get { return Clasificacion; }
            set { Clasificacion = value; }
        }
        public int ID_Aspecto
        {
            get { return Id_Aspecto; }
            set { Id_Aspecto = value; }
        }
        public string AspectoEnf
        {
            get { return Aspecto; }
            set { Aspecto = value; }
        }

    }
}
