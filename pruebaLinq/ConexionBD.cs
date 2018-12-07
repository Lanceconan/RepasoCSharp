using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pruebaLinq
{
    class ConexionBD
    {
        public SqlConnection conexion;

        public ConexionBD()
        {
            SetConexionBD();
        }

        public void SetConexionBD()
        {
            conexion = new SqlConnection("server=DESKTOP-JSK36JD\\SQLEXPRESS ; database=testDataBase ; integrated security = true");
           
        }

        public SqlConnection GetConexionBD()
        {
            return conexion;
        }

        public SqlDataReader ExecuteQuery(string query)
        {
            SetConexionBD();
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, GetConexionBD());
            SqlDataReader registros = comando.ExecuteReader();                       
            return registros;
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }


    }
}
