using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecturaDatos
{
    public class LecturaImagen
    {
        public List<Imagen> listar(int Id)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT I.IdArticulo, I.ImagenUrl FROM IMAGENES I INNER JOIN ARTICULOS A ON I.IdArticulo = A.Id WHERE I.IdArticulo = @idArticuloActual");
                datos.SetearParametro("@iDarticuloActual", Id);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public int maximoImagen(int Id)
        {
            int maximoImagenes = 0;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT COUNT (IdArticulo) ImgMaximo FROM IMAGENES WHERE IdArticulo = @idArticuloActual");
                datos.SetearParametro("@iDarticuloActual", Id);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    maximoImagenes = (int)datos.Lector["ImgMaximo"];
                }
                return maximoImagenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
