using Dominio;
using LecturaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using LecturaDatos;

namespace Proyecto_Principal
{
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }
        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            LecturaCategorias LecturaCat = new LecturaCategorias();
            LecturaMarca LecturaMar = new LecturaMarca();
            try
            {
                cbxCategoria.DataSource = LecturaCat.listar();
                cbxMarca.DataSource = LecturaMar.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            LecturaArticulo lecturaArt = new LecturaArticulo();
            try
            {
                nuevoArticulo.Codigo = txtCodigo.Text;
                nuevoArticulo.Nombre = txtNombre.Text;
                nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);
                nuevoArticulo.Descripcion = txtDescripcion.Text;

                nuevoArticulo.ImagenUrl = (string)txtImagenUrl.Text;

                nuevoArticulo.Marca = (Marca)cbxMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                lecturaArt.agregar(nuevoArticulo);
                lecturaArt.agregarImagen(nuevoArticulo);
                MessageBox.Show("Artículo agregado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void cargarImagen(string imagenUrl)
        {
            try
            {
                pbxImagenUrl.Load(imagenUrl);
            }
            catch (Exception ex)
            {
                pbxImagenUrl.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }
    }
}
