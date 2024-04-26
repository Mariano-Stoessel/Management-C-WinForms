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
    public partial class VentanaListaDeArticulos : Form
    {
        private List<Articulo> listaLecturaArticulos;

        public VentanaListaDeArticulos()
        {
            InitializeComponent();
        }
        private void VentanaListaDeArticulos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void CargarDatos()
        {
            try
            {
                LecturaArticulo lecturaArticulo = new LecturaArticulo();
                listaLecturaArticulos = lecturaArticulo.listar();
                dgvListaArticulos.DataSource = lecturaArticulo.listar();

                dgvListaArticulos.Columns["Id"].Visible = false;
                dgvListaArticulos.Columns["ImagenUrl"].Visible = false;

                CargarImagen(listaLecturaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void dgvListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.ImagenUrl);
        }

        private void CargarImagen(string imagenUrl)
        {
            try
            {
                pbxImagenUrl.Load(imagenUrl);
            }
            catch (Exception)
            {

                pbxImagenUrl.Load("https://storage.googleapis.com/proudcity/mebanenc/uploads/2021/03/placeholder-image.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta = new frmAgregarArticulo();
            alta.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
            frmAgregarArticulo editar = new frmAgregarArticulo(seleccionado);
            editar.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LecturaArticulo lecturaArticulo = new LecturaArticulo();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el artículo?", "Eliminar Artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                    lecturaArticulo.eliminarArticulo(seleccionado.Id);

                    MessageBox.Show("Artículo eliminado correctamente");
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
