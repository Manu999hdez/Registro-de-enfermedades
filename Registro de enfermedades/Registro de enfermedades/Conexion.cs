using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Registro_de_enfermedades
{
    class Conexion
    {
        public static string Servidor="localhost";
        public static string BD;
        public static string server;
        public static string cadena;
        public static string clave, user;

        public static void conectar()
        {
            server = Servidor;
            BD = "RegistroEnfermedades"; user = "sa"; clave = "123456";
            cadena = "server=" + server + ";uid=" + user + ";pwd=" + clave + ";database=" + BD;
        }
    }
}
