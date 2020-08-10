using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_enfermedades
{
    class Paciente
    {
        private int Id_Persona = 0;
        private string Edad;
        private char Sexo;
        private string fechaingreso;

        public int ID_Persona
        {
            get { return Id_Persona; }
            set { Id_Persona = value; }
        }
        public string EdadPersona
        {
            get { return Edad; }
            set { Edad = value; }
        }
        public char SexoPersona
        {
            get { return Sexo; }
            set { Sexo = value; }
        }
        public string FechaIngreso
        {
            get { return fechaingreso; }
            set { fechaingreso = value; }
        }
    }
}
