using System.Data;
using Microsoft.Data.SqlClient;

namespace ProyectoBD
{
    public class DBConexion
    {
        private string cadenaConexion;

        public DBConexion(string cadena)
        {
            cadenaConexion = cadena;
        }

        // SELECT → devuelve DataSet
        public DataSet EjecutarSelect(string sql)
        {
            DataSet ds = new DataSet();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
            }

            return ds;
        }

        // INSERT, UPDATE, DELETE → devuelve filas afectadas
        public int EjecutarComando(string sql)
        {
            int filas = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    filas = cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
                Logger.Escribir("ERROR SQL: " + ex.Message);
            }

            return filas;
        }
    }
}

