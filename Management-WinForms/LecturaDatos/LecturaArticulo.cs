using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Dominio;

namespace LecturaDatos
{
    public class LecturaArticulo
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Codigo as 'Código', A.Nombre, A.Descripcion, M.Descripcion AS 'Marca', C.Descripcion as 'Categoría', I.ImagenUrl, A.Precio FROM ARTICULOS A\r\n" +
                    "INNER JOIN CATEGORIAS C ON C.Id = A.IdCategoria\r\n" +
                    "INNER JOIN MARCAS M ON M.Id = A.IdMarca\r\n" +
                    "INNER JOIN IMAGENES I ON I.IdArticulo = A.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = lector.GetString(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Descripcion = lector.GetString(2);

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = lector.GetString(3);

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = lector.GetString(4);

                    aux.ImagenUrl = lector.GetString(5);
                    aux.Precio = lector.GetSqlMoney(6);

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
