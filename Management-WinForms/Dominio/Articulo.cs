using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Dominio
{
    public class Articulo
    {
        public Articulo()
        {
            Id = 0;
            Codigo = "";
            Nombre = "";
            Descripcion = "";
            Marca = new Marca();
            Categoria = new Categoria();
            ImagenUrl = "";
            Precio = 0;
        }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categoria { get; set; }
        public Marca Marca { get; set; }
        public string ImagenUrl { get; set; }
        public SqlMoney Precio { get; set; }
    }
}
