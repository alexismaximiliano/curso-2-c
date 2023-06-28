using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace funciones
{
    public class Funciones
    {
        public List<Articulos> listar()
        {
            List<Articulos>lista= new List<Articulos>();
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;

            try
            {
                Conexion.ConnectionString= "server=DESKTOP-EET0Q6K\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "select nombre,Precio,ImagenUrl from ARTICULOS";
                //Comando.CommandText = "select nombre,M.Descripcion as Marca,C.Descripcion as Categoria, precio, ImagenUrl from ARTICULOS A, MARCAS M,CATEGORIAS C where M.id =A.IdMarca and C.Id=A.IdCategoria";
                Comando.Connection= Conexion;

                Conexion.Open();
                Lector= Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Articulos aux = new Articulos();
                   
                    aux.Nombre = (string)Lector["Nombre"];
                   // aux.Marca.Descripcion = (string)Lector["Marca"];
                    //aux.Categoria.Descripcion = (string)Lector["Categoria"];
                    aux.Precio = (int)Lector["precio"];
                    aux.Imagen = (string)Lector["imagen"];
                    lista.Add(aux);
                }
                Conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {   
                throw ex;
            }

        }
        /*public void agregar(Articulos nuevo)//seguir
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("");
            }
            catch (Exception ex)
            {

                throw ex;
            }*/
        }

    }

