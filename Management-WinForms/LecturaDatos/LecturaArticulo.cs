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
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT A.Codigo as 'Código', A.Nombre, A.Descripcion, M.Descripcion AS 'Marca', C.Descripcion as 'Categoría', I.ImagenUrl, A.Precio FROM ARTICULOS A\r\n" +
                    "INNER JOIN CATEGORIAS C ON C.Id = A.IdCategoria\r\n" +
                    "INNER JOIN MARCAS M ON M.Id = A.IdMarca\r\n" +
                    "INNER JOIN IMAGENES I ON I.IdArticulo = A.Id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Código"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    aux.Marca = new Marca();
                    aux.Marca.Descripcion =  (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoría"];

                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = datos.Lector.GetSqlMoney(6);

                    lista.Add(aux);
                }
                datos.CerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
