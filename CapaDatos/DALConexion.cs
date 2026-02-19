using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DALConexion
    {

        private SqlConnection Conexion = new SqlConnection("Data Source= DESKTOP-R9RN64N\\SQLEXPRESS;Initial Catalog=BD_TEST;Integrated Security=True;Encrypt=False;");

        public SqlConnection OpenConnection()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CloseConnection()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
                Conexion.Close();
            return Conexion;
        }
    }
}

