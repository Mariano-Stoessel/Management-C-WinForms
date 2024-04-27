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
            LecturaCategoria LecturaCategoria = new LecturaCategoria();
            LecturaMarca LecturaMarca = new LecturaMarca();
            try
            {
                cbxMarca.Items.Insert(0, "Cualquier marca");
                cbxMarca.SelectedIndex = 0;

                cbxCategoria.Items.Insert(0, "Cualquier categoría");
                cbxCategoria.SelectedIndex = 0;

                cbxMarca.DataSource = LecturaMarca.listar();
                cbxCategoria.DataSource = LecturaCategoria.listar();

                CargarDatos();
                cbxOrdenar.Items.Add("Menor Código");
                cbxOrdenar.Items.Add("Mayor Código");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
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

                ocultarColumnas();
                CargarImagen(listaLecturaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvListaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvListaArticulos.CurrentCell != null)
            {
                Articulo seleccionado = (Articulo)dgvListaArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void ocultarColumnas()
        {
            dgvListaArticulos.Columns["Id"].Visible = false;
            dgvListaArticulos.Columns["ImagenUrl"].Visible = false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarArticulo();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarArticulo();
        }

        private void filtrarArticulo()
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text;
            if (filtro.Length >= 2)
            {
                listaFiltrada = listaLecturaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(filtro.ToUpper()) || x.Nombre.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaLecturaArticulos;
            }
            dgvListaArticulos.DataSource = null;
            dgvListaArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cbxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string opcion = cbxOrdenar.SelectedItem.ToString();
            if(opcion == "Menor Código")
            {
                listaFiltrada = listaLecturaArticulos.OrderBy(x => x.Codigo).ToList();
                txtBuscar.Text = "";
            }
            else
            {
                listaFiltrada = listaLecturaArticulos.OrderByDescending(x => x.Codigo).ToList();
                txtBuscar.Text = "";
            }
            dgvListaArticulos.DataSource = null;
            dgvListaArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
    }
}
