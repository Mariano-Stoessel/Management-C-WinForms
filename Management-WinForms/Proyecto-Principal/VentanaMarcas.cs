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
    public partial class VentanaMarcas : Form
    {
        private List<Marca> listaLecturaMarcas;
        public VentanaMarcas()
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

        private void VentanaMarcas_Load(object sender, EventArgs e)
        {
            LecturaMarca lecturaMar = new LecturaMarca();
            listaLecturaMarcas = lecturaMar.listar();
            dgvListaMarca.DataSource = lecturaMar.listar();

           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marca NuevaMarca = new Marca();
            LecturaMarca lecturaMarca = new LecturaMarca();
            try
            {
                NuevaMarca.Descripcion = txtAgregarMarca.Text;
                lecturaMarca.agregar(NuevaMarca);

                LecturaMarca lecturaMar = new LecturaMarca();
                listaLecturaMarcas = lecturaMar.listar();
                dgvListaMarca.DataSource = lecturaMar.listar();

                MessageBox.Show("Agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
                
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
