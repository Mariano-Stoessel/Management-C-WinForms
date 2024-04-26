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
    public partial class VentanaCategorias : Form
    {

        private List<Categoria> ListaLecturaCategorias;
        public VentanaCategorias()
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
            LecturaCategorias lecturaCat = new LecturaCategorias();
            ListaLecturaCategorias = lecturaCat.listar();
            dgvListaCategorias.DataSource = lecturaCat.listar();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria NuevaCat = new Categoria();
            LecturaCategorias lecturaCat = new LecturaCategorias();
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
    }
}
