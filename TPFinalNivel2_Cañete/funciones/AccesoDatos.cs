using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace funciones
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            conexion=new SqlConnection("server=DESKTOP-EET0Q6K\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            comando=new SqlCommand();
        }
        public void SetearConsulta(string Consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = Consulta;
        }
        public void EjecutarConsulta()
        {
            comando.Connection= conexion;
            try
            {
                conexion.Open();
                lector=comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();  
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SetearParametro(string nombre,string valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);

        }
        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
    }
}
