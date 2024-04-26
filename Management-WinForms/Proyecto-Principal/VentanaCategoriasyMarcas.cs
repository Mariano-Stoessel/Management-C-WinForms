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

namespace Proyecto_Principal
{
    public partial class VentanaCategoriasyMarcas : Form
    {

        private List<Categoria> ListaLecturaCategorias;

        private List<Marca> listaLecturaMarcas;

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
            LecturaCategoria lecturaCat = new LecturaCategoria();
            ListaLecturaCategorias = lecturaCat.listar();
            dgvListaCategorias.DataSource = lecturaCat.listar();

            //refresh Marcas
            LecturaMarca lecturaMar = new LecturaMarca();
            listaLecturaMarcas = lecturaMar.listar();
            dgvMarcas.DataSource = lecturaMar.listar();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria NuevaCat = new Categoria();
            LecturaCategoria lecturaCat = new LecturaCategoria();
            try
            {
                NuevaCat.Descripcion = textAgregarCategoria.Text;
                lecturaCat.agregar(NuevaCat);

               
                ListaLecturaCategorias = lecturaCat.listar();
                dgvListaCategorias.DataSource = lecturaCat.listar();

                MessageBox.Show("Agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Marca NuevaMarca = new Marca();
            LecturaMarca lecturaMarca = new LecturaMarca();
            try
            {
                NuevaMarca.Descripcion = txtAgregarMarca.Text;
                lecturaMarca.agregar(NuevaMarca);

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
    }
}
