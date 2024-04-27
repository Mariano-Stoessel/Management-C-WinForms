using Dominio;
using LecturaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Principal
{
    public partial class VentanaCategoriasyMarcas : Form
    {
  


        private List<Categoria> ListaLecturaCategorias;

        private List<Marca> listaLecturaMarcas;
        
        private void cargarmarca()
        {
            LecturaMarca lecturaMar = new LecturaMarca();
            listaLecturaMarcas = lecturaMar.listar();
            dgvMarcas.DataSource = lecturaMar.listar();
        }
        private void cargarcategoria()
        {
            LecturaCategoria lecturaCat = new LecturaCategoria();
            ListaLecturaCategorias = lecturaCat.listar();
            dgvListaCategorias.DataSource = lecturaCat.listar();
        }

        
        private void Agregar(Marca marca)
        {
            LecturaMarca lecturaMarca = new LecturaMarca();
            try
            {
                marca.Descripcion = txtAgregarMarca.Text;
                lecturaMarca.agregar(marca);

                LecturaMarca lecturaMar = new LecturaMarca();
                listaLecturaMarcas = lecturaMar.listar();
                dgvMarcas.DataSource = lecturaMar.listar();

                MessageBox.Show("Agregado exitosamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void Agregar(Categoria categoria)
        {
            LecturaCategoria lecturaCat = new LecturaCategoria();
            try
            {
                categoria.Descripcion = textAgregarCategoria.Text;
                lecturaCat.agregar(categoria);


                ListaLecturaCategorias = lecturaCat.listar();
                dgvListaCategorias.DataSource = lecturaCat.listar();

                MessageBox.Show("Agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void Modificar(Categoria categoria)
        {
            LecturaCategoria lecturaCat = new LecturaCategoria();
            try
            {
                categoria.Descripcion = textAgregarCategoria.Text;
                lecturaCat.modificar(categoria);


                ListaLecturaCategorias = lecturaCat.listar();
                dgvListaCategorias.DataSource = lecturaCat.listar();

                MessageBox.Show("Modificado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void Modificar(Marca marca)
        {
            LecturaMarca lecturaMar = new LecturaMarca();
            try
            {
                marca.Descripcion = txtAgregarMarca.Text;
                lecturaMar.modificar(marca);


                listaLecturaMarcas = lecturaMar.listar();
                dgvMarcas.DataSource = lecturaMar.listar();

                MessageBox.Show("Modificado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }


        public VentanaCategoriasyMarcas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VentanaCategorias_Load(object sender, EventArgs e)
        {
            //refresh Categorias
            cargarcategoria();

            //refresh Marcas
            cargarmarca();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            Agregar(categoria);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            Agregar(marca);
            
        }
        


        private void btnEditarCategoria_Click_1(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)dgvListaCategorias.CurrentRow.DataBoundItem;

            Modificar(categoria);
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            Modificar(marca);
        }
    }
}
