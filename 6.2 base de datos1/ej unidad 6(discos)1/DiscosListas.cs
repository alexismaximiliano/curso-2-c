using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ej_unidad_6_discos_
{
    internal class DiscosListas
    {
        public List<Discos> Listar()
        {
            List<Discos> lista = new List<Discos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB;integrated security =true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "  select CantidadCanciones,FechaLanzamiento,titulo,UrlImagenTapa,E.Descripcion as genero,T.Descripcion as edicion from DISCOS D,ESTILOS E,TIPOSEDICION T where E.Id=D.IdEstilo and T.Id=D.IdTipoEdicion";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Discos aux = new Discos();

                    
                    
                    aux.Titulo = (string)lector["Titulo"];
                    aux.Genero = new Estilos();
                    aux.Genero.Estilo = (string)lector["Estilo"];
                    aux.UrlTapa = (string)lector["Url"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.Edicion = (string)lector["Edicion"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
        
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
